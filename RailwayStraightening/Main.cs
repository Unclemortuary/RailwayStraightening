using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayStraightening
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            HideArrowsFromNumericUpDowns();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //AppState.GetState;
        }

        private void HideArrowsFromNumericUpDowns()
        {
            foreach (Control panel in Controls)
            {
                foreach (var input in panel.Controls.OfType<NumericUpDown>())
                {
                    input.Controls[0].Visible = false;
                }
            }
        }
    }
}
