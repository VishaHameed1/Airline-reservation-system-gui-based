namespace VISHA_HAMEED
{
    partial class Form5
    {
        // Other designer code ...

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            comboBox5 = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(381, 33);
            label1.TabIndex = 0;
            label1.Text = "DOMESTIC FLIGHT DETAILS:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(13, 59);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(372, 31);
            dateTimePicker1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 8F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "KARACHI", "ISLAMABAD", "LAHORE ", "PESHAWAR" });
            comboBox1.Location = new Point(13, 105);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(202, 27);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "SOURCE";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Times New Roman", 8F, FontStyle.Bold);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "KARACHI", "ISLAMABAD", "LAHORE ", "PESHAWAR" });
            comboBox2.Location = new Point(248, 105);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(202, 27);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "DESTINATION";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Times New Roman", 8F, FontStyle.Bold);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "  Air India   08:00(DEPARTURE)             11:05(ARRIVAL)       Rs.5000", "   IndiGo     14:00(DEPARTURE)             17:05(ARRIVAL)        Rs.5500", "    SpiceJet     19:00(DEPARTURE)             22:05(ARRIVAL)        Rs.6000" });
            comboBox3.Location = new Point(13, 158);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(543, 27);
            comboBox3.TabIndex = 4;
            comboBox3.Text = "AVAILABLE FLIGHT";
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Times New Roman", 8F, FontStyle.Bold);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Vegetarian meal: Rs.350", "Non-Vegetarian meal : Rs.450", "No meal" });
            comboBox4.Location = new Point(13, 219);
            comboBox4.Margin = new Padding(3, 4, 3, 4);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(543, 27);
            comboBox4.TabIndex = 5;
            comboBox4.Text = " MEAL PREFERENCE";
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 9F, FontStyle.Italic);
            textBox1.Location = new Point(13, 368);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "CARD NUMBER";
            textBox1.Size = new Size(137, 28);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 9F, FontStyle.Italic);
            textBox2.Location = new Point(13, 414);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "EXPIRY DATE";
            textBox2.Size = new Size(137, 28);
            textBox2.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Times New Roman", 9F, FontStyle.Italic);
            textBox6.Location = new Point(13, 460);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "CARD NUMBER";
            textBox6.Size = new Size(137, 28);
            textBox6.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.BottomRight;
            button1.Location = new Point(387, 495);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(183, 54);
            button1.TabIndex = 19;
            button1.Text = "BOOK TICKET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Debit Card", "Credit Card", "Net Banking" });
            comboBox5.Location = new Point(13, 321);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(249, 31);
            comboBox5.TabIndex = 20;
            comboBox5.Text = "MODE OF PAYMENT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.BottomRight;
            label3.Location = new Point(10, 286);
            label3.Name = "label3";
            label3.Size = new Size(205, 23);
            label3.TabIndex = 21;
            label3.Text = "MODE OF PAYMENT:";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(591, 562);
            Controls.Add(label3);
            Controls.Add(comboBox5);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox6;
        private Button button1;
        private ComboBox comboBox5;
        private Label label3;
    }
}
