using System;
using System.Drawing;
using System.Windows.Forms;
using Cellule_Mutante_.Controls;
namespace Cellule_Mutante_
{
    public partial class Form1 : Form
    {
        // Déclaration des attributs Panel et Button que l’on va
        // afficher dans notre fenêtre
        Panel pnl_main;
        Button btn_simulation;
        public Form1()
        {
            InitializeComponent();
            // Initialisation d’un Panel en utilisant notre classe
            pnl_main = new MainPanel();
            pnl_main.Location = new Point((Size.Width - pnl_main.Width) / 2 - 10,
            (Size.Height - pnl_main.Height) / 2 - 40);
            pnl_main.Anchor = AnchorStyles.None;
            // Initialisation d’un Button en utilisant notre classe
            btn_simulation = new SimulationButton();
            btn_simulation.Location = new Point(90, 390);
            btn_simulation.Anchor = AnchorStyles.None;
            // Ajout des éléments à notre fenêtre
            Controls.Add(pnl_main);
            Controls.Add(btn_simulation);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Définir la taille et le titre de la fenêtre
            Size = new Size(500, 500);
            Text = "Cellule Mutante";
        }
    }
}
