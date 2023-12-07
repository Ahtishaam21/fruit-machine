namespace fruit_machine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Slot1 = new PictureBox();
            Slot2 = new PictureBox();
            Slot3 = new PictureBox();
            Start = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            slot1b = new PictureBox();
            slot2b = new PictureBox();
            slot3b = new PictureBox();
            slot1t = new PictureBox();
            slot2t = new PictureBox();
            slot3t = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Slot1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Slot2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Slot3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot1b).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot2b).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot3b).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot1t).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot2t).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot3t).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.HotTrack;
            pictureBox1.Location = new Point(112, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(783, 553);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.MenuText;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 554);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Slot1
            // 
            Slot1.Location = new Point(206, 195);
            Slot1.Name = "Slot1";
            Slot1.Size = new Size(104, 106);
            Slot1.TabIndex = 2;
            Slot1.TabStop = false;
            Slot1.Paint += Slot1_Paint;
            // 
            // Slot2
            // 
            Slot2.Location = new Point(420, 195);
            Slot2.Name = "Slot2";
            Slot2.Size = new Size(104, 106);
            Slot2.TabIndex = 3;
            Slot2.TabStop = false;
            // 
            // Slot3
            // 
            Slot3.Location = new Point(652, 195);
            Slot3.Name = "Slot3";
            Slot3.Size = new Size(104, 106);
            Slot3.TabIndex = 4;
            Slot3.TabStop = false;
            // 
            // Start
            // 
            Start.BackColor = Color.Green;
            Start.ForeColor = SystemColors.HighlightText;
            Start.Location = new Point(12, 23);
            Start.Name = "Start";
            Start.Size = new Size(85, 40);
            Start.TabIndex = 5;
            Start.Text = "START";
            Start.TextImageRelation = TextImageRelation.TextBeforeImage;
            Start.UseMnemonic = false;
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click_1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Tick += timer4_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(217, 414);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(445, 414);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(670, 414);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // slot1b
            // 
            slot1b.Location = new Point(206, 129);
            slot1b.Name = "slot1b";
            slot1b.Size = new Size(100, 50);
            slot1b.TabIndex = 9;
            slot1b.TabStop = false;
            // 
            // slot2b
            // 
            slot2b.Location = new Point(420, 129);
            slot2b.Name = "slot2b";
            slot2b.Size = new Size(100, 50);
            slot2b.TabIndex = 10;
            slot2b.TabStop = false;
            // 
            // slot3b
            // 
            slot3b.Location = new Point(656, 129);
            slot3b.Name = "slot3b";
            slot3b.Size = new Size(100, 50);
            slot3b.TabIndex = 11;
            slot3b.TabStop = false;
            // 
            // slot1t
            // 
            slot1t.Location = new Point(206, 322);
            slot1t.Name = "slot1t";
            slot1t.Size = new Size(100, 50);
            slot1t.TabIndex = 12;
            slot1t.TabStop = false;
            // 
            // slot2t
            // 
            slot2t.Location = new Point(420, 322);
            slot2t.Name = "slot2t";
            slot2t.Size = new Size(100, 50);
            slot2t.TabIndex = 13;
            slot2t.TabStop = false;
            // 
            // slot3t
            // 
            slot3t.Location = new Point(656, 331);
            slot3t.Name = "slot3t";
            slot3t.Size = new Size(100, 50);
            slot3t.TabIndex = 14;
            slot3t.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 556);
            Controls.Add(slot3t);
            Controls.Add(slot2t);
            Controls.Add(slot1t);
            Controls.Add(slot3b);
            Controls.Add(slot2b);
            Controls.Add(slot1b);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Start);
            Controls.Add(Slot3);
            Controls.Add(Slot2);
            Controls.Add(Slot1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Slot1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Slot2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Slot3).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot1b).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot2b).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot3b).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot1t).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot2t).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot3t).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox Slot1;
        private PictureBox Slot2;
        private PictureBox Slot3;
        private Button Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox slot1b;
        private PictureBox slot2b;
        private PictureBox slot3b;
        private PictureBox slot1t;
        private PictureBox slot2t;
        private PictureBox slot3t;
    }
}