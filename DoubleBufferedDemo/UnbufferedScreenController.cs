using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleBufferedDemo
{
    class UnbufferedScreenController
    {
        private readonly Panel _panel;
        private readonly Graphics _panelGraphics;
        private readonly Color _color;

        public readonly List<IScreenObject> _panelObjects = new List<IScreenObject>();

        private readonly Timer _timer;
        public UnbufferedScreenController(Panel panel, Color color)
        {
            _panel = panel;
            _panelGraphics = panel.CreateGraphics();
            _color = color;

            // Setup Timer
            _timer = new Timer();
            _timer.Interval = 1000 / 60;
            _timer.Tick += Redraw;
            _timer.Start();
        }

        public void Redraw(object sender, EventArgs e)
        {
            _panelGraphics.Clear(_color);
            _panelObjects.ForEach(x => DrawObject(x, _panel.Bounds));
        }

        private void DrawObject(IScreenObject o, Rectangle panelBounds)
        {
            if (!panelBounds.IntersectsWith(o.GetBounds()))
                return;

            o.Draw(_panelGraphics);
        }
    }
}
