using System;
using System.Windows.Forms;
using StudentNameSpace;

/*  ID
 *      DLL Presentation Guide, Kaleb Ehlert, 3/4/2018
 *  Purpose
 *      The purpose of the program is to learn how dlls work and how they can interact with the program.
 *  Form Controls
 *      txtName: Displays the name of the student
 *      txtAge: Displays the age of the student
 *      txtID: Displays the ID of the student
 *      txtSleepAmt: Displays the number of hours the user sleeps
 *      txtAverageSleepAmt: Displays the number of hours most people sleep
 *  Code & Logic
 *      The input is the button press the user can click.
 *      The processing takes the data and sends them to the correct control.
 *      The output is the data of the student created.
 */

namespace EhlertProgram7
{
    public partial class PresentationGUI : Form
    {
        private Student aStudent;

        public PresentationGUI()
        {
            InitializeComponent();
        }

        private void PresentationGUI_LOAD(object sender, EventArgs e)
        {
            aStudent = new Student("123456789", "Maria", "Woo", "CS", "1111");
        }

        private void btnShowStudent_Click(object sender, EventArgs e)
        {
            // Uses Age property defined in the Person class
            aStudent.Age = 25;

            // Calls overridden ToString() in Person class
            txtName.Text = aStudent.ToString();

            // Calls ToString() defined in pbject class
            txtAge.Text = aStudent.Age.ToString();

            // Uses StudentID property in Student class
            txtID.Text = aStudent.StudentId;

            // Calls GetSleepAmt() defined in Student class
            txtSleepAmt.Text = Convert.ToString( aStudent.GetSleepAmt() );

            // Calls method defined in Student class that has calls to base.GetSleepAmt() in Person class
            txtAverageSleepAmt.Text = Convert.ToString( aStudent.CallOverriddenGetSleepAmt() );
        }
    }
}
