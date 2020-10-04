using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleBufferedDemo
{
    class Square : IScreenObject
    {
        private Point Location;
        private Size Size;
        private Rectangle Rect => new Rectangle(Location, Size);

        public Square(Point location, Size size)
        {
            Location = location;
            Size = size;
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Red), Rect);
            Location.X -= 1;
        } 

        public Rectangle GetBounds() => Rect;
    }
}
