namespace VISHA_HAMEED
{
    partial class int_booking : bookingBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public int_booking()
        {
            InitializeComponent();

        }
        private string Text { get; set; }

        // Add the ClientSize property here
        private System.Drawing.Size ClientSize { get; set; }

        // Add the AutoScaleMode property here
        private System.Windows.Forms.AutoScaleMode AutoScaleMode { get; set; }



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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "int_booking";
        }

        #endregion
    }
}
