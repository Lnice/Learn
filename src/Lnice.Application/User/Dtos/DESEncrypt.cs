using System;
using System.Security.Cryptography;
using System.Text;

namespace Lnice.User
{
    public class DESEncrypt
    {
        private static readonly string sKey;
        static DESEncrypt()
        {
            byte[] pwArray = Encoding.UTF8.GetBytes(LniceConsts.LocalizationSourceName);
            SHA256Managed sha = new SHA256Managed();
            byte[] pwHash = sha.ComputeHash(pwArray);
            byte[] guardKey = { 0xC7, 0xF5, 0xE1, 0xF2, 0xE4, 0xCB, 0xE5, 0xF9 };
            int len = guardKey.Length;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < pwHash.Length; i++)
            {
                pwHash[i] ^= guardKey[i % len];
                sb.Append(pwHash[i].ToString("X2"));
            }
            sKey = sb.ToString().Substring(0, 8);
        }

        #region ========加密========

        /// <summary> 
        /// 加密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <returns></returns> 
        public string Encrypt(string Text)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.Default.GetBytes(Text);
            des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            return ret.ToString();
        }

        #endregion

        #region ========解密========
        
        /// <summary> 
        /// 解密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <returns></returns> 
        public string Decrypt(string Text)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            int len = Text.Length / 2;
            byte[] inputByteArray = new byte[len];
            int x, i;
            for (x = 0; x < len; x++)
            {
                i = Convert.ToInt32(Text.Substring(x * 2, 2), 16);
                inputByteArray[x] = (byte)i;
            }
            des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Encoding.Default.GetString(ms.ToArray());
        }

        #endregion
    }
}
