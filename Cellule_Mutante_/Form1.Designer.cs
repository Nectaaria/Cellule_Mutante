namespace Cellule_Mutante_
{
    partial class Cellule_Mutante
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_cell = new System.Windows.Forms.Panel();
            this.btn_simulation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnl_cell
            // 
            this.pnl_cell.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_cell.Location = new System.Drawing.Point(214, 22);
            this.pnl_cell.Name = "pnl_cell";
            this.pnl_cell.Size = new System.Drawing.Size(372, 372);
            this.pnl_cell.TabIndex = 0;
            this.pnl_cell.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_cell_Paint);
            // 
            // btn_simulation
            // 
            this.btn_simulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_simulation.Location = new System.Drawing.Point(214, 400);
            this.btn_simulation.Name = "btn_simulation";
            this.btn_simulation.Size = new System.Drawing.Size(372, 38);
            this.btn_simulation.TabIndex = 1;
            this.btn_simulation.Text = "Simulation";
            this.btn_simulation.UseVisualStyleBackColor = false;
            this.btn_simulation.Click += new System.EventHandler(this.btn_simulation_Click);
            // 
            // Cellule_Mutante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_simulation);
            this.Controls.Add(this.pnl_cell);
            this.Name = "Cellule_Mutante";
            this.Text = "Cellule Mutante";
            this.Load += new System.EventHandler(this.Cellule_Mutante_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_cell;
        private System.Windows.Forms.Button btn_simulation;
    }
}

