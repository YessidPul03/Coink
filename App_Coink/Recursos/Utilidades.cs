﻿using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace App_DVP.Recursos
{
    public class Utilidades
    {
        public static string ClaveSegura(string pass)
        {
            StringBuilder sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create()) 
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(pass));
                
                foreach(byte b in result)
                {
                    sb.Append(b.ToString("x2"));
                }
            }

            return sb.ToString();

        }
    }
}
