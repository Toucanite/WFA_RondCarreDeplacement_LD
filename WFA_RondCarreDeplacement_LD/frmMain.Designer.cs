﻿namespace WFA_RondCarreDeplacement_LD
{
    partial class Epreuve
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
            this.components = new System.ComponentModel.Container();
            this.tmrAffiche = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrAffiche
            // 
            this.tmrAffiche.Enabled = true;
            this.tmrAffiche.Interval = 24;
            this.tmrAffiche.Tick += new System.EventHandler(this.tmrAffiche_Tick);
            // 
            // Epreuve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Name = "Epreuve";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Epreuve_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrAffiche;
    }
}

