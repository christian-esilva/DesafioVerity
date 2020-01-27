using System;
using System.Security.Cryptography;
using System.Text;

namespace DesafioVerity.Dominio.Utils
{
    public static class EncriptarSenha
    {
        public static string Encriptar(string senha)
        {
            using MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            byte[] dados = md5.ComputeHash(utf8.GetBytes(senha));
            return Convert.ToBase64String(dados);
        }
    }
}
