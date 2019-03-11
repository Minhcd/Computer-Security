using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public string Vkey;
        public string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
        public string plainText;
        public string cipherText;
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
            VigenereEncrypt();
            txtVResult.Text = cipherText;
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
        public void VigenereEncrypt()
        {
            Vkey = txtVKey.Text.ToUpper();
            plainText = txtVInput.Text;
            plainText = plainText.ToUpper();
            int[] p = chuoi_mangchiso(plainText);
            int[] k = chuoi_mangchiso(Vkey);
            int[] kq = new int[plainText.Length];
            for (int i = 0, j = 0; i < plainText.Length; i++)
            {
                kq[i] = (p[i] + k[j]) % alphabet.Length;
                j = ++j % k.Length;
            }
            cipherText = chiso_chuoi(kq);
            int a = 0;
        }
    }
}
