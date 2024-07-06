using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H21_EncryptionAlgorithm
{
    class H21
    {
        public static string Enc(string text)
        {
            string str = text;
            char[] strToCharArray = str.ToCharArray();

            return str;
        }

        private byte[] CharArrayToByteArray(char[] charArray)
        {
            int len = charArray.Length;
            byte[] byteArray = new byte[len];

            for (int i = 0; i < len; i++)
            {
                byteArray[i] = (byte)charArray[i];
            }


            return byteArray;
        }
    }
}
