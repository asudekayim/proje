using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private DurusmaGunleri gunler = new DurusmaGunleri();

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            string secilenGun = cmbGunler.SelectedIndex.ToString();

            if(!string.IsNullOrEmpty(secilenGun))
            {
                //secilen gunu listbox a yazdırma kodları
            }
            else
            {
                MessageBox.Show("Lütfen bir gün seçin.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
