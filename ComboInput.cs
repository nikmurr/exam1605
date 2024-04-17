using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdmissionCommittee
{
    public partial class ComboInput : UserControl
    {
        string labelText;
        List<Font> fontList;
        bool isRequiered;
        public int selectedIndex;
        string displayColumn;
        string valueColumn;
        int? listWidth;

        public event EventHandler ComboBoxSelectedIndexChanged;

        public ComboInput()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        public void SetData(
            DataTable data,
            List<Font> fontList,
            Image background,
            string displayColumn,
            string valueColumn,
            string labelText = "Заголовок",
            bool isReqiered = false,
            int selectedIndex = -1,
            int? listWidth = null
        ) {
            this.labelText = labelText;
            this.fontList = fontList;
            this.isRequiered = isReqiered;
            this.displayColumn = displayColumn;
            this.valueColumn = valueColumn;
            this.listWidth = listWidth;
            this.selectedIndex= selectedIndex;

            try
            {
                label.Font = fontList[0];
                labelReq.Font = fontList[0];
                comboBox1.Font = fontList[1];

                if (this.isRequiered)
                {
                    labelReq.Visible = true;
                }

                label.Text = labelText;
                pictureBox1.Image = background;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                comboBox1.DataSource = data;

                comboBox1.DisplayMember = displayColumn;
                comboBox1.ValueMember = valueColumn;

                comboBox1.SelectedIndex= selectedIndex;

                if (listWidth != null)
                {
                    comboBox1.DropDownWidth = listWidth.Value;
                }
            }
            catch (Exception ex) { }
        }

        public void SetToPosition(int index = -1)
        {
            comboBox1.SelectedIndex = index;
        }

        public string GetValue()
        {
            if (comboBox1.SelectedIndex != -1)
            {
                return comboBox1.SelectedValue.ToString();
            }
            else return null;
        }

        public string GetSelected()
        {
            if (comboBox1.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)comboBox1.SelectedItem;
                string selectedValue = selectedRow.Row.Field<string>(displayColumn);
                return selectedValue;
            }
            else return null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedIndex = comboBox1.SelectedIndex;
            ComboBoxSelectedIndexChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
