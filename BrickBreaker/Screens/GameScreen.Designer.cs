namespace BrickBreaker
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pauseTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pauseTimer
            // 
            this.pauseTimer.Interval = 1000;
            this.pauseTimer.Tick += new System.EventHandler(this.PauseTimer_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = global::BrickBreaker.Properties.Resources.yellowBrick;
            this.label2.Location = new System.Drawing.Point(33, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 27);
            this.label2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Image = global::BrickBreaker.Properties.Resources.greenBrick;
            this.label4.Location = new System.Drawing.Point(33, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 27);
            this.label4.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label8.Location = new System.Drawing.Point(158, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 27);
            this.label8.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label9.Location = new System.Drawing.Point(115, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 27);
            this.label9.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Image = global::BrickBreaker.Properties.Resources.blueBrick;
            this.label10.Location = new System.Drawing.Point(33, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 27);
            this.label10.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label12.Location = new System.Drawing.Point(201, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 27);
            this.label12.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Image = global::BrickBreaker.Properties.Resources.greenBrick;
            this.label17.Location = new System.Drawing.Point(33, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 27);
            this.label17.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 27);
            this.label1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label3.Location = new System.Drawing.Point(76, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 27);
            this.label3.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label5.Location = new System.Drawing.Point(33, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 27);
            this.label5.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label6.Location = new System.Drawing.Point(248, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 27);
            this.label6.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label7.Location = new System.Drawing.Point(291, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 27);
            this.label7.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label11.Location = new System.Drawing.Point(336, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 27);
            this.label11.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label13.Location = new System.Drawing.Point(463, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 27);
            this.label13.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label14.Location = new System.Drawing.Point(422, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 27);
            this.label14.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label15.Location = new System.Drawing.Point(377, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 27);
            this.label15.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label16.Location = new System.Drawing.Point(508, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 27);
            this.label16.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label18.Location = new System.Drawing.Point(639, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 27);
            this.label18.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label19.Location = new System.Drawing.Point(596, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 27);
            this.label19.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label20.Location = new System.Drawing.Point(552, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 27);
            this.label20.TabIndex = 33;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label21.Location = new System.Drawing.Point(425, 286);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 27);
            this.label21.TabIndex = 34;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label22.Location = new System.Drawing.Point(683, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 27);
            this.label22.TabIndex = 35;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label23.Location = new System.Drawing.Point(727, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 27);
            this.label23.TabIndex = 36;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Image = global::BrickBreaker.Properties.Resources.redBrick;
            this.label24.Location = new System.Drawing.Point(772, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 27);
            this.label24.TabIndex = 37;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(850, 550);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;

        private System.Windows.Forms.Timer pauseTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }
}
