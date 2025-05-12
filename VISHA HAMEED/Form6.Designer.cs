namespace VISHA_HAMEED
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label1 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            comboBox3 = new System.Windows.Forms.ComboBox();
            comboBox4 = new System.Windows.Forms.ComboBox();
            comboBox5 = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(416, 28);
            label1.TabIndex = 0;
            label1.Text = "INTERNATIONAL FLIGHT DETAILS:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateTimePicker1.Location = new System.Drawing.Point(12, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(444, 26);
            dateTimePicker1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] {
            "DUBAI",
            "QATAR",
            "SAUDIA",
            "BANGLADESH"});
            comboBox1.Location = new System.Drawing.Point(12, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(182, 27);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "SOURCE";
            // 
            // comboBox2
            // 
            comboBox2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] {
            "ENGLAND",
            "CHINA ",
            "HONGKONG",
            "CANADA"});
            comboBox2.Location = new System.Drawing.Point(12, 137);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(182, 27);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "DESTINATION";
            // 
            // comboBox3
            // 
            comboBox3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] {
            "British Airlines  04:00(DEPARTURE)             11:05(ARRIVAL)       Rs.50000",
            "Emirates          06:00(DEPARTURE)             10:05(ARRIVAL)       Rs.150000",
            "Qatar Airways   08:00(DEPARTURE)             14:05(ARRIVAL)       Rs.55000"});
            comboBox3.Location = new System.Drawing.Point(12, 177);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(444, 27);
            comboBox3.TabIndex = 4;
            comboBox3.Text = "AVAILABLE FLIGHT";
            // 
            // comboBox4
            // 
            comboBox4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] {
            "Vegetarian meal: Rs.450",
            "Non-Vegetarian meal: Rs.500",
            "No meal"});
            comboBox4.Location = new System.Drawing.Point(12, 217);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new System.Drawing.Size(444, 27);
            comboBox4.TabIndex = 5;
            comboBox4.Text = "MEAL PREFERENCE";
            // 
            // comboBox5
            // 
            comboBox5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] {
            "Debit Card",
            "Credit Card",
            "Net Banking"});
            comboBox5.Location = new System.Drawing.Point(12, 312);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new System.Drawing.Size(249, 27);
            comboBox5.TabIndex = 5;
            comboBox5.Text = "MODE OF PAYMENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.Window;
            label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            label2.Location = new System.Drawing.Point(12, 272);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(205, 23);
            label2.TabIndex = 6;
            label2.Text = "MODE OF PAYMENT:";
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            textBox1.Location = new System.Drawing.Point(12, 360);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "CARD NUMBER";
            textBox1.Size = new System.Drawing.Size(124, 26);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            textBox2.Location = new System.Drawing.Point(12, 394);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "EXPIRY DATE";
            textBox2.Size = new System.Drawing.Size(124, 26);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            textBox3.Location = new System.Drawing.Point(12, 428);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "CVV";
            textBox3.Size = new System.Drawing.Size(124, 26);
            textBox3.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            button1.Location = new System.Drawing.Point(337, 460);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(164, 40);
            button1.TabIndex = 13;
            button1.Text = "BOOK TICKET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // Form6
            // 
            BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(535, 525);
            Controls.Add(comboBox5);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox4);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
