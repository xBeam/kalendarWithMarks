namespace kalendar_with_marks
{
    partial class DeleteCat
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
            this.btnDelCat = new System.Windows.Forms.Button();
            this.pnDelCat = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDelCat
            // 
            this.btnDelCat.Location = new System.Drawing.Point(359, 296);
            this.btnDelCat.Name = "btnDelCat";
            this.btnDelCat.Size = new System.Drawing.Size(122, 35);
            this.btnDelCat.TabIndex = 1;
            this.btnDelCat.Text = "Удалить выбранные категории";
            this.btnDelCat.UseVisualStyleBackColor = true;
            this.btnDelCat.Click += new System.EventHandler(this.btnDelCat_Click);
            // 
            // pnDelCat
            // 
            this.pnDelCat.Location = new System.Drawing.Point(12, 12);
            this.pnDelCat.Name = "pnDelCat";
            this.pnDelCat.Size = new System.Drawing.Size(263, 319);
            this.pnDelCat.TabIndex = 13;
            // 
            // DeleteCat
            // 
            this.AcceptButton = this.btnDelCat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 360);
            this.Controls.Add(this.pnDelCat);
            this.Controls.Add(this.btnDelCat);
            this.Location = new System.Drawing.Point(500, 500);
            this.Name = "DeleteCat";
            this.Text = "Удалить категорию";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelCat;
        private System.Windows.Forms.Panel pnDelCat;
    }
}