using System;
using System.IO;
using System.Windows.Forms;

namespace VISHA_HAMEED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any of the text boxes are empty
            if (string.IsNullOrWhiteSpace(textBox5.Text) || // Name
                string.IsNullOrWhiteSpace(textBox4.Text) || // Email
                string.IsNullOrWhiteSpace(textBox3.Text) || // Gender
                string.IsNullOrWhiteSpace(textBox2.Text) || // Contact No.
                string.IsNullOrWhiteSpace(textBox1.Text))   // Passport number
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            // Create an instance of the Passenger class
            Passenger passengerInstance = new Passenger
            {
                Name = textBox5.Text,
                Email = textBox4.Text,
                Gender = textBox3.Text,
                ContactNo = textBox2.Text,
                PassportNo = textBox1.Text
            };

            // Display collected details
            passengerInstance.DisplayDetails();

            // Save passenger details to a file
            passengerInstance.SaveToFile();

            // Create an instance of Form2
            Form2 form2 = new Form2();

            // Show Form2
            form2.Show();
            this.Hide();
        }
    }

    // Define the Person base class
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }

        public virtual void DisplayDetails()
        {
            MessageBox.Show("Person details\n" +
                            "Name: " + Name + "\n" +
                            "Gender: " + Gender + "\n" +
                            "Email ID: " + Email + "\n" +
                            "Contact No.: " + ContactNo,
                            "Person Details",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        public virtual void SaveToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("person_details.txt", true))
                {
                    writer.WriteLine("Name: " + Name);
                    writer.WriteLine("Gender: " + Gender);
                    writer.WriteLine("Email ID: " + Email);
                    writer.WriteLine("Contact No.: " + ContactNo);
                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving person details: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }

    // Define the Passenger class that inherits from Person
    public class Passenger : Person
    {
        public string PassportNo { get; set; }

        public override void DisplayDetails()
        {
            MessageBox.Show("Passenger details\n" +
                            "Name: " + Name + "\n" +
                            "Gender: " + Gender + "\n" +
                            "Email ID: " + Email + "\n" +
                            "Contact No.: " + ContactNo + "\n" +
                            "Passport number: " + PassportNo,
                            "Passenger Details",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        public override void SaveToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("passenger_details.txt", true))
                {
                    writer.WriteLine("Name: " + Name);
                    writer.WriteLine("Gender: " + Gender);
                    writer.WriteLine("Email ID: " + Email);
                    writer.WriteLine("Contact No.: " + ContactNo);
                    writer.WriteLine("Passport number: " + PassportNo);
                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving passenger details: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
