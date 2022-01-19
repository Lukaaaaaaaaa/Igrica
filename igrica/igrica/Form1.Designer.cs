namespace igrica
{
    partial class Form1
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
            this.gold = new System.Windows.Forms.Label();
            this.Exp = new System.Windows.Forms.Label();
            this.Lvl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Coin = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelCoin = new System.Windows.Forms.Label();
            this.labelExp = new System.Windows.Forms.Label();
            this.labelLvl = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gold
            // 
            this.gold.Location = new System.Drawing.Point(0, 0);
            this.gold.Name = "gold";
            this.gold.Size = new System.Drawing.Size(100, 23);
            this.gold.TabIndex = 0;
            this.gold.Text = "Gold:";
            // 
            // Exp
            // 
            this.Exp.AutoSize = true;
            this.Exp.Location = new System.Drawing.Point(12, 54);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(28, 13);
            this.Exp.TabIndex = 2;
            this.Exp.Text = "Exp:";
            // 
            // Lvl
            // 
            this.Lvl.AutoSize = true;
            this.Lvl.Location = new System.Drawing.Point(12, 77);
            this.Lvl.Name = "Lvl";
            this.Lvl.Size = new System.Drawing.Size(24, 13);
            this.Lvl.TabIndex = 3;
            this.Lvl.Text = "Lvl:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "HP:";
            // 
            // Coin
            // 
            this.Coin.AutoSize = true;
            this.Coin.Location = new System.Drawing.Point(12, 32);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(31, 13);
            this.Coin.TabIndex = 7;
            this.Coin.Text = "Coin:";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(65, 10);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(9, 13);
            this.labelHP.TabIndex = 8;
            this.labelHP.Text = "l";
            // 
            // labelCoin
            // 
            this.labelCoin.AutoSize = true;
            this.labelCoin.Location = new System.Drawing.Point(65, 32);
            this.labelCoin.Name = "labelCoin";
            this.labelCoin.Size = new System.Drawing.Size(9, 13);
            this.labelCoin.TabIndex = 9;
            this.labelCoin.Text = "l";
            // 
            // labelExp
            // 
            this.labelExp.AutoSize = true;
            this.labelExp.Location = new System.Drawing.Point(65, 54);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(9, 13);
            this.labelExp.TabIndex = 10;
            this.labelExp.Text = "l";
            // 
            // labelLvl
            // 
            this.labelLvl.AutoSize = true;
            this.labelLvl.Location = new System.Drawing.Point(65, 77);
            this.labelLvl.Name = "labelLvl";
            this.labelLvl.Size = new System.Drawing.Size(9, 13);
            this.labelLvl.TabIndex = 11;
            this.labelLvl.Text = "l";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(293, 10);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(0, 13);
            this.labelLocation.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelLvl);
            this.Controls.Add(this.labelExp);
            this.Controls.Add(this.labelCoin);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.Coin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lvl);
            this.Controls.Add(this.Exp);
            this.Name = "Form1";
            this.Text = "Quest Adventure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label gold;
        private System.Windows.Forms.Label Exp;
        private System.Windows.Forms.Label Lvl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Coin;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelCoin;
        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.Label labelLvl;
        private System.Windows.Forms.Label labelLocation;
    }
}

