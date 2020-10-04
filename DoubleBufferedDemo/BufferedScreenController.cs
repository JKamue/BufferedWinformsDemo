using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleBufferedDemo
{
    class BufferedScreenController
    {
        private readonly Panel _panel;
        private readonly Timer _timer;
        private readonly Color _color;

        private readonly BufferedGraphicsContext _context;
        private readonly BufferedGraphics _graphicsBuffer;
        private readonly Graphics _panelGraphics;

        public readonly List<IScreenObject> _panelObjects = new List<IScreenObject>();

        public BufferedScreenController(Panel panel, Color color)
        {
            _panel = panel;
            _color = color;

            // Setup Graphics
            _context = BufferedGraphicsManager.Current;
            _panelGraphics = _panel.CreateGraphics();
            _graphicsBuffer = _context.Allocate(_panelGraphics, panel.DisplayRectangle);

            // Setup Timer
            _timer = new Timer();
            _timer.Interval = 1000 / 60;
            _timer.Tick += Redraw;
            _timer.Start();
        }

        public void Redraw(object sender, EventArgs e)
        {
            _graphicsBuffer.Graphics.Clear(_color);
            _panelObjects.ForEach(x => DrawObject(x, _panel.Bounds));
            _graphicsBuffer.Render(_panelGraphics);
        }

        private void DrawObject(IScreenObject o, Rectangle panelBounds)
        {
            if (!panelBounds.IntersectsWith(o.GetBounds()))
                return;

            o.Draw(_graphicsBuffer.Graphics);
        }
    }
}
