namespace PouBDSMultiplayer
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnScoreboard = new System.Windows.Forms.Button();
            this.btnInformations = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.eastereggclickPou = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPlayerNickname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eastereggclickPou)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Pou", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(92, 34);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(468, 58);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Pou o Comilão";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Pou", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(105, 230);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(268, 91);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Começar Jogo";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnScoreboard
            // 
            this.btnScoreboard.Font = new System.Drawing.Font("Pou", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoreboard.Location = new System.Drawing.Point(105, 359);
            this.btnScoreboard.Name = "btnScoreboard";
            this.btnScoreboard.Size = new System.Drawing.Size(268, 91);
            this.btnScoreboard.TabIndex = 2;
            this.btnScoreboard.Text = "Scoreboard";
            this.btnScoreboard.UseVisualStyleBackColor = true;
            this.btnScoreboard.Click += new System.EventHandler(this.btnScoreboard_Click);
            // 
            // btnInformations
            // 
            this.btnInformations.Font = new System.Drawing.Font("Pou", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformations.Location = new System.Drawing.Point(105, 493);
            this.btnInformations.Name = "btnInformations";
            this.btnInformations.Size = new System.Drawing.Size(268, 91);
            this.btnInformations.TabIndex = 3;
            this.btnInformations.Text = "Informações";
            this.btnInformations.UseVisualStyleBackColor = true;
            this.btnInformations.Click += new System.EventHandler(this.btnInformations_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Pou", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(105, 626);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(268, 91);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Sair do Jogo";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // eastereggclickPou
            // 
            this.eastereggclickPou.Image = ((System.Drawing.Image)(resources.GetObject("eastereggclickPou.Image")));
            this.eastereggclickPou.Location = new System.Drawing.Point(620, 197);
            this.eastereggclickPou.Name = "eastereggclickPou";
            this.eastereggclickPou.Size = new System.Drawing.Size(577, 530);
            this.eastereggclickPou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eastereggclickPou.TabIndex = 5;
            this.eastereggclickPou.TabStop = false;
            this.eastereggclickPou.Click += new System.EventHandler(this.eastereggclickPou_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pou", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "*Jogo feito por Leandro Pellizzola 2º Informática*";
            // 
            // lbPlayerNickname
            // 
            this.lbPlayerNickname.AutoSize = true;
            this.lbPlayerNickname.Font = new System.Drawing.Font("Pou", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerNickname.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPlayerNickname.Location = new System.Drawing.Point(805, 230);
            this.lbPlayerNickname.Name = "lbPlayerNickname";
            this.lbPlayerNickname.Size = new System.Drawing.Size(92, 32);
            this.lbPlayerNickname.TabIndex = 7;
            this.lbPlayerNickname.Text = "nick";
            this.lbPlayerNickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1203, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 132);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pou", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1188, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "github.com/pellizzolah";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbPlayerNickname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eastereggclickPou);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInformations);
            this.Controls.Add(this.btnScoreboard);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pou Menu";
            ((System.ComponentModel.ISupportInitialize)(this.eastereggclickPou)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnScoreboard;
        private System.Windows.Forms.Button btnInformations;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox eastereggclickPou;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPlayerNickname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}