using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ryNotDefteri
{
    public partial class defterForm : Form
    {
        public defterForm()
        {
            InitializeComponent();
        }

        private void geriAlMenuItem_Click(object sender, EventArgs e)
        {
            yaziAlani.Undo();
        }

        private void yineleMenuItem_Click(object sender, EventArgs e)
        {
            yaziAlani.Redo();
        }

        private void kesMenuItem_Click(object sender, EventArgs e)
        {
            yaziAlani.Cut();
        }

        private void kopyalaMenuItem_Click(object sender, EventArgs e)
        {
            yaziAlani.Copy();
        }

        private void yapistirMenuItem_Click(object sender, EventArgs e)
        {
            yaziAlani.Paste();
        }

        private void tmnSecMenuItem_Click(object sender, EventArgs e)
        {
            yaziAlani.SelectAll();
        }

        private void zeminRengiMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yaziTipiMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yaziRengiMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acMenuItem_Click(object sender, EventArgs e)
        {
            //dosyaAc.Filter = "Metin|*.txt|Zengin Metin|*.rtf|Word|*.docx";
            dosyaAc.Filter = "Metin|*.txt";
            if (dosyaAc.ShowDialog() == DialogResult.OK)
                yaziAlani.LoadFile(dosyaAc.FileName, RichTextBoxStreamType.PlainText);
        }

        private void kaydetMenuItem_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Filter = "Metin Dosyası | *.txt";
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
                yaziAlani.SaveFile(dosyaKaydet.FileName, RichTextBoxStreamType.PlainText);
        }

        private void kapatMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulama \n Sonlandırılsın mı?", "Çıkış Onayı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
