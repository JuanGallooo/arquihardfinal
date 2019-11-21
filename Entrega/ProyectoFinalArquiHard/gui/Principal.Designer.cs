namespace ProyectoFinalArquiHard
{
    partial class Principal
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
            this.pictureGrises = new System.Windows.Forms.PictureBox();
            this.pictureLocal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGrises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureGrises
            // 
            this.pictureGrises.Location = new System.Drawing.Point(12, 2);
            this.pictureGrises.Name = "pictureGrises";
            this.pictureGrises.Size = new System.Drawing.Size(942, 1263);
            this.pictureGrises.TabIndex = 1;
            this.pictureGrises.TabStop = false;
            // 
            // pictureLocal
            // 
            this.pictureLocal.Location = new System.Drawing.Point(972, 2);
            this.pictureLocal.Name = "pictureLocal";
            this.pictureLocal.Size = new System.Drawing.Size(801, 1263);
            this.pictureLocal.TabIndex = 2;
            this.pictureLocal.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2380, 1382);
            this.Controls.Add(this.pictureLocal);
            this.Controls.Add(this.pictureGrises);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureGrises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLocal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureGrises;
        private System.Windows.Forms.PictureBox pictureLocal;
    }
}