using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encritación_MD5
{
    internal class Encriptacion_Md5
    {
        public string Encriptar(string valor)
        {
            string Hash = "2k23";
            byte[] data=UTF32Encoding.UTF8.GetBytes(valor);

            MD5 md5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();

            tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Hash));
            tripleDES.Mode= CipherMode.ECB;

            ICryptoTransform cryptoTransform = tripleDES.CreateEncryptor();
            byte[] resultado= cryptoTransform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(resultado) ;
        }

        public string Desencriptar(string valor)
        {
            string Hash = "2k23";
            byte[] data = Convert.FromBase64String(valor);

            MD5 md5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();

            tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Hash));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform cryptoTransform = tripleDES.CreateDecryptor();
            byte[] resultado = cryptoTransform.TransformFinalBlock(data, 0, data.Length);

            return UTF8Encoding.UTF8.GetString(resultado);
        }
    }
}
