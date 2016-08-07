namespace projekt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player = new System.Windows.Forms.PictureBox();
            this.pTime = new System.Windows.Forms.Timer(this.components);
            this.alTime = new System.Windows.Forms.Timer(this.components);
            this.al1 = new System.Windows.Forms.PictureBox();
            this.al2 = new System.Windows.Forms.PictureBox();
            this.al3 = new System.Windows.Forms.PictureBox();
            this.al4 = new System.Windows.Forms.PictureBox();
            this.Credit = new System.Windows.Forms.PictureBox();
            this.crTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PaulNotice = new System.Windows.Forms.PictureBox();
            this.OK = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Label();
            this.MackleNotice = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.al1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.al2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.al3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.al4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Credit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaulNotice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MackleNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Player.BackgroundImage")));
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Player.Location = new System.Drawing.Point(136, 136);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(27, 27);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // pTime
            // 
            this.pTime.Enabled = true;
            this.pTime.Interval = 1;
            this.pTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alTime
            // 
            this.alTime.Enabled = true;
            this.alTime.Interval = 1;
            this.alTime.Tick += new System.EventHandler(this.alTime_Tick);
            // 
            // al1
            // 
            this.al1.BackColor = System.Drawing.Color.Transparent;
            this.al1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("al1.BackgroundImage")));
            this.al1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.al1.Location = new System.Drawing.Point(13, -30);
            this.al1.Name = "al1";
            this.al1.Size = new System.Drawing.Size(27, 27);
            this.al1.TabIndex = 1;
            this.al1.TabStop = false;
            // 
            // al2
            // 
            this.al2.BackColor = System.Drawing.Color.Transparent;
            this.al2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("al2.BackgroundImage")));
            this.al2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.al2.Location = new System.Drawing.Point(-30, 260);
            this.al2.Name = "al2";
            this.al2.Size = new System.Drawing.Size(27, 27);
            this.al2.TabIndex = 2;
            this.al2.TabStop = false;
            // 
            // al3
            // 
            this.al3.BackColor = System.Drawing.Color.Transparent;
            this.al3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("al3.BackgroundImage")));
            this.al3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.al3.Location = new System.Drawing.Point(301, 13);
            this.al3.Name = "al3";
            this.al3.Size = new System.Drawing.Size(27, 27);
            this.al3.TabIndex = 3;
            this.al3.TabStop = false;
            // 
            // al4
            // 
            this.al4.BackColor = System.Drawing.Color.Transparent;
            this.al4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("al4.BackgroundImage")));
            this.al4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.al4.Location = new System.Drawing.Point(301, 261);
            this.al4.Name = "al4";
            this.al4.Size = new System.Drawing.Size(27, 27);
            this.al4.TabIndex = 4;
            this.al4.TabStop = false;
            // 
            // Credit
            // 
            this.Credit.BackColor = System.Drawing.Color.Transparent;
            this.Credit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Credit.BackgroundImage")));
            this.Credit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Credit.Location = new System.Drawing.Point(136, 320);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(27, 27);
            this.Credit.TabIndex = 5;
            this.Credit.TabStop = false;
            // 
            // crTime
            // 
            this.crTime.Enabled = true;
            this.crTime.Interval = 10000;
            this.crTime.Tick += new System.EventHandler(this.crTime_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 310);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // PaulNotice
            // 
            this.PaulNotice.BackColor = System.Drawing.Color.Transparent;
            this.PaulNotice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PaulNotice.BackgroundImage")));
            this.PaulNotice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PaulNotice.Location = new System.Drawing.Point(-1, 73);
            this.PaulNotice.Name = "PaulNotice";
            this.PaulNotice.Size = new System.Drawing.Size(303, 163);
            this.PaulNotice.TabIndex = 7;
            this.PaulNotice.TabStop = false;
            this.PaulNotice.Visible = false;
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(203, 198);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(52, 26);
            this.OK.TabIndex = 8;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Visible = false;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(59, 203);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(40, 13);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.Visible = false;
            this.cancel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MackleNotice
            // 
            this.MackleNotice.BackColor = System.Drawing.Color.Transparent;
            this.MackleNotice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MackleNotice.Image = ((System.Drawing.Image)(resources.GetObject("MackleNotice.Image")));
            this.MackleNotice.Location = new System.Drawing.Point(2, 73);
            this.MackleNotice.Name = "MackleNotice";
            this.MackleNotice.Size = new System.Drawing.Size(303, 163);
            this.MackleNotice.TabIndex = 10;
            this.MackleNotice.TabStop = false;
            this.MackleNotice.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(114, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Credits earned:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Use the arrow keys to move and dodge Macklebee!\r\n                       Press \'sp" +
    "ace\' to begin.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Credits:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.MackleNotice);
            this.Controls.Add(this.PaulNotice);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.al4);
            this.Controls.Add(this.al3);
            this.Controls.Add(this.al2);
            this.Controls.Add(this.al1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodglebee";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.al1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.al2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.al3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.al4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Credit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaulNotice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MackleNotice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer pTime;
        private System.Windows.Forms.Timer alTime;
        private System.Windows.Forms.PictureBox al1;
        private System.Windows.Forms.PictureBox al2;
        private System.Windows.Forms.PictureBox al3;
        private System.Windows.Forms.PictureBox al4;
        private System.Windows.Forms.PictureBox Credit;
        private System.Windows.Forms.Timer crTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PaulNotice;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label cancel;
        private System.Windows.Forms.PictureBox MackleNotice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

