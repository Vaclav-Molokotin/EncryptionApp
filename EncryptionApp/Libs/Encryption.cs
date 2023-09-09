using EncryptionApp.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EncryptionApp.Libs
{
    public class Encryption
    {
        public static uint CEUSAR_SHIFT = Settings.Default.CEUSAR_SHIFT;
        public static uint CURRENT_REPLACE_TABLE = Settings.Default.CURRENT_REPLACE_TABLE;
        public static uint CHAR_REPLACE_TABLES_COUNT = Settings.Default.CHAR_REPLACE_TABLES_COUNT;
        private static uint[][] charReplaceTables;
        public static EncryptionType CurrentType = 0;

        static Encryption()
        {
            charReplaceTables = new uint[1][];
            charReplaceTables[0] = new uint[256] { 216, 72, 138, 22, 219, 44, 73, 240, 114, 56, 246, 186, 228, 181, 63, 221, 194, 135, 204, 113, 149, 158, 3, 26, 102, 109, 23, 32, 224, 132, 51, 250, 27, 129, 39, 237, 126, 209, 183, 34, 152, 168, 66, 54, 5, 230, 103, 94, 251, 205, 200, 30, 217, 98, 43, 136, 9, 146, 67, 117, 148, 147, 112, 14, 227, 110, 42, 58, 121, 130, 90, 234, 1, 6, 182, 105, 92, 241, 115, 208, 140, 101, 254, 247, 88, 85, 144, 252, 84, 213, 70, 179, 76, 107, 47, 248, 201, 236, 53, 172, 244, 81, 24, 46, 131, 75, 226, 93, 143, 25, 65, 239, 62, 19, 8, 78, 218, 59, 153, 139, 232, 68, 164, 166, 156, 127, 36, 125, 207, 33, 69, 104, 29, 249, 157, 17, 55, 189, 2, 119, 80, 245, 238, 108, 86, 215, 57, 61, 60, 20, 187, 197, 40, 118, 178, 174, 124, 134, 21, 190, 233, 195, 211, 220, 122, 225, 123, 170, 41, 173, 167, 206, 99, 169, 155, 203, 242, 188, 154, 91, 235, 13, 74, 38, 196, 212, 11, 150, 177, 137, 159, 198, 193, 192, 16, 161, 184, 151, 191, 202, 50, 96, 199, 175, 18, 49, 171, 128, 79, 37, 255, 162, 185, 89, 231, 145, 0, 52, 116, 4, 163, 15, 229, 243, 28, 165, 106, 64, 12, 222, 45, 214, 120, 160, 71, 180, 97, 35, 142, 111, 7, 77, 176, 223, 100, 141, 10, 83, 95, 133, 31, 48, 87, 253, 82, 210 };
        }

        public enum EncryptionType
        {
            CharReplace,
            Cesaur
        }

        public static string EncryptText(string text, EncryptionType? type = null)
        {
            CEUSAR_SHIFT = Settings.Default.CEUSAR_SHIFT;
            if (type == null)
                type = CurrentType;

            char[] chars = text.ToCharArray();

            switch (type)
            {
                case EncryptionType.CharReplace:
                    for (int i = 0; i < chars.Length; i++)
                    {
                        chars[i] = (char)(charReplaceTables[CURRENT_REPLACE_TABLE][i]);
                    }

                    break; 
                case EncryptionType.Cesaur:
                    for(int i = 0; i < chars.Length; i++)
                    {
                        chars[i] = (char)(chars[i] + CEUSAR_SHIFT);
                    }

                    break;
            }

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(chars);
            text = stringBuilder.ToString();
            return text;
        }

        public static string DecryptText(string text, EncryptionType? type = null)
        {
            CEUSAR_SHIFT = Settings.Default.CEUSAR_SHIFT;
            if (type == null)
                type = CurrentType;

            char[] chars = text.ToCharArray();

            switch (type)
            {
                case EncryptionType.CharReplace:
                    for (int i = 0; i < chars.Length; i++)
                    {
                        try
                        {
                            chars[i] = (char)(charReplaceTables[CURRENT_REPLACE_TABLE][chars[i]]);
                        }
                        catch (Exception ex) 
                        {
                            continue;
                        }
                    }
                    break;

                case EncryptionType.Cesaur:
                    
                    for (int i = 0; i < chars.Length; i++)
                    {
                        chars[i] = (char)(chars[i] - CEUSAR_SHIFT);
                    }
                    
                    break;
            }

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(chars);
            text = stringBuilder.ToString();
            return text;
        }

        public static string EncryptTextFromFile(out string text, string filePath, EncryptionType? type = null)
        {
            StreamReader streamReader = new StreamReader(filePath);

            string encText = streamReader.ReadToEnd();
            text = encText;

            CEUSAR_SHIFT = Settings.Default.CEUSAR_SHIFT;
            encText = EncryptText(encText, type);
            streamReader.Close();

            return encText;
        }

        public static string DecryptTextFromFile(out string text, string filePath, EncryptionType? type = null)
        {
            StreamReader streamReader = new StreamReader(filePath);

            string dencText = streamReader.ReadToEnd();
            text = dencText;

            CEUSAR_SHIFT = Settings.Default.CEUSAR_SHIFT;
            dencText = DecryptText(dencText, type);
            streamReader.Close();

            return dencText;
        }

        public static bool SaveToFile(string filePath, string text)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(filePath, true, Encoding.UTF8);
                streamWriter.Write(text);
                streamWriter.Close();
                return true;
            }
            catch(Exception ex) 
            {
                return false;
            }
        }
    }
}
