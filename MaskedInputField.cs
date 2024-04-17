using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionCommittee
{
    public partial class MaskedInputField : UserControl
    {
        string labelText;
        List<Font> fontList;
        bool isRequiered;
        public bool isFullfilled;
        string maskType;
        char maskChar;

        public string inputText = "";

        public MaskedInputField()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inputText = textBox1.Text;
            }
        }

        public void SetData(
            List<Font> fontList,
            Image background,
            string maskType,
            char maskChar,
            string labelText = "Заголовок",
            bool isReqiered = false
        )
        {
            this.labelText = labelText;
            this.fontList = fontList;
            this.isRequiered = isReqiered;
            this.maskType = maskType;
            this.maskChar = maskChar;

            try
            {
                label.Font = fontList[0];
                labelReq.Font = fontList[0];
                textBox1.Font = fontList[1];

                if (this.isRequiered)
                {
                    labelReq.Visible = true;
                }

                label.Text = labelText;
                pictureBox1.Image = background;
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                textBox1.Mask = maskType;
                textBox1.PromptChar = maskChar;
                textBox1.ForeColor = Color.Silver;

                inputText = textBox1.Text;
            }
            catch (Exception ex) { }
        }

        public void ClearText()
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.Silver;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            inputText = textBox1.Text;
            if (!String.IsNullOrEmpty(inputText) && textBox1.MaskCompleted)
            {
                isFullfilled = true;
            }
            else
            {
                isFullfilled = false;
            }
        }
    }
}
