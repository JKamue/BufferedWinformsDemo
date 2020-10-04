using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleBufferedDemo
{
    public partial class Form1 : Form
    {
        private BufferedScreenController BufferedController;
        private UnbufferedScreenController UnbufferedController;
        private Random Rand = new Random();
        private Timer Timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            BufferedController = new BufferedScreenController(pnlBuffered, Color.White);
            UnbufferedController = new UnbufferedScreenController(pnlUnbuffered, Color.White);

            Timer.Interval = 200;
            Timer.Tick += panel_Click;
            Timer.Start();
        }

        private void panel_Click(object sender, EventArgs e)
        {
            var x = Rand.Next(0, pnlBuffered.Width / 2);
            var y = Rand.Next(0, pnlBuffered.Height / 2);
            var width = Rand.Next(0, pnlBuffered.Width / 2);
            var height = Rand.Next(0, pnlBuffered.Height / 2);

            var square = new Square(new Point(x,y), new Size(width, height));
            BufferedController._panelObjects.Add(square);
            UnbufferedController._panelObjects.Add(square);
        }
    }
}
