namespace VISHA_HAMEED
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Label1 = new Label();
            Label2 = new Label();
            Button4 = new Button();
            Button3 = new Button();
            Button2 = new Button();
            Button1 = new Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Black;
            Label1.FlatStyle = FlatStyle.Popup;
            Label1.Font = new Font("Times New Roman", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.Transparent;
            Label1.Image = (Image)resources.GetObject("Label1.Image");
            Label1.ImageAlign = ContentAlignment.TopLeft;
            Label1.Location = new Point(12, 26);
            Label1.Name = "Label1";
            Label1.Size = new Size(150, 25);
            Label1.TabIndex = 22;
            Label1.Text = "MAIN MENU...";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.Transparent;
            Label2.Image = (Image)resources.GetObject("Label2.Image");
            Label2.Location = new Point(784, 16);
            Label2.Name = "Label2";
            Label2.Size = new Size(74, 21);
            Label2.TabIndex = 21;
            Label2.Text = "AIRFLY";
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
            Button4.Location = new Point(746, 511);
            Button4.Name = "Button4";
            Button4.Size = new Size(112, 34);
            Button4.TabIndex = 20;
            Button4.Text = "EXIT";
            Button4.UseVisualStyleBackColor = false;
            // 
            // Button3
            // 
            Button3.BackColor = Color.Transparent;
            Button3.BackgroundImage = (Image)resources.GetObject("Button3.BackgroundImage");
            Button3.BackgroundImageLayout = ImageLayout.Zoom;
            Button3.FlatStyle = FlatStyle.Popup;
            Button3.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic);
            Button3.ForeColor = Color.Transparent;
            Button3.Image = (Image)resources.GetObject("Button3.Image");
            Button3.ImageAlign = ContentAlignment.BottomCenter;
            Button3.Location = new Point(366, 387);
            Button3.Name = "Button3";
            Button3.Size = new Size(216, 34);
            Button3.TabIndex = 19;
            Button3.Text = "CHECK TICKET";
            Button3.UseVisualStyleBackColor = false;
            // 
            // Button2
            // 
            Button2.BackColor = Color.Transparent;
            Button2.BackgroundImage = (Image)resources.GetObject("Button2.BackgroundImage");
            Button2.BackgroundImageLayout = ImageLayout.Zoom;
            Button2.FlatStyle = FlatStyle.Popup;
            Button2.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic);
            Button2.ForeColor = Color.Transparent;
            Button2.Image = (Image)resources.GetObject("Button2.Image");
            Button2.ImageAlign = ContentAlignment.BottomLeft;
            Button2.Location = new Point(202, 324);
            Button2.Name = "Button2";
            Button2.Size = new Size(210, 34);
            Button2.TabIndex = 18;
            Button2.Text = "CANCEL FLIGHT";
            Button2.UseVisualStyleBackColor = false;
            // 
            // Button1
            // 
            Button1.BackColor = Color.Transparent;
            Button1.BackgroundImage = (Image)resources.GetObject("Button1.BackgroundImage");
            Button1.BackgroundImageLayout = ImageLayout.Zoom;
            Button1.FlatStyle = FlatStyle.Popup;
            Button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic);
            Button1.ForeColor = Color.Transparent;
            Button1.Image = (Image)resources.GetObject("Button1.Image");
            Button1.ImageAlign = ContentAlignment.BottomLeft;
            Button1.Location = new Point(38, 254);
            Button1.Name = "Button1";
            Button1.Size = new Size(224, 34);
            Button1.TabIndex = 17;
            Button1.Text = "BOOK FLIGHT";
            Button1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(Label1);
            Controls.Add(Label2);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            this.Name = "Form2";
            this.Text = "Form2";
            Load += Form2_Load;
            this.ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label Label1;
        internal Label Label2;
        internal Button Button4;
        internal Button Button3;
        internal Button Button2;
        internal Button Button1;
    }
}