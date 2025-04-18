namespace WF_login
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button7 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button7);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(298, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(517, 10);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(352, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(116, 130);
            panel3.TabIndex = 2;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Rockwell", 12F, FontStyle.Italic);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-2, 3);
            button7.Name = "button7";
            button7.Size = new Size(294, 108);
            button7.TabIndex = 0;
            button7.Text = "Começo";
            button7.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Rockwell", 12F, FontStyle.Italic);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 117);
            button1.Name = "button1";
            button1.Size = new Size(294, 83);
            button1.TabIndex = 0;
            button1.Text = "Produtos";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Rockwell", 12F, FontStyle.Italic);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(6, 206);
            button3.Name = "button3";
            button3.Size = new Size(294, 75);
            button3.TabIndex = 0;
            button3.Text = "Clientes";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Rockwell", 12F, FontStyle.Italic);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources._3558109_delivery_dogs_food_hot_street_icon1;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 355);
            button4.Name = "button4";
            button4.Size = new Size(294, 92);
            button4.TabIndex = 0;
            button4.Text = "Entregas";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._3558116_fast_food_french_fries_snacks_icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 96);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 1;
            label1.Text = "Senacfood";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 11F);
            label2.Location = new Point(471, 34);
            label2.Name = "label2";
            label2.Size = new Size(209, 25);
            label2.TabIndex = 3;
            label2.Text = "Gestão de delivery";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._820689_cookie_biscuit_holidays_food_icon;
            pictureBox2.Location = new Point(675, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 37);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._2386376_food_hamburder_v1_icon;
            pictureBox3.Location = new Point(728, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 54);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Rockwell", 12F, FontStyle.Italic);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 281);
            button2.Name = "button2";
            button2.Size = new Size(294, 68);
            button2.TabIndex = 0;
            button2.Text = "Pagto";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button4_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Button button7;
        private Button button4;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button2;
    }
}