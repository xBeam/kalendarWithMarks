namespace kalendar_with_marks
{
    partial class DateObserver
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
        private void  InitializeComponent()
        {
            this.chbProg = new System.Windows.Forms.CheckBox();
            this.chbClean = new System.Windows.Forms.CheckBox();
            this.chbPhysEx = new System.Windows.Forms.CheckBox();
            this.chbGame = new System.Windows.Forms.CheckBox();
            this.chbEng = new System.Windows.Forms.CheckBox();
            this.chbMeal = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chbProg
            // 
            this.chbProg.AutoSize = true;
            this.chbProg.Location = new System.Drawing.Point(12, 45);
            this.chbProg.Name = "chbProg";
            this.chbProg.Size = new System.Drawing.Size(127, 17);
            this.chbProg.TabIndex = 0;
            this.chbProg.Text = "Программирование";
            this.chbProg.UseVisualStyleBackColor = true;
            // 
            // chbClean
            // 
            this.chbClean.AutoSize = true;
            this.chbClean.Location = new System.Drawing.Point(12, 80);
            this.chbClean.Name = "chbClean";
            this.chbClean.Size = new System.Drawing.Size(64, 17);
            this.chbClean.TabIndex = 1;
            this.chbClean.Text = "Уборка";
            this.chbClean.UseVisualStyleBackColor = true;
            // 
            // chbPhysEx
            // 
            this.chbPhysEx.AutoSize = true;
            this.chbPhysEx.Location = new System.Drawing.Point(12, 118);
            this.chbPhysEx.Name = "chbPhysEx";
            this.chbPhysEx.Size = new System.Drawing.Size(116, 17);
            this.chbPhysEx.TabIndex = 2;
            this.chbPhysEx.Text = "Физ. упражнения";
            this.chbPhysEx.UseVisualStyleBackColor = true;
            // 
            // chbGame
            // 
            this.chbGame.AutoSize = true;
            this.chbGame.Location = new System.Drawing.Point(12, 153);
            this.chbGame.Name = "chbGame";
            this.chbGame.Size = new System.Drawing.Size(53, 17);
            this.chbGame.TabIndex = 3;
            this.chbGame.Text = "Игры";
            this.chbGame.UseVisualStyleBackColor = true;
            // 
            // chbEng
            // 
            this.chbEng.AutoSize = true;
            this.chbEng.Location = new System.Drawing.Point(12, 190);
            this.chbEng.Name = "chbEng";
            this.chbEng.Size = new System.Drawing.Size(86, 17);
            this.chbEng.TabIndex = 4;
            this.chbEng.Text = "Английский";
            this.chbEng.UseVisualStyleBackColor = true;
            // 
            // chbMeal
            // 
            this.chbMeal.AutoSize = true;
            this.chbMeal.Location = new System.Drawing.Point(12, 231);
            this.chbMeal.Name = "chbMeal";
            this.chbMeal.Size = new System.Drawing.Size(90, 17);
            this.chbMeal.TabIndex = 5;
            this.chbMeal.Text = "Готовка еды";
            this.chbMeal.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(325, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 22);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(325, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 22);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(197, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Дата";
            // 
            // DateObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 330);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chbMeal);
            this.Controls.Add(this.chbEng);
            this.Controls.Add(this.chbGame);
            this.Controls.Add(this.chbPhysEx);
            this.Controls.Add(this.chbClean);
            this.Controls.Add(this.chbProg);
            this.Name = "DateObserver";
            this.Text = "Категории";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbProg;
        private System.Windows.Forms.CheckBox chbClean;
        private System.Windows.Forms.CheckBox chbPhysEx;
        private System.Windows.Forms.CheckBox chbGame;
        private System.Windows.Forms.CheckBox chbEng;
        private System.Windows.Forms.CheckBox chbMeal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDate;
    }
}