using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooooop5
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            List<MyImage> Img = new List<MyImage>();
            Img.Add(new MyImage(new Bitmap(Properties.Resources.kust), "Не нажимай"));
            Img.Add(new MyImage(new Bitmap(Properties.Resources.kot), "Ну просил же"));

            gal1.Im = Img;
            gal2.Im = Img;
        }
    }
}
