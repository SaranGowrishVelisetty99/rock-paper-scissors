namespace rock__paper_sissors
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
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.PlayerPicture = new System.Windows.Forms.PictureBox();
            this.EnemyPicture = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.enemyscorelabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ourscore = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::rock__paper_sissors.Properties.Resources.paper;
            this.pictureBox7.Location = new System.Drawing.Point(583, 91);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::rock__paper_sissors.Properties.Resources.sissors;
            this.pictureBox8.Location = new System.Drawing.Point(583, 157);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::rock__paper_sissors.Properties.Resources.rock;
            this.pictureBox9.Location = new System.Drawing.Point(583, 12);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // PlayerPicture
            // 
            this.PlayerPicture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerPicture.Location = new System.Drawing.Point(360, 60);
            this.PlayerPicture.Name = "PlayerPicture";
            this.PlayerPicture.Size = new System.Drawing.Size(174, 173);
            this.PlayerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerPicture.TabIndex = 3;
            this.PlayerPicture.TabStop = false;
            // 
            // EnemyPicture
            // 
            this.EnemyPicture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EnemyPicture.Location = new System.Drawing.Point(25, 60);
            this.EnemyPicture.Name = "EnemyPicture";
            this.EnemyPicture.Size = new System.Drawing.Size(171, 173);
            this.EnemyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyPicture.TabIndex = 4;
            this.EnemyPicture.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 39);
            this.label6.TabIndex = 5;
            this.label6.Text = "State:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 39);
            this.label8.TabIndex = 6;
            this.label8.Text = "Score:";
            // 
            // enemyscorelabel
            // 
            this.enemyscorelabel.AutoSize = true;
            this.enemyscorelabel.Location = new System.Drawing.Point(170, 300);
            this.enemyscorelabel.Name = "enemyscorelabel";
            this.enemyscorelabel.Size = new System.Drawing.Size(36, 39);
            this.enemyscorelabel.TabIndex = 7;
            this.enemyscorelabel.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 39);
            this.label10.TabIndex = 8;
            this.label10.Text = "-";
            // 
            // ourscore
            // 
            this.ourscore.AutoSize = true;
            this.ourscore.Location = new System.Drawing.Point(340, 300);
            this.ourscore.Name = "ourscore";
            this.ourscore.Size = new System.Drawing.Size(36, 39);
            this.ourscore.TabIndex = 9;
            this.ourscore.Text = "0";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(5, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 41);
            this.button3.TabIndex = 10;
            this.button3.Text = "RESET GAME";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 380);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ourscore);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.enemyscorelabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EnemyPicture);
            this.Controls.Add(this.PlayerPicture);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox playerbox;
        private System.Windows.Forms.PictureBox botbox;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label botsscore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerscore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox botsbox;
        private System.Windows.Forms.PictureBox playersbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bscore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label pscore;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox PlayerPicture;
        private System.Windows.Forms.PictureBox EnemyPicture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label enemyscorelabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ourscore;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button3;
    }
}

