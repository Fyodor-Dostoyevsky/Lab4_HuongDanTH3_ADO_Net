using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradientPanel
{
    public class GradientPanel : Panel
    {
        public Color Topcolor { get; set; }
        public Color Bottomcolor { get; set; }

        public float Angel { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.Topcolor, this.Bottomcolor, this.Angel);
            Graphics g = e.Graphics;
            g.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);

        }
    }
}
