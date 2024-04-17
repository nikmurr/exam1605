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
    public partial class StateButton : UserControl
    {
        Image on;
        Image off;
        public bool isSet { get; set; } = false;

        public StateButton()
        {
            InitializeComponent();
        }

        public void SetButton(Image on, Image off, bool defaultState = false)
        {
            isSet = defaultState;
            this.on = on;
            this.off = off;
            button1.Width = on.Width;
            button1.BackgroundImageLayout = ImageLayout.Center;

            if (defaultState)
            {
                button1.BackgroundImage = on;
            }
            else
            {
                button1.BackgroundImage = off;
            }
        }

        public void SetClick()
        {
            if (isSet == false)
            {
                isSet = true;
                button1.BackgroundImage = on; 
            }
            else
            {
                isSet = false;
                button1.BackgroundImage = off;
            }
        }

        public void AddClickHandler(Action clickAction)
        {
            button1.Click += (sender, e) => clickAction();
        }
    }
}
