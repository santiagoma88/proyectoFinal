using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class JuegoOriginal : Form
    {
        public JuegoOriginal()
        {
            InitializeComponent();
            juegoOri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
            juegoOri.LoadMovie(0, "http://flash.7k7k.com/cms/cms10/20150809/1428084107/222.swf");
            
        }
    }
}
