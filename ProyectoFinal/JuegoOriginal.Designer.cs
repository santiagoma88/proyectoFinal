namespace ProyectoFinal
{
    partial class JuegoOriginal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuegoOriginal));
            this.juegoOri = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.juegoOri)).BeginInit();
            this.SuspendLayout();
            // 
            // juegoOri
            // 
            this.juegoOri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.juegoOri.Enabled = true;
            this.juegoOri.Location = new System.Drawing.Point(0, 0);
            this.juegoOri.Name = "juegoOri";
            this.juegoOri.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("juegoOri.OcxState")));
            this.juegoOri.Size = new System.Drawing.Size(1190, 667);
            this.juegoOri.TabIndex = 0;
            // 
            // JuegoOriginal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1190, 667);
            this.Controls.Add(this.juegoOri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JuegoOriginal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "JuegoOriginal";
            ((System.ComponentModel.ISupportInitialize)(this.juegoOri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash juegoOri;

    }
}