namespace WinFormsApp1BMP
{
    partial class MainForm
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
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            OpenFilebtn1 = new Button();
            pictureBox2 = new PictureBox();
            H = new TrackBar();
            S = new TrackBar();
            V = new TrackBar();
            H2 = new TrackBar();
            S2 = new TrackBar();
            V2 = new TrackBar();
            Htxt = new TextBox();
            Stxt = new TextBox();
            Vtxt = new TextBox();
            H2txt = new TextBox();
            S2txt = new TextBox();
            V2txt = new TextBox();
            Recalculatebtn = new Button();
            pictureBox3 = new PictureBox();
            OpenFilebtn2 = new Button();
            Image1Label = new Label();
            Image2Label = new Label();
            Image3Label = new Label();
            Histbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)H).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S).BeginInit();
            ((System.ComponentModel.ISupportInitialize)V).BeginInit();
            ((System.ComponentModel.ISupportInitialize)H2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)V2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(571, 606);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFilebtn1
            // 
            OpenFilebtn1.Location = new Point(850, 676);
            OpenFilebtn1.Name = "OpenFilebtn1";
            OpenFilebtn1.Size = new Size(111, 23);
            OpenFilebtn1.TabIndex = 1;
            OpenFilebtn1.Text = "Otwórz plik 1";
            OpenFilebtn1.UseVisualStyleBackColor = true;
            OpenFilebtn1.Click += LoadImage1btn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(601, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(571, 606);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // H
            // 
            H.LargeChange = 100;
            H.Location = new Point(3, 686);
            H.Maximum = 360;
            H.Name = "H";
            H.Size = new Size(292, 45);
            H.TabIndex = 3;
            H.Value = 100;
            H.Scroll += H_Scroll;
            // 
            // S
            // 
            S.Location = new Point(3, 728);
            S.Maximum = 255;
            S.Name = "S";
            S.Size = new Size(292, 45);
            S.TabIndex = 4;
            S.Value = 100;
            S.Scroll += S_Scroll;
            // 
            // V
            // 
            V.Location = new Point(3, 768);
            V.Maximum = 255;
            V.Name = "V";
            V.Size = new Size(292, 45);
            V.TabIndex = 5;
            V.Value = 100;
            V.Scroll += V_Scroll;
            // 
            // H2
            // 
            H2.LargeChange = 100;
            H2.Location = new Point(374, 676);
            H2.Maximum = 360;
            H2.Name = "H2";
            H2.Size = new Size(292, 45);
            H2.TabIndex = 6;
            H2.Value = 150;
            H2.Scroll += H2_Scroll;
            // 
            // S2
            // 
            S2.LargeChange = 100;
            S2.Location = new Point(374, 727);
            S2.Maximum = 255;
            S2.Name = "S2";
            S2.Size = new Size(292, 45);
            S2.TabIndex = 7;
            S2.Value = 255;
            S2.Scroll += S2_Scroll;
            // 
            // V2
            // 
            V2.LargeChange = 100;
            V2.Location = new Point(374, 764);
            V2.Maximum = 255;
            V2.Name = "V2";
            V2.Size = new Size(292, 45);
            V2.TabIndex = 8;
            V2.Value = 255;
            V2.Scroll += V2_Scroll;
            // 
            // Htxt
            // 
            Htxt.Location = new Point(300, 684);
            Htxt.Name = "Htxt";
            Htxt.Size = new Size(41, 23);
            Htxt.TabIndex = 9;
            Htxt.Leave += Htxt_Leave;
            // 
            // Stxt
            // 
            Stxt.Location = new Point(300, 727);
            Stxt.Name = "Stxt";
            Stxt.Size = new Size(41, 23);
            Stxt.TabIndex = 10;
            Stxt.Leave += Stxt_Leave;
            // 
            // Vtxt
            // 
            Vtxt.Location = new Point(300, 781);
            Vtxt.Name = "Vtxt";
            Vtxt.Size = new Size(41, 23);
            Vtxt.TabIndex = 11;
            Vtxt.Leave += Vtxt_Leave;
            // 
            // H2txt
            // 
            H2txt.Location = new Point(682, 684);
            H2txt.Name = "H2txt";
            H2txt.Size = new Size(41, 23);
            H2txt.TabIndex = 12;
            H2txt.Leave += H2txt_Leave;
            // 
            // S2txt
            // 
            S2txt.Location = new Point(682, 728);
            S2txt.Name = "S2txt";
            S2txt.Size = new Size(41, 23);
            S2txt.TabIndex = 13;
            S2txt.Leave += S2txt_Leave;
            // 
            // V2txt
            // 
            V2txt.Location = new Point(682, 768);
            V2txt.Name = "V2txt";
            V2txt.Size = new Size(41, 23);
            V2txt.TabIndex = 14;
            V2txt.Leave += V2txt_Leave;
            // 
            // Recalculatebtn
            // 
            Recalculatebtn.Location = new Point(1052, 676);
            Recalculatebtn.Name = "Recalculatebtn";
            Recalculatebtn.Size = new Size(75, 23);
            Recalculatebtn.TabIndex = 15;
            Recalculatebtn.Text = "Przelicz";
            Recalculatebtn.UseVisualStyleBackColor = true;
            Recalculatebtn.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(1190, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(571, 606);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // OpenFilebtn2
            // 
            OpenFilebtn2.Location = new Point(850, 708);
            OpenFilebtn2.Name = "OpenFilebtn2";
            OpenFilebtn2.Size = new Size(111, 23);
            OpenFilebtn2.TabIndex = 20;
            OpenFilebtn2.Text = "Otwórz plik 2";
            OpenFilebtn2.UseVisualStyleBackColor = true;
            OpenFilebtn2.Click += LoadImage2btn_Click;
            // 
            // Image1Label
            // 
            Image1Label.AutoSize = true;
            Image1Label.Location = new Point(12, 9);
            Image1Label.Name = "Image1Label";
            Image1Label.Size = new Size(38, 15);
            Image1Label.TabIndex = 21;
            Image1Label.Text = "label1";
            // 
            // Image2Label
            // 
            Image2Label.AutoSize = true;
            Image2Label.Location = new Point(601, 9);
            Image2Label.Name = "Image2Label";
            Image2Label.Size = new Size(38, 15);
            Image2Label.TabIndex = 22;
            Image2Label.Text = "label2";
            // 
            // Image3Label
            // 
            Image3Label.AutoSize = true;
            Image3Label.Location = new Point(1190, 13);
            Image3Label.Name = "Image3Label";
            Image3Label.Size = new Size(38, 15);
            Image3Label.TabIndex = 23;
            Image3Label.Text = "label3";
            // 
            // Histbtn
            // 
            Histbtn.Location = new Point(1174, 678);
            Histbtn.Name = "Histbtn";
            Histbtn.Size = new Size(75, 23);
            Histbtn.TabIndex = 24;
            Histbtn.Text = "histogram";
            Histbtn.UseVisualStyleBackColor = true;
            Histbtn.Click += HistBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1802, 839);
            Controls.Add(Histbtn);
            Controls.Add(Image3Label);
            Controls.Add(Image2Label);
            Controls.Add(Image1Label);
            Controls.Add(OpenFilebtn2);
            Controls.Add(pictureBox3);
            Controls.Add(Recalculatebtn);
            Controls.Add(V2txt);
            Controls.Add(S2txt);
            Controls.Add(H2txt);
            Controls.Add(Vtxt);
            Controls.Add(Stxt);
            Controls.Add(Htxt);
            Controls.Add(V2);
            Controls.Add(S2);
            Controls.Add(H2);
            Controls.Add(V);
            Controls.Add(S);
            Controls.Add(H);
            Controls.Add(pictureBox2);
            Controls.Add(OpenFilebtn1);
            Controls.Add(pictureBox1);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)H).EndInit();
            ((System.ComponentModel.ISupportInitialize)S).EndInit();
            ((System.ComponentModel.ISupportInitialize)V).EndInit();
            ((System.ComponentModel.ISupportInitialize)H2).EndInit();
            ((System.ComponentModel.ISupportInitialize)S2).EndInit();
            ((System.ComponentModel.ISupportInitialize)V2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button OpenFilebtn1;
        private PictureBox pictureBox2;
        private TrackBar H;
        private TrackBar S;
        private TrackBar V;
        private TrackBar H2;
        private TrackBar S2;
        private TrackBar V2;
        private TextBox Htxt;
        private TextBox Stxt;
        private TextBox Vtxt;
        private TextBox H2txt;
        private TextBox S2txt;
        private TextBox V2txt;
        private Button Recalculatebtn;
        private PictureBox pictureBox3;
        private Button OpenFilebtn2;
        private Label Image1Label;
        private Label Image2Label;
        private Label Image3Label;
        private Button Histbtn;
    }
}
