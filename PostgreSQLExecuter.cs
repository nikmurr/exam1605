using AdmissionCommittee.DataModelClasses;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionCommittee
{
    public class PostgreSQLExecuter
    {
        private readonly string connectionString;
        private NpgsqlConnection connection;

        public PostgreSQLExecuter(string host, string database, string username, string password)
        {
            try
            {
                connectionString = $"Host={host};Database={database};Username={username};Password={password};";
                connection = new NpgsqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //

        public int IsSignInValid(string login, string password, bool isAppl)
        {
            int userRoleId;
            if (isAppl) userRoleId = 2;
            else userRoleId = 3;
            string query = $"SELECT password FROM users WHERE login = @Login AND role_id = @RoleID";

            try
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@RoleID", userRoleId);

                    object result = command.ExecuteScalar();

                    if (result == null)
                    {
                        return 1;
                    }
                    else
                    {
                        string storedPassword = result.ToString();

                        if (password == storedPassword)
                        {
                            // Пароль совпадает
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return 3;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public List<Applicant> GetAllApplicants()
        {
            try
            {
                List<Applicant> applicants = new List<Applicant>();
                DataTable dataTable;
                dataTable = ExecuteQuery("SELECT * FROM applicants;");

                foreach (DataRow row in dataTable.Rows)
                {
                    Applicant applicant = new Applicant
                    {
                        Id = Convert.ToInt32(row["id"]),
                        UserId = Convert.ToInt32(row["user_id"]),
                        EducationTypeId = Convert.ToInt32(row["education_type_id"]),
                        FullName = Convert.ToString(row["full_name"]),
                        PassportNumber = Convert.ToString(row["passport_number"]),
                        SNILS = Convert.ToString(row["SNILS"]),
                        Email = Convert.ToString(row["email"]),
                        Phone = Convert.ToString(row["phone"]),
                        ParentFullName = Convert.ToString(row["parent_full_name"]),
                        InstitutionAttended = Convert.ToString(row["institution_attended"]),
                        DiplomaScore = row["diploma_score"] == DBNull.Value ? (float?)null : Convert.ToSingle(row["diploma_score"]),
                        CertificateScore = row["certificate_score"] == DBNull.Value ? (float?)null : Convert.ToSingle(row["certificate_score"]),
                        EgeScore = row["ege_score"] == DBNull.Value ? (float?)null : Convert.ToSingle(row["ege_score"]),
                        SpecialtyId = Convert.ToInt32(row["specialty_id"]),
                        EducationDocumentScan = Convert.ToString(row["education_document_scan"])
                    };

                    applicants.Add(applicant);
                }

                return applicants;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool RegisterUser(string login, string password_hashed, Dictionary<string, string> registerData, out string message)
        {
            string query = $"INSERT INTO users (role_id, login, password) VALUES (2, '{login}', '{password_hashed}');";
            bool result = ExecuteNonQuery(query, out message);

            int uid;
            query = $"SELECT id FROM users WHERE login = '{login}'";

            DataTable idTable = ExecuteQuery(query);
            if (idTable != null && idTable.Rows.Count > 0)
            {
                int userId = Convert.ToInt32(idTable.Rows[0]["id"]);
                uid = userId;


                try
                {
                    query = $@"
            INSERT INTO applicants (
                user_id, education_type_id, full_name, passport_number, 
                SNILS, email, phone, parent_full_name, institution_attended, 
                diploma_score, certificate_score, ege_score, specialty_id
            ) VALUES (
                {uid}, {registerData["education_type_id"]}, '{registerData["full_name"]}', '{registerData["passport_number"]}', 
                '{registerData["SNILS"]}', '{registerData["email"]}', '{registerData["phone"]}', '{registerData["parent_full_name"]}', '{registerData["institution_attended"]}', 
                {(registerData.ContainsKey("diploma_score") ? registerData["diploma_score"] : "NULL")}, 
                {(registerData.ContainsKey("certificate_score") ? registerData["certificate_score"] : "NULL")}, 
                {(registerData.ContainsKey("ege_score") ? registerData["ege_score"] : "NULL")}, 
                {registerData["specialty_id"]}
            )";
                    // Выполняем запрос
                    ExecuteNonQuery(query, out message);
                    return true;
                }
                catch (Exception ex)
                {
                    message = $"Ошибка регистрации: {ex.Message}";
                    return false;
                }
            }
            else
            {
                message = "Неизвестная ошибка";
                return false;
            }
        }


        //

        public DataTable ExecuteQuery(string query)
        {
            try
            {
                connection.Open();
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public bool ExecuteNonQuery(string query, out string message)
        {
            try
            {
                connection.Open();
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                message = $"Данные добавлены.";
                return true;
            }
            catch (Npgsql.PostgresException pgEx)
            {
                // Обработка исключений PostgreSQL
                if (pgEx.SqlState == "23505")
                {
                    message = $"Исключение PostgreSQL: {pgEx.Message}. Пользователь с такими данными уже существует.";
                    return false;
                }
                else
                {
                    message = $"Исключение PostgreSQL: {pgEx.Message}. Поробуйте повторить позже.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                message = $"Ошибка: {ex.Message}";
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
