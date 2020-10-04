using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleBufferedDemo
{
    interface IScreenObject
    {
        Rectangle GetBounds();
        void Draw(Graphics g);
    }
}
