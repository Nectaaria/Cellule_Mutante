using System;
using System.Windows.Forms;
using System.Drawing;
namespace Cellule_Mutante_.Controls
{
    class SimulationButton : Button
    {
        public SimulationButton()
        {
            Name = "btn_simulation";
            Text = "Simulation";
            BackColor = Color.LightGray;
            ForeColor = Color.Black;
            Size = new Size(300, 40);
            Dock = DockStyle.None;
            Font = new Font("Arial", 14);
            Cursor = Cursors.Hand;
            SetStyle(ControlStyles.Selectable, false);
        }
    }
}
