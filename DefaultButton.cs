using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionCommittee
{
    public partial class DefaultButton : UserControl
    {
        Image on;
        Bitmap off;
        public bool state { get; set; } = false;

        public DefaultButton()
        {
            InitializeComponent();
        }

        public void SetButton(Image on)
        {
            this.on = on;

            Bitmap off = new Bitmap(on.Width, on.Height);

            using (Graphics g = Graphics.FromImage(off))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = 0.4f;

                using (ImageAttributes attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(matrix);

                    g.DrawImage(on, new Rectangle(0, 0, on.Width, on.Height),
                                0, 0, on.Width, on.Height, GraphicsUnit.Pixel, attributes);
                }
            }

            this.off = off;

            button1.Width = on.Width;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.BackgroundImage = on;
        }

        public void SetState(bool state)
        {
            if (state)
            {
                button1.BackgroundImage = on;
                button1.Enabled= true;
                this.state = true;
            }
            else
            {
                button1.BackgroundImage = off;
                button1.Enabled= false;
                this.state = false;
            }
        }

        public void AddClickHandler(Action clickAction)
        {
            button1.Click += (sender, e) => clickAction();
        }
    }
}
