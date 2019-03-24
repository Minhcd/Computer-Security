using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Encrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string chuoi;
        public string ketqua;
        public int k;
        public string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string plainText;
        public string cipherText;
        public string Vkey;
        
        private void btnCeasar_Click(object sender, EventArgs e)
        {
            EncryptCeasar();
            txtResult.Text = ketqua;
            ketqua = "";
        }
        public void EncryptCeasar()
        {
            k = Int32.Parse(txtDoDoi.Text);
            chuoi = txtInput.Text;
            chuoi = chuoi.ToUpper();
            for (int i = 0; i < chuoi.Length; i++)
                ketqua += (char)('A' +
                ((chuoi[i] - 'A' + k) % 26));
        }

        private void btnDeCeasar_Click(object sender, EventArgs e)
        {
            DecryptCeasar();
            txtResult.Text = ketqua;
            ketqua = "";
            chuoi = "";
        }

        private void DecryptCeasar()
        {
            chuoi = txtInput.Text;
            for (int i = 0; i < chuoi.Length; i++)
                ketqua += (char)('A' + (chuoi[i] - 'A' +
                (26 - k)) % 26);
        }

        private void btnVigenereEncrypt_Click(object sender, EventArgs e)
        {
            string res = VigenereEncrypt();
            txtVResult.Text = res;
            cipherText = "";
            plainText = "";
            Vkey = "";
        }
        public int[] chuoi_mangchiso(string s)
        {
            int[] mang = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
                mang[i] = alphabet.IndexOf(s[i]);
            return mang;
        }
        public string chiso_chuoi(int[] a)
        {
            string s = "";
            for (int i = 0; i < a.Length; i++)
                s += alphabet[a[i]];
            return s;
        }
        public string VigenereEncrypt()
        {
            plainText = txtVInput.Text;
            plainText = plainText.ToUpper();
            Vkey = txtVKey.Text;
            Vkey = Vkey.ToUpper();
            int[] p = chuoi_mangchiso(plainText);
            int[] k = chuoi_mangchiso(Vkey);
            int[] kq = new int[plainText.Length];
            for (int i = 0, j = 0; i < plainText.Length; i++)
            {
                kq[i] = (p[i] + k[j]) % alphabet.Length;
                j = ++j % k.Length;
            }
            cipherText = chiso_chuoi(kq);
            return cipherText;
        }

        public string VigenereDecrypt()
        {
            cipherText = txtVInput.Text;
            cipherText = cipherText.ToUpper();
            Vkey = txtVKey.Text;
            Vkey = Vkey.ToUpper();
            int[] c = chuoi_mangchiso(cipherText);
            int[] k = chuoi_mangchiso(Vkey);
            int[] kq = new int[cipherText.Length];
            for (int i = 0, j = 0; i < cipherText.Length; i++)
            {
                kq[i] = (c[i] - k[j]) % alphabet.Length;
                if (kq[i] < 0)
                    kq[i] = (c[i] + (chuoi.Length - k[j])) % chuoi.Length;
                j = ++j % k.Length;
            }
            plainText = chiso_chuoi(kq);
            return plainText;
        }

        private void btnVigenereDecrypt_Click(object sender, EventArgs e)
        {
            string res = VigenereDecrypt();
            txtVResult.Text = res;
            txtVResult.Text = res;
            cipherText = "";
            plainText = "";
            Vkey = "";
        }

        private void btnEncrypt3DS_Click(object sender, EventArgs e)
        {
            txt3DSResult.Text = ThreeDSEncrypt(txt3DSInput.Text, txt3DSKey.Text, true);
        }
        public static string ThreeDSEncrypt(string toEncrypt, string key, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray =
            UTF8Encoding.UTF8.GetBytes(toEncrypt);
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new
                MD5CryptoServiceProvider();
                keyArray =
                hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);
            TripleDESCryptoServiceProvider tdes = new
            TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray =
            cTransform.TransformFinalBlock(toEncryptArray, 0,
            toEncryptArray.Length);
            tdes.Clear();
            return Convert.ToBase64String(resultArray, 0,
            resultArray.Length);
        }
        public static string ThreeDSDecrypt(string cipherString, string key, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray =
            Convert.FromBase64String(cipherString);
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new
                MD5CryptoServiceProvider();
                keyArray =
                hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);
            TripleDESCryptoServiceProvider tdes = new
            TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray =
            cTransform.TransformFinalBlock(toEncryptArray, 0,
            toEncryptArray.Length);
            tdes.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        private void btnDecrypt3DS_Click(object sender, EventArgs e)
        {
            txt3DSResult.Text = ThreeDSDecrypt(txt3DSInput.Text, txt3DSKey.Text, true); 
        }
    }
}
