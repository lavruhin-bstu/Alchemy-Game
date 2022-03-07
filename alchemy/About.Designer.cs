namespace alchemy
{
    partial class About
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
            this.label1 = new System.Windows.Forms.Label();
            this.backB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Правила игры";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backB
            // 
            this.backB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backB.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backB.Image = global::alchemy.Properties.Resources.Кнопка1;
            this.backB.Location = new System.Drawing.Point(12, 370);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(151, 68);
            this.backB.TabIndex = 1;
            this.backB.Text = "Назад";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(471, 78);
            this.label2.TabIndex = 2;
            this.label2.Text = "Алхимия – игра, которая позволяет почувствовать себя\r\n настоящими магами, повелит" +
    "елями стихий и природы.\r\n Цель игры собрать все 25 закрытых элементов.\r\n";
            this.label2.UseMnemonic = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.label1);
            this.Name = "About";
            this.Text = "Об игре";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.Label label2;
    }
}