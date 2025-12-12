namespace dog_race
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            dogPicture1 = new PictureBox();
            dogPicture2 = new PictureBox();
            dogPicture3 = new PictureBox();
            dogPicture4 = new PictureBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label1 = new Label();
            minimumBetValueLabel = new Label();
            bettorNameLabel = new Label();
            betCashUpDown = new NumericUpDown();
            label3 = new Label();
            betDogNumUpDown = new NumericUpDown();
            startButton = new Button();
            groupBox1 = new GroupBox();
            betButton = new Button();
            arekBetLabel = new Label();
            bartekBetLabel = new Label();
            janekBetLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dogPicture1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dogPicture2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dogPicture3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dogPicture4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)betCashUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)betDogNumUpDown).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tor;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dogPicture1
            // 
            dogPicture1.BackColor = Color.Transparent;
            dogPicture1.BackgroundImageLayout = ImageLayout.None;
            dogPicture1.Image = (Image)resources.GetObject("dogPicture1.Image");
            dogPicture1.Location = new Point(25, 21);
            dogPicture1.Name = "dogPicture1";
            dogPicture1.Size = new Size(66, 42);
            dogPicture1.SizeMode = PictureBoxSizeMode.StretchImage;
            dogPicture1.TabIndex = 1;
            dogPicture1.TabStop = false;
            // 
            // dogPicture2
            // 
            dogPicture2.BackColor = Color.Transparent;
            dogPicture2.BackgroundImageLayout = ImageLayout.None;
            dogPicture2.Image = (Image)resources.GetObject("dogPicture2.Image");
            dogPicture2.Location = new Point(25, 84);
            dogPicture2.Name = "dogPicture2";
            dogPicture2.Size = new Size(66, 42);
            dogPicture2.SizeMode = PictureBoxSizeMode.StretchImage;
            dogPicture2.TabIndex = 2;
            dogPicture2.TabStop = false;
            // 
            // dogPicture3
            // 
            dogPicture3.BackColor = Color.Transparent;
            dogPicture3.BackgroundImageLayout = ImageLayout.None;
            dogPicture3.Image = (Image)resources.GetObject("dogPicture3.Image");
            dogPicture3.Location = new Point(25, 150);
            dogPicture3.Name = "dogPicture3";
            dogPicture3.Size = new Size(66, 42);
            dogPicture3.SizeMode = PictureBoxSizeMode.StretchImage;
            dogPicture3.TabIndex = 3;
            dogPicture3.TabStop = false;
            // 
            // dogPicture4
            // 
            dogPicture4.BackColor = Color.Transparent;
            dogPicture4.BackgroundImageLayout = ImageLayout.None;
            dogPicture4.Image = (Image)resources.GetObject("dogPicture4.Image");
            dogPicture4.Location = new Point(25, 216);
            dogPicture4.Name = "dogPicture4";
            dogPicture4.Size = new Size(66, 42);
            dogPicture4.SizeMode = PictureBoxSizeMode.StretchImage;
            dogPicture4.TabIndex = 4;
            dogPicture4.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(10, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(10, 67);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(10, 92);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 7;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 19);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 11;
            label1.Text = "Zakłady";
            // 
            // minimumBetValueLabel
            // 
            minimumBetValueLabel.AutoSize = true;
            minimumBetValueLabel.Location = new Point(42, 22);
            minimumBetValueLabel.Name = "minimumBetValueLabel";
            minimumBetValueLabel.Size = new Size(105, 15);
            minimumBetValueLabel.TabIndex = 12;
            minimumBetValueLabel.Text = "minimumBetValue";
            // 
            // bettorNameLabel
            // 
            bettorNameLabel.AutoSize = true;
            bettorNameLabel.Location = new Point(42, 133);
            bettorNameLabel.Name = "bettorNameLabel";
            bettorNameLabel.Size = new Size(36, 15);
            bettorNameLabel.TabIndex = 13;
            bettorNameLabel.Text = "Janek";
            // 
            // betCashUpDown
            // 
            betCashUpDown.Location = new Point(228, 129);
            betCashUpDown.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            betCashUpDown.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            betCashUpDown.Name = "betCashUpDown";
            betCashUpDown.Size = new Size(102, 23);
            betCashUpDown.TabIndex = 15;
            betCashUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 133);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 16;
            label3.Text = "zł na psa numer";
            // 
            // betDogNumUpDown
            // 
            betDogNumUpDown.Location = new Point(468, 129);
            betDogNumUpDown.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            betDogNumUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            betDogNumUpDown.Name = "betDogNumUpDown";
            betDogNumUpDown.Size = new Size(36, 23);
            betDogNumUpDown.TabIndex = 17;
            betDogNumUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 20F);
            startButton.Location = new Point(574, 24);
            startButton.Name = "startButton";
            startButton.Size = new Size(206, 124);
            startButton.TabIndex = 18;
            startButton.Text = "Start!";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(betDogNumUpDown);
            groupBox1.Controls.Add(betCashUpDown);
            groupBox1.Controls.Add(startButton);
            groupBox1.Controls.Add(betButton);
            groupBox1.Controls.Add(arekBetLabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(bartekBetLabel);
            groupBox1.Controls.Add(janekBetLabel);
            groupBox1.Controls.Add(minimumBetValueLabel);
            groupBox1.Controls.Add(bettorNameLabel);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(2, 279);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 159);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dom bukmacherski";
            // 
            // betButton
            // 
            betButton.Location = new Point(131, 129);
            betButton.Name = "betButton";
            betButton.Size = new Size(75, 23);
            betButton.TabIndex = 21;
            betButton.Text = "stawia";
            betButton.UseVisualStyleBackColor = true;
            betButton.Click += betButton_Click;
            // 
            // arekBetLabel
            // 
            arekBetLabel.BorderStyle = BorderStyle.FixedSingle;
            arekBetLabel.Location = new Point(210, 92);
            arekBetLabel.Name = "arekBetLabel";
            arekBetLabel.Size = new Size(240, 17);
            arekBetLabel.TabIndex = 20;
            // 
            // bartekBetLabel
            // 
            bartekBetLabel.BorderStyle = BorderStyle.FixedSingle;
            bartekBetLabel.Location = new Point(210, 67);
            bartekBetLabel.Name = "bartekBetLabel";
            bartekBetLabel.Size = new Size(240, 17);
            bartekBetLabel.TabIndex = 20;
            // 
            // janekBetLabel
            // 
            janekBetLabel.BorderStyle = BorderStyle.FixedSingle;
            janekBetLabel.Location = new Point(210, 40);
            janekBetLabel.Name = "janekBetLabel";
            janekBetLabel.Size = new Size(240, 17);
            janekBetLabel.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dogPicture4);
            Controls.Add(dogPicture3);
            Controls.Add(dogPicture2);
            Controls.Add(dogPicture1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dogPicture1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dogPicture2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dogPicture3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dogPicture4).EndInit();
            ((System.ComponentModel.ISupportInitialize)betCashUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)betDogNumUpDown).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox dogPicture1;
        private PictureBox dogPicture2;
        private PictureBox dogPicture3;
        private PictureBox dogPicture4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label1;
        private Label minimumBetValueLabel;
        private Label bettorNameLabel;
        private NumericUpDown betCashUpDown;
        private Label label3;
        private NumericUpDown betDogNumUpDown;
        private Button startButton;
        private GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private Label janekBetLabel;
        private Label arekBetLabel;
        private Label bartekBetLabel;
        private Button betButton;
    }
}
