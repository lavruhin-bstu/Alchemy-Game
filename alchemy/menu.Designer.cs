namespace alchemy
{
    partial class menu
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
            this.nameGame = new System.Windows.Forms.Label();
            this.StartB = new System.Windows.Forms.Button();
            this.aboutB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameGame
            // 
            this.nameGame.AutoSize = true;
            this.nameGame.BackColor = System.Drawing.SystemColors.Info;
            this.nameGame.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameGame.Location = new System.Drawing.Point(169, 9);
            this.nameGame.Name = "nameGame";
            this.nameGame.Size = new System.Drawing.Size(248, 47);
            this.nameGame.TabIndex = 0;
            this.nameGame.Text = "Игра \"Алхимия\"";
            this.nameGame.Click += new System.EventHandler(this.nameGame_Click);
            // 
            // StartB
            // 
            this.StartB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StartB.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartB.Image = global::alchemy.Properties.Resources.Кнопка;
            this.StartB.Location = new System.Drawing.Point(196, 456);
            this.StartB.Name = "StartB";
            this.StartB.Size = new System.Drawing.Size(166, 59);
            this.StartB.TabIndex = 1;
            this.StartB.Text = "Старт";
            this.StartB.UseVisualStyleBackColor = false;
            this.StartB.Click += new System.EventHandler(this.LoadGame);
            // 
            // aboutB
            // 
            this.aboutB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.aboutB.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutB.Image = global::alchemy.Properties.Resources.Кнопка;
            this.aboutB.Location = new System.Drawing.Point(196, 521);
            this.aboutB.Name = "aboutB";
            this.aboutB.Size = new System.Drawing.Size(166, 57);
            this.aboutB.TabIndex = 2;
            this.aboutB.Text = "Об игре";
            this.aboutB.UseVisualStyleBackColor = false;
            this.aboutB.Click += new System.EventHandler(this.LoadAbout);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::alchemy.Properties.Resources.backone;
            this.ClientSize = new System.Drawing.Size(577, 590);
            this.Controls.Add(this.aboutB);
            this.Controls.Add(this.StartB);
            this.Controls.Add(this.nameGame);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameGame;
        private System.Windows.Forms.Button StartB;
        private System.Windows.Forms.Button aboutB;
    }
}