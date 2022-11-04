using fejleszteszi_mintak_06.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fejleszteszi_mintak_06.Entities
{
    public class Ball : Toy
    {
        //kitorolnem az osztaly tartalmat, de ha csak a drawImage hagyom bent
        //szamomra ertelmezhetetlen hibauzenet jon 
        public SolidBrush BallColor { get; private set; }
        public Ball(Color color)
        {
            BallColor = new SolidBrush(color);
        }

        public Ball()
        {
        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
        }
       public void MoveBall()
       {
           Left += 1;
       }

      
    }

}
