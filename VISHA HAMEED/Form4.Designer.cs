namespace VISHA_HAMEED
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            Button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 453);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(286, 35);
            label1.Name = "label1";
            label1.Size = new Size(203, 32);
            label1.TabIndex = 1;
            label1.Text = "BOOK FLIGHT";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(30, 261);
            button1.Name = "button1";
            button1.Size = new Size(268, 34);
            button1.TabIndex = 2;
            button1.Text = "DOMESTIC FLIGHT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(30, 335);
            button2.Name = "button2";
            button2.Size = new Size(268, 34);
            button2.TabIndex = 3;
            button2.Text = "INTERNATIONAL FLIGHT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // Button4
            // 
            Button4.BackColor = Color.Transparent;
            Button4.BackgroundImage = (Image)resources.GetObject("Button4.BackgroundImage");
            Button4.BackgroundImageLayout = ImageLayout.Zoom;
            Button4.FlatStyle = FlatStyle.Popup;
            Button4.Font = new Font("Times New Roman", 9F, FontStyle.Italic);
            Button4.ForeColor = Color.Transparent;
            Button4.Image = (Image)resources.GetObject("Button4.Image");
            Button4.ImageAlign = ContentAlignment.MiddleLeft;
            Button4.Location = new Point(676, 404);
            Button4.Name = "Button4";
            Button4.Size = new Size(112, 34);
            Button4.TabIndex = 21;
            Button4.Text = "EXIT";
            Button4.UseVisualStyleBackColor = false;
            Button4.Click += Button4_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        internal Button Button4;
    }
}