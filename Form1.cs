using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionCommittee
{
    public partial class Form1 : Form
    {

        public PrivateFontCollection fontCollection = new PrivateFontCollection();
        PostgreSQLExecuter postgreSQLExecuter;
        List<Font> fontList = new List<Font>();
        bool isAppl;
        bool regFirstSet = false;

        int eduLevel = 0;

        public DataTable levelsData = null;
        public DataTable specialtiesData = null;

        Dictionary<string, string> registerData;

        Image inpt_combo_reg = Image.FromFile(FileHelper.GetItem("combo_box_reg.png"));
        Image inpt_reg = Image.FromFile(FileHelper.GetItem("text_input_reg.png"));
        Image inpt_login = Image.FromFile(FileHelper.GetItem("text_input_login.png"));

        Image appl_on = Image.FromFile(FileHelper.GetItem("button_auth_appl_on.png"));
        Image appl_off = Image.FromFile(FileHelper.GetItem("button_auth_appl_off.png"));
        Image pk_on = Image.FromFile(FileHelper.GetItem("button_auth_pk_on.png"));
        Image pk_off = Image.FromFile(FileHelper.GetItem("button_auth_pk_off.png"));
        Image dfauth = Image.FromFile(FileHelper.GetItem("button_auth.png"));
        Image dfreg = Image.FromFile(FileHelper.GetItem("button_reg.png"));
        Image dfreg_comp = Image.FromFile(FileHelper.GetItem("button_reg_complete.png"));

        Image mini_back = Image.FromFile(FileHelper.GetItem("button_mini_back.png"));

        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            postgreSQLExecuter = new PostgreSQLExecuter("localhost", "admission_committee", "postgres", "3409");

            fontCollection.AddFontFile(FileHelper.GetItem("Inter-Regular.ttf"));
            fontCollection.AddFontFile(FileHelper.GetItem("Inter-SemiBold.ttf"));
            fontCollection.AddFontFile(FileHelper.GetItem("RG-StandardMedium.ttf"));

            //мультипликатор из фигмы: 0.72
            Font fontFieldLabels = new Font(fontCollection.Families[0], 15);
            Font fontFieldTextBox = new Font(fontCollection.Families[0], 14);
            Font fontH1 = new Font(fontCollection.Families[2], 52);

            fontList.Insert(0, fontFieldLabels);
            fontList.Insert(1, fontFieldTextBox);
            fontList.Insert(2, fontH1);

            headerAuth.Font = fontH1;
            headerReg.Font= fontH1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            inputFieldLogin.SetData(fontList, inpt_login, "Логин", "", isReqiered:true, fullfilledCriteria:4);
            inputFieldPassword.SetData(fontList, inpt_login, "Пароль", "", isPassword:true, isReqiered: true, fullfilledCriteria: 8);

            stateButtonAppl.SetButton(appl_on, appl_off, true);
            stateButtonAppl.AddClickHandler(setMode);

            stateButtonPK.SetButton(pk_on, pk_off);
            stateButtonPK.AddClickHandler(setMode);

            defaultButtonApplAuth.SetButton(dfauth);
            defaultButtonApplAuth.AddClickHandler(trySignIn);

            defaultButtonApplReg.SetButton(dfreg);
            defaultButtonApplReg.AddClickHandler(openRegistration);

            miniButtonBack.SetButton(mini_back);
            miniButtonBack.AddClickHandler(GetBack);
            miniButtonBack2.SetButton(mini_back);
            miniButtonBack2.AddClickHandler(GetBack);
            miniButtonBack3.SetButton(mini_back);
            miniButtonBack3.AddClickHandler(GetBack);

            isAppl = true;

            this.ResumeLayout(true);

            setRegistrationState();
        }

        void setMode()
        {
            stateButtonAppl.SetClick();
            stateButtonPK.SetClick();
            inputFieldLogin.ClearText();
            inputFieldPassword.ClearText();

            if (stateButtonAppl.isSet)
            {
                isAppl = true;
            }
            else
            {
                isAppl = false;
            }
            setRegistrationState();
        }

        void trySignIn()
        {
            if (inputFieldLogin.isFullfilled && inputFieldPassword.isFullfilled)
            {
                string login = inputFieldLogin.inputText;
                string password = Tools.Hash256(inputFieldPassword.inputText);
                int authResult = postgreSQLExecuter.IsSignInValid(login, password, isAppl);
                if (authResult == 0) 
                { 
                    if (isAppl)
                    {
                        applPanel.Visible= true;
                    }
                    else
                    {
                        pkPanel.Visible= true;
                    }
                }
                else if (authResult == 1) {
                    MessageBox.Show(
                    "Неверно введен пароль. ", 
                    "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (authResult == 2) { MessageBox.Show("Pass noo"); }
                else { MessageBox.Show("Every nooo"); }
            }
            else
            {
                MessageBox.Show(

                    "Некорректно введены логин или пароль. " +
                    "\n\n Минимальная длина логина — 4 символа; " +
                    "\n\n Минимальная длина пароля — 8 символов;", 

                    "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void setRegistrationState()
        {
            if (isAppl)
            {
                defaultButtonApplReg.SetState(true);
            }
            else
            {
                defaultButtonApplReg.SetState(false);
            }
        }

        void openRegistration()
        {
            this.SuspendLayout();
            authPanel.Visible= false;
            regPanel.Visible = true;
            this.ResumeLayout(true);
        }

        private void regPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (regPanel.Visible == true)
            {
                eduLevel = 0;
                regFirstSet = false;
                this.SuspendLayout();

                flowLayoutPanel3.Visible = false;
                flowLayoutPanel2.Visible = true;
                defaultButtonAcceptReg.Visible = true;
                defaultButtonAcceptRegFinal.Visible = false;

                inputFieldFIO.SetData(fontList, inpt_reg, "ФИО", "Иванов Иван Иванович", isReqiered: true);
                inputFieldBD.SetData(fontList, inpt_reg, maskType: "00.00.0000", maskChar: '_', "Дата рождения",  isReqiered: true);
                inputFieldMail.SetData(fontList, inpt_reg, "Электронная почта", "mail@example.ru", isReqiered: true);
                inputFieldPhone.SetData(fontList, inpt_reg, maskType: "+7 (000) 000-00-00", maskChar: '_', "Номер телефона", isReqiered: true);
                inputFieldPass.SetData(fontList, inpt_reg, maskType: "00 00 000000", maskChar: '_', "Серия и номер паспорта", isReqiered: true);
                inputFieldSnils.SetData(fontList, inpt_reg, maskType: "000-000-000 00", maskChar: '_', "СНИЛС", isReqiered: true);
                inputFieldParFIO.SetData(fontList, inpt_reg, "ФИО родителя/опекуна", "Сидоров Петр Семёнович", isReqiered: true);
                inputFieldUniv.SetData(fontList, inpt_reg, "Оконченное УЗ", "", isReqiered: true);

                defaultButtonAcceptReg.SetButton(dfreg_comp);
                defaultButtonAcceptReg.AddClickHandler(TryRegister);

                string queryLevels = "SELECT * FROM education_types;";

                if (levelsData == null)
                {
                    levelsData = postgreSQLExecuter.ExecuteQuery(queryLevels);
                }       

            inputComboLevel.SetData(
                    levelsData,
                    fontList,
                    inpt_combo_reg,
                    displayColumn: "type_name",
                    valueColumn: "id",
                    labelText: "Уровень образования",
                    isReqiered: true,
                    selectedIndex: 0);

                SetEduLevel();

                inputComboLevel.ComboBoxSelectedIndexChanged += CustomControl1_ComboBoxSelectedIndexChanged;

                this.ResumeLayout(true);
            }
        }

        private void SetEduLevel()
        {
            int index = inputComboLevel.selectedIndex;

            if (index != -1)
            {
                eduLevel = index + 1;
                if (eduLevel == 1)
                {
                    inputFieldScore.SetData(fontList, inpt_reg, "Средний балл аттестата", "0.00", isReqiered: true);
                }
                else if (eduLevel == 2)
                {
                    inputFieldScore.SetData(fontList, inpt_reg, "Средний балл ЕГЭ", "00.0", isReqiered: true);
                }
                else
                {
                    inputFieldScore.SetData(fontList, inpt_reg, "Средний балл диплома", "00.0", isReqiered: true);
                }
                string querySpecialties = $"SELECT id, specialty_name FROM specialties WHERE education_type_id = {eduLevel};";
                specialtiesData = postgreSQLExecuter.ExecuteQuery(querySpecialties);
                inputComboDir.SetData(
                    specialtiesData,
                    fontList,
                    inpt_combo_reg,
                    displayColumn: "specialty_name",
                    valueColumn: "id",
                    labelText: "Направление обучения",
                    isReqiered: true,
                    listWidth: 1000);
            }
        }

        private void CustomControl1_ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            SetEduLevel();
        }

        private void TryRegister()
        {
            registerData = new Dictionary<string, string>();

            if (
                inputFieldFIO.isFullfilled &&
                inputFieldBD.isFullfilled && 
                inputFieldMail.isFullfilled &&
                inputFieldPhone.isFullfilled &&
                inputFieldPass.isFullfilled &&
                inputFieldSnils.isFullfilled &&
                inputFieldParFIO.isFullfilled &&
                inputFieldUniv.isFullfilled &&
                inputFieldScore.isFullfilled &&
                inputComboLevel.selectedIndex > -1 &&
                inputComboDir.selectedIndex > -1
            )
            {
                float? score = Tools.StringToFloat(inputFieldScore.inputText);
                if (Tools.CheckScore(eduLevel, score))
                {
                    registerData.Add("user_id", "");
                    registerData.Add("education_type_id", inputComboLevel.GetValue());
                    registerData.Add("full_name", inputFieldFIO.inputText);
                    registerData.Add("passport_number", inputFieldPass.inputText);
                    registerData.Add("SNILS", inputFieldSnils.inputText);
                    registerData.Add("email", inputFieldMail.inputText);
                    registerData.Add("phone", inputFieldPhone.inputText);
                    registerData.Add("institution_attended", inputFieldUniv.inputText);
                    registerData.Add("parent_full_name", inputFieldParFIO.inputText);
                    switch(eduLevel)
                    {
                        case 1:
                            {
                                registerData.Add("certificate_score", inputFieldScore.inputText);
                                break;
                            }
                        case 2:
                            {
                                registerData.Add("ege_score", inputFieldScore.inputText);
                                break;
                            }
                        case 3:
                        case 4:
                            {
                                registerData.Add("diploma_score", inputFieldScore.inputText);
                                break;
                            }
                    }
                    registerData.Add("specialty_id", inputComboDir.GetValue());
                    inputFieldRegLogin.SetData(fontList, inpt_login, "Логин", "", isReqiered: true, fullfilledCriteria: 4);
                    inputFieldRegPassword.SetData(fontList, inpt_login, "Пароль", "", isReqiered: true, fullfilledCriteria: 8);
                    flowLayoutPanel2.Visible = false;
                    flowLayoutPanel3.Visible = true;
                    regFirstSet = true;

                    defaultButtonAcceptReg.Visible= false;
                    defaultButtonAcceptRegFinal.Visible = true;
                    defaultButtonAcceptRegFinal.SetButton(dfreg_comp);
                    defaultButtonAcceptRegFinal.AddClickHandler(TryFinalRegister);

                }
                else
                {
                    MessageBox.Show(

                  "Неверно указан формат баллов. " +
                  "\n\n Для аттестата формат баллов от 1.00 до 5.00 баллов;" +
                  "\n\n Для диплома и ЕГЭ формат баллов от 1.00 до 100.00 баллов.",
                  "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(

                   "Некорректно введены данные. " +
                   "\n\n Внимательно проверьте соответствтие введённых данных формату, " +
                   "а также проверьте, все ли поля вы заполнили.",
                   "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void TryFinalRegister()
        {
            if (inputFieldRegLogin.isFullfilled && inputFieldRegPassword.isFullfilled)
            {
                string login = inputFieldRegLogin.inputText;
                string password_hashed = Tools.Hash256(inputFieldRegPassword.inputText);
                string message;

                if (postgreSQLExecuter.RegisterUser(login, password_hashed, registerData, out message))
                    MessageBox.Show(message, "Пользователь зарегистрирован", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else 
                    MessageBox.Show(message, "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(

                    "Некорректно введены логин или пароль. " +
                    "\n\n Минимальная длина логина — 4 символа; " +
                    "\n\n Минимальная длина пароля — 8 символов;",

                    "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GetBack()
        {
            authPanel.Visible = true;
            regPanel.Visible = false;
            applPanel.Visible = false;
            pkPanel.Visible = false;
        }
    }
}
