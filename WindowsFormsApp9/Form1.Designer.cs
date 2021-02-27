namespace WindowsFormsApp9
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
            this.play_ground = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_point = new System.Windows.Forms.Label();
            this.lbl_Skor = new System.Windows.Forms.Label();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.pb_rocket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.play_ground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rocket)).BeginInit();
            this.SuspendLayout();
            // 
            // play_ground
            // 
            this.play_ground.Controls.Add(this.label3);
            this.play_ground.Controls.Add(this.lbl_point);
            this.play_ground.Controls.Add(this.lbl_Skor);
            this.play_ground.Controls.Add(this.Ball);
            this.play_ground.Controls.Add(this.pb_rocket);
            this.play_ground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.play_ground.Location = new System.Drawing.Point(0, 0);
            this.play_ground.Name = "play_ground";
            this.play_ground.Size = new System.Drawing.Size(800, 450);
            this.play_ground.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 171);
            this.label3.TabIndex = 4;
            this.label3.Text = "Game Over\r\n\r\nR - Restrart\r\n\r\nESC - EXIT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_point
            // 
            this.lbl_point.AutoSize = true;
            this.lbl_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_point.Location = new System.Drawing.Point(107, 24);
            this.lbl_point.Name = "lbl_point";
            this.lbl_point.Size = new System.Drawing.Size(19, 20);
            this.lbl_point.TabIndex = 3;
            this.lbl_point.Text = "0";
            // 
            // lbl_Skor
            // 
            this.lbl_Skor.AutoSize = true;
            this.lbl_Skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Skor.Location = new System.Drawing.Point(39, 24);
            this.lbl_Skor.Name = "lbl_Skor";
            this.lbl_Skor.Size = new System.Drawing.Size(46, 20);
            this.lbl_Skor.TabIndex = 2;
            this.lbl_Skor.Text = "Skor";
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ball.Location = new System.Drawing.Point(328, 114);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(30, 30);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // pb_rocket
            // 
            this.pb_rocket.BackColor = System.Drawing.Color.DarkRed;
            this.pb_rocket.Location = new System.Drawing.Point(250, 414);
            this.pb_rocket.Name = "pb_rocket";
            this.pb_rocket.Size = new System.Drawing.Size(150, 24);
            this.pb_rocket.TabIndex = 0;
            this.pb_rocket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.play_ground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pinpon_Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.play_ground.ResumeLayout(false);
            this.play_ground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rocket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel play_ground;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_point;
        private System.Windows.Forms.Label lbl_Skor;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox pb_rocket;
        private System.Windows.Forms.Timer timer1;
    }
}

