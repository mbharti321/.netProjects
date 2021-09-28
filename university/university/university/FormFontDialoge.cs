using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace university
{
    public partial class formFontDialogeBox : Form
    {
        public formFontDialogeBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = richTextDescription.Font;
            fontDialog1.Color = richTextDescription.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextDescription.Font = fontDialog1.Font;
                richTextDescription.ForeColor = fontDialog1.Color;
            }
        }

        private void fontDialog2_Apply(object sender, EventArgs e)
        {

        }

        private void formFontDialogeBox_Load(object sender, EventArgs e)
        {

        }
    }
}
