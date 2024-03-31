namespace Serwis_pogodowy_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            TBCity = new TextBox();
            button_search = new Button();
            labelTemp = new Label();
            labelCisnienie = new Label();
            label2 = new Label();
            label3 = new Label();
            labelTest = new Label();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            button_usun = new Button();
            buttonSortowanie = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(182, 82);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 3;
            label1.Text = "Miasto:";
            // 
            // TBCity
            // 
            TBCity.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TBCity.Location = new Point(304, 82);
            TBCity.Name = "TBCity";
            TBCity.Size = new Size(241, 36);
            TBCity.TabIndex = 4;
            // 
            // button_search
            // 
            button_search.BackColor = Color.Transparent;
            button_search.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(617, 85);
            button_search.Name = "button_search";
            button_search.Size = new Size(113, 36);
            button_search.TabIndex = 5;
            button_search.Text = "Wyszukaj";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.BackColor = Color.Transparent;
            labelTemp.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelTemp.ForeColor = Color.White;
            labelTemp.Location = new Point(645, 199);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(42, 28);
            labelTemp.TabIndex = 7;
            labelTemp.Text = "      ";
            // 
            // labelCisnienie
            // 
            labelCisnienie.AutoSize = true;
            labelCisnienie.BackColor = Color.Transparent;
            labelCisnienie.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelCisnienie.ForeColor = Color.White;
            labelCisnienie.Location = new Point(645, 255);
            labelCisnienie.Name = "labelCisnienie";
            labelCisnienie.Size = new Size(37, 28);
            labelCisnienie.TabIndex = 8;
            labelCisnienie.Text = "     ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(491, 199);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 9;
            label2.Text = "Temperatura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.White;
            label3.Location = new Point(504, 255);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 10;
            label3.Text = "Ciśnienie:";
            // 
            // labelTest
            // 
            labelTest.AutoSize = true;
            labelTest.BackColor = Color.Transparent;
            labelTest.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelTest.ForeColor = Color.White;
            labelTest.Location = new Point(55, 456);
            labelTest.Name = "labelTest";
            labelTest.Size = new Size(100, 28);
            labelTest.TabIndex = 11;
            labelTest.Text = "Ciśnienie:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(719, 199);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 169);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(460, 244);
            listBox1.TabIndex = 13;
            // 
            // button_usun
            // 
            button_usun.BackColor = Color.Transparent;
            button_usun.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button_usun.ForeColor = Color.White;
            button_usun.Location = new Point(617, 27);
            button_usun.Name = "button_usun";
            button_usun.Size = new Size(113, 36);
            button_usun.TabIndex = 14;
            button_usun.Text = "Usuń baze";
            button_usun.UseVisualStyleBackColor = false;
            button_usun.Click += button_usun_Click;
            // 
            // buttonSortowanie
            // 
            buttonSortowanie.BackColor = Color.Transparent;
            buttonSortowanie.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonSortowanie.ForeColor = Color.White;
            buttonSortowanie.Location = new Point(617, 141);
            buttonSortowanie.Name = "buttonSortowanie";
            buttonSortowanie.Size = new Size(113, 36);
            buttonSortowanie.TabIndex = 15;
            buttonSortowanie.Text = "Sortuj";
            buttonSortowanie.UseVisualStyleBackColor = false;
            buttonSortowanie.Click += buttonSortowanie_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(863, 525);
            Controls.Add(buttonSortowanie);
            Controls.Add(button_usun);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(labelTest);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelCisnienie);
            Controls.Add(labelTemp);
            Controls.Add(button_search);
            Controls.Add(TBCity);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox TBCity;
        private Button button_search;
        private Label labelTemp;
        private Label labelCisnienie;
        private Label label2;
        private Label label3;
        private Label labelTest;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button button_usun;
        private Button buttonSortowanie;
    }
}
