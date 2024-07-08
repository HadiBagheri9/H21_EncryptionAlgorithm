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
            byte[] charArrayToByteArray = CharArrayToByteArray(strToCharArray);

            charArrayToByteArray = BitwiseOperation(charArrayToByteArray);
            strToCharArray = ByteArrayToCharArray(charArrayToByteArray);

            str = new string(strToCharArray);
            //str = new string(charArrayToByteArray);

            return str;
        }
        public static string Dc(string text)
        {
            string str = text;

            char[] strToCharArray = str.ToCharArray();
            byte[] charArrayToByteArray = CharArrayToByteArray(strToCharArray);

            charArrayToByteArray = DeBitwiseOperation(charArrayToByteArray);
            strToCharArray = ByteArrayToCharArray(charArrayToByteArray);

            str = new string(strToCharArray);
            //str = new string(charArrayToByteArray);

            return str;
        }
        private static byte[] BitwiseOperation(byte[] byteArray, byte salt = 21)
        {
            int len = byteArray.Length;

            for (int i = 0; i < len; i++)
            {
                //byteArray[i] |= salt;
                //byteArray[i] &= (byte)~salt;
                byteArray[i] ^= salt;
            }

            return byteArray;
        }
        private static byte[] DeBitwiseOperation(byte[] byteArray, byte salt = 21)
        {
            int len = byteArray.Length;

            for (int i = 0; i < len; i++)
            {
                //byteArray[i] |= salt;
                //byteArray[i] &= (byte)~salt;
                byteArray[i] ^= salt;
            }

            return byteArray;
        }
        private static byte[] CharArrayToByteArray(char[] charArray)
        {
            int len = charArray.Length;
            byte[] byteArray = new byte[len];

            for (int i = 0; i < len; i++)
            {
                byteArray[i] = (byte)charArray[i];
            }

            return byteArray;
        }
        private static char[] ByteArrayToCharArray(byte[] byteArray)
        {
            int len = byteArray.Length;
            char[] charArray = new char[len];

            for (int i = 0; i < len; i++)
            {
                charArray[i] = (char)byteArray[i];
            }

            return charArray;
        }
    }
}
