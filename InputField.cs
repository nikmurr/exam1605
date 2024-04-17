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
    public partial class InputField : UserControl
    {
        string labelText;
        string hintText;
        List<Font> fontList;
        bool isPassword;
        bool isRequiered;
        public bool isFullfilled;
        int fullfilledCriteria;
        bool isStrictCriteria;

        public string inputText = "";

        public InputField()
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
            string labelText = "Заголовок", 
            string hintText = "Введите что-нибудь", 
            bool isPassword = false, 
            bool isReqiered = false, 
            int fullfilledCriteria = 0,
            bool isStrictCriteria = false
        ) {
            this.labelText = labelText;
            this.hintText = hintText;
            this.fontList = fontList;
            this.isPassword = isPassword;
            this.isRequiered = isReqiered;
            this.fullfilledCriteria = fullfilledCriteria;
            this.isStrictCriteria = isStrictCriteria;

            try
            {
                label.Font = fontList[0];
                labelReq.Font = fontList[0];
                textBox1.Font = fontList[1];

                if (this.isPassword)
                {
                    textBox1.PasswordChar = '•'; 
                }

                if (this.isRequiered)
                {
                    labelReq.Visible = true;
                }

                label.Text = labelText;
                textBox1.Text = hintText;
                pictureBox1.Image = background;
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

                inputText = textBox1.Text;
            }
            catch (Exception ex) { }
        }

        public void ClearText()
        {
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            inputText = textBox1.Text;
            if (!String.IsNullOrEmpty(inputText) && (isStrictCriteria ? inputText.Length == fullfilledCriteria : inputText.Length >= fullfilledCriteria))
            {
                isFullfilled= true;
            }
            else
            {
                isFullfilled = false;
            }
        }
    }
}
