using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionCommittee
{
    static class Tools
    {
        public static string Hash256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Преобразуем строку в байтовый массив
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);

                // Вычисляем хэш
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                // Преобразуем байтовый массив в строку шестнадцатеричного представления
                string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                return hashString;
            }
        }

        public static bool CheckScore(int eduType, float? score)
        {
            if (score != null)
            {
                int botBord = 1;
                int topBord = 100;
                if (eduType == 1)
                {
                    topBord = 5;
                }

                if (score >= botBord && score <= topBord) return true;
                else return false;
            }
            else return false;
        }

        public static float? StringToFloat(string value)
        {
            float.TryParse(value, out float result);
            return result;
        }
    }
}
