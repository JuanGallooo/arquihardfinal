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
            this.pictureOriginal = new System.Windows.Forms.PictureBox();
            this.pictureGrises = new System.Windows.Forms.PictureBox();
            this.pictureLocal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGrises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOriginal
            // 
            this.pictureOriginal.Location = new System.Drawing.Point(0, 2);
            this.pictureOriginal.Name = "pictureOriginal";
            this.pictureOriginal.Size = new System.Drawing.Size(333, 487);
            this.pictureOriginal.TabIndex = 0;
            this.pictureOriginal.TabStop = false;
            // 
            // pictureGrises
            // 
            this.pictureGrises.Location = new System.Drawing.Point(452, 2);
            this.pictureGrises.Name = "pictureGrises";
            this.pictureGrises.Size = new System.Drawing.Size(358, 487);
            this.pictureGrises.TabIndex = 1;
            this.pictureGrises.TabStop = false;
            // 
            // pictureLocal
            // 
            this.pictureLocal.Location = new System.Drawing.Point(946, 2);
            this.pictureLocal.Name = "pictureLocal";
            this.pictureLocal.Size = new System.Drawing.Size(327, 493);
            this.pictureLocal.TabIndex = 2;
            this.pictureLocal.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 514);
            this.Controls.Add(this.pictureLocal);
            this.Controls.Add(this.pictureGrises);
            this.Controls.Add(this.pictureOriginal);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGrises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLocal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureOriginal;
        private System.Windows.Forms.PictureBox pictureGrises;
        private System.Windows.Forms.PictureBox pictureLocal;
    }
}