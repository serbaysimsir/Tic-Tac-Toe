namespace XOX_Oyunu
{
    partial class AnaMenu
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
            this.rdo1Player = new System.Windows.Forms.RadioButton();
            this.rdo2Players = new System.Windows.Forms.RadioButton();
            this.btnOyna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdo1Player
            // 
            this.rdo1Player.AutoSize = true;
            this.rdo1Player.Location = new System.Drawing.Point(39, 58);
            this.rdo1Player.Name = "rdo1Player";
            this.rdo1Player.Size = new System.Drawing.Size(63, 17);
            this.rdo1Player.TabIndex = 0;
            this.rdo1Player.TabStop = true;
            this.rdo1Player.Text = "1 Player";
            this.rdo1Player.UseVisualStyleBackColor = true;
            // 
            // rdo2Players
            // 
            this.rdo2Players.AutoSize = true;
            this.rdo2Players.Location = new System.Drawing.Point(149, 58);
            this.rdo2Players.Name = "rdo2Players";
            this.rdo2Players.Size = new System.Drawing.Size(68, 17);
            this.rdo2Players.TabIndex = 1;
            this.rdo2Players.TabStop = true;
            this.rdo2Players.Text = "2 Players";
            this.rdo2Players.UseVisualStyleBackColor = true;
            // 
            // btnOyna
            // 
            this.btnOyna.Location = new System.Drawing.Point(103, 127);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(75, 23);
            this.btnOyna.TabIndex = 2;
            this.btnOyna.Text = "Oyna";
            this.btnOyna.UseVisualStyleBackColor = true;
            this.btnOyna.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnOyna);
            this.Controls.Add(this.rdo2Players);
            this.Controls.Add(this.rdo1Player);
            this.Name = "AnaMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo1Player;
        private System.Windows.Forms.RadioButton rdo2Players;
        private System.Windows.Forms.Button btnOyna;
    }
}