using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev15_1504
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkontor_Click(object sender, EventArgs e)
        {
            string secim;
            secim=listBox1.SelectedItem.ToString();
            if (secim=="mouse"||secim=="klavye"||secim=="kamera"||secim=="tarayıcı")
            {
                MessageBox.Show("bu parça ,giriş birimdir");

            }
            if (secim == "yazıcı" || secim == "haparlör" || secim == "projeksiyon")
            {
                MessageBox.Show("bu parça,çıkış birimidir");
            }
    }
}
