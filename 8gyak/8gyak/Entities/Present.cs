using _8gyak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8gyak.Entities
{
    public class Present : Toy
    {
        public SolidBrush prescol1 { get; private set; }
        public SolidBrush prescol2 { get; private set; }
        public Present(Color color1, Color color2)
        {
            prescol1 = new SolidBrush(color1);
            prescol2 = new SolidBrush(color2);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(prescol1, 0, 0, Width, Height);
            g.FillRectangle(prescol2,0,(Height/5)*2,Width,Height/5);
            g.FillRectangle(prescol2,(Width/5)*2,0,Width/5,Height);

        }
    }
}
