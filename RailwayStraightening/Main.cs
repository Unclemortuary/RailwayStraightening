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
        bool calculated = false;
        readonly int pointsCount;

        public Main()
        {
            InitializeComponent();
            HideArrowsFromNumericUpDowns();
            pointsCount = GetPointsCount();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitData();
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

        private int GetPointsCount()
        {
            return CalculatedPanel.Controls.OfType<NumericUpDown>().Count();
        }

        private void InitData()
        {
            // stub
            var data = new Data(new[] { 23.0, 101.0, 156.0, 156.0, 156.0, 156.0, 156.0, 156.0, 156.0, 156.0, 92.0 },
                new[] { 28.0, 97.0, 137.0, 157.0, 157.0, 159.0, 167.0, 141.0, 143.0, 131.0, 87.0 },
                6);
            data.Calculate();
        }
    }
}
