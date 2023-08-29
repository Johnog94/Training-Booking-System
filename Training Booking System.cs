using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//*Year:1MIS1 Masters of science (information systems managment)
//*Course:Business Applications Programming MS806
//*Name:Jonathan Griffey
//*Id No.:13304011
//*Assignment 3: Create a well-designed application for Learn2Prog Ltd, a training company that provides
//programming workshops in locations across Ireland

namespace GRIFFEY_JONATHAN_ASSIGNMENT3_MS806
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            //Application start//
            InitializeComponent();
            //this code allows the enter button to be used for the login as well as using the mouse//
            this.AcceptButton = loginButon;
            //Following code makes sure that everything except the welcome label,password textbox and login button are invisible//
            choosePlanGroupBox.Visible = false;
            exitButon.Visible = false;
            summaryButton.Visible = false;
            bookButton.Visible = false;
            orderOverviewBox.Visible = false;
            summaryBox.Visible = false;



        }
//Declare all variables and constraints//
        
        //course name//
        const string WS1 = "ASP.NET C#", WS2 = "Winforms Apps C#", WS3 = ".NETProg Part1", WS4 = ".NETProg Part2", WS5 = "DigitalDetox";
        //course location
        const string LOC1 = "Cork", LOC2 = "Dublin", LOC3 = "Galway", LOC4 = "Bellmullet", LOC5 = "Limerick", LOC6 = "wexford";
        //course lenght
        const int COURSE1_DAYS = 4, COURSE2_DAYS = 3, COURSE3_DAYS = 4, COURSE4_DAYS = 4, COURSE5_DAYS = 1;
        //course price
        const decimal COURSE1 = 1200m, COURSE2 = 1000m, COURSE3 = 1500m, COURSE4 = 1800m, COURSE5 = 599m;
        //location price
        const decimal CORK = 150m, DUBLIN = 225m, GALWAY = 175m, BELLMULLET = 305m, LIMERICK = 135m, WEXFORD = 89m;
        //meal price
        const decimal FULLMEAL = 39.50m, HALFMEAL = 27.50m, BREAKFAST = 12.50m, NOMEAL = 0.00M;
        //certificate price
        const decimal CERTPRICE = 29.95m, DIGCERT = 0.00m;
        string course_name = "", location_name = "";
        decimal course_cost, location_cost, meal_cost, cert_cost;
        int BookingCount = 0;
        int course_days = 0;
        int passCounter = 0;
        decimal totalcoursesfees = 0m, totaloptionsfees = 0m, totallocationfees = 0m, totalrevenue = 0m;
        


        private void loginButon_Click(object sender, EventArgs e)
        {
            if (passTextbox.Text == "iLoveVisualC#")
            {
                /*if the password is correct the following code displays a welcome message which brings you to the main page once ok is entered,
                it also makes anything related to the login event invisible and everything else visible*/
                MessageBox.Show("Login Succesful, Welcome", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.None);
                choosePlanGroupBox.Visible = true;
                bookButton.Visible = true;
                summaryButton.Visible = true;
                exitButon.Visible = true;
                orderOverviewBox.Visible = false;
                loginButon.Visible = false;
                welcomeLabel.Visible = false;
                passTextbox.Visible = false;
                progImageBox.Visible = false;
                loginLabel.Visible = false;
                noMealRadioButton.Checked = true;
                digitalCertRadioButton.Checked = true;
                summaryButton.Enabled = false;
                bookButton.Enabled = false;
            }
            else
            {
                //this code allows an error message to be shown if an incorrect password is inputed//
                MessageBox.Show("Incorrect Passowrd!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passCounter = passCounter + 1;
                //set the focus back to the login textbox//
                passTextbox.Focus();


            }
            //this declares that if the wrong password is inputed incorrectly 3 times then an attempts reached error appears and the application will close//
            if (passCounter == 3)
            {
                MessageBox.Show("Max amount of attempts Reached", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            //this shows an error message if nothing is inputed in the login textbox//
            if (passTextbox.Text == "")
            {
                MessageBox.Show("Please enter a password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passTextbox.Focus();
            }

            
        }
private void displayButton_Click(object sender, EventArgs e)
        {
            orderOverviewBox.Visible = true;
            bookButton.Enabled = true;
            
            if (selectWorkshopListbox.SelectedIndex != -1)
            {
                course_name = selectWorkshopListbox.SelectedItem.ToString();

                
                //switch statement to allow different variables to be printed for each selection
                switch (selectWorkshopListbox.SelectedIndex)
                {
                    case 0:
                        course_name = WS1;
                        course_days = COURSE1_DAYS;
                        course_cost = COURSE1;
                        break;

                    case 1:
                        course_name = WS2;
                        course_days = COURSE2_DAYS;
                        course_cost = COURSE2;
                        break;

                    case 2:
                        course_name = WS3;
                        course_days = COURSE3_DAYS;
                        course_cost = COURSE3;
                        break;

                    case 3:
                        course_name = WS4;
                        course_days = COURSE4_DAYS;
                        course_cost = COURSE4;
                        break;

                    case 4:
                        course_name = WS5;
                        course_days = COURSE5_DAYS;
                        course_cost = COURSE5;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please Select Workshop", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (selectLocationListBox.SelectedIndex != -1)
            {
                location_name = selectLocationListBox.SelectedItem.ToString();

                //switch statement to allow different variables to be printed for each selection
                switch (selectLocationListBox.SelectedIndex)
                {
                    case 0:
                        location_name = LOC1;
                        location_cost = CORK;
                        break;

                    case 1:
                        location_name = LOC2;
                        location_cost = DUBLIN;
                        break;

                    case 2:
                        location_name = LOC3;
                        location_cost = GALWAY;
                        break;

                    case 3:
                        location_name = LOC4;
                        location_cost = BELLMULLET;
                        break;

                    case 4:
                        location_name = LOC5;
                        location_cost = LIMERICK;
                        break;

                    case 5:
                        location_name = LOC6;
                        location_cost = WEXFORD;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please Select A Location","Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //if else if statements for meal choice radio buttons
            if (fullBoardRadioButton.Checked == true)

                meal_cost = FULLMEAL;

            else if (halfBoardRadioButton.Checked == true)

                meal_cost = HALFMEAL;

            else if (breakfastRadioButton.Checked == true)

                meal_cost = BREAKFAST;

            else if (noMealRadioButton.Checked == true)

                meal_cost = NOMEAL;
            else
            {
                MessageBox.Show("Please Select A Meal Option", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if else if statments for certificate radio buttons
            if (printedCertRadioButton.Checked == true)

                cert_cost = CERTPRICE;

            else if (digitalCertRadioButton.Checked == true)

                cert_cost = DIGCERT;

            else
            {
                MessageBox.Show("Please Select An Option", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*this code firstly makes the order overview box visible before applying the math logic to the diplay button */
            orderOverviewBox.Visible = true;
            certificateInputLabel.Text = cert_cost.ToString("C2");
            courseCostInputLabel.Text = course_cost.ToString("C2");
            locationInputLabel.Text = location_name.ToString();
            mealInputLabel.Text = meal_cost.ToString("C2");
            courseNameInputLabel.Text = course_name.ToString();
            totalWorkshopPriceLabel.Text = (course_cost + location_cost *course_days + meal_cost * course_days + cert_cost).ToString("C");

            

        }
private void bookButton_Click(object sender, EventArgs e)
        {
            
            //this code shows a confirm booking message box with yes or no options//
            DialogResult bookingconfirmed = MessageBox.Show(" Do You Wish to Confirm this Booking?", "Confirm Booking?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(bookingconfirmed == DialogResult.Yes)
            {
                //if yes is selected,another message box shows a conformation of booking with selected options//
                MessageBox.Show("Your booking has been conifrmed." + "\n" +
                    "Course:" + courseNameInputLabel.Text + "\n" +
                    "Location:" + locationInputLabel.Text + "\n" +
                    "Meal Plan:" + mealInputLabel.Text + "\n" +
                    "Certificate:" + certificateInputLabel.Text + "\n" +
                    "Total Cost:" + totalWorkshopPriceLabel.Text);
            }
            //if no is selected an error message displays prompting the user to select options//
            else if (bookingconfirmed == DialogResult.No)
            {
                MessageBox.Show("Please Select Options To Proceed with Booking", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //summary button running totals
            BookingCount++;
            totalcoursesfees += course_cost;
            totallocationfees += location_cost;
            totaloptionsfees += meal_cost + cert_cost;
            totalrevenue += (course_cost + location_cost * course_days + meal_cost * course_days + cert_cost);
            summaryButton.Enabled = true;


        }


        private void summaryButton_Click(object sender, EventArgs e)
        {
            decimal avgRevenue;
            summaryBox.Visible = true;
            orderOverviewBox.Visible = false;
            //calculate running totals for summary button
            totalBookingInputLabel.Text = BookingCount.ToString();
            regFeesInputLabel.Text = totalcoursesfees.ToString("C2");
            lodgingFeesInputLabel.Text = totallocationfees.ToString("C2");
            valueOptionsInputLabel.Text = totaloptionsfees.ToString("C2");
            totalRevInputLabel.Text = totalrevenue.ToString("C2");
            avgRevenue = totalrevenue / BookingCount;
            avgRevInputLabel.Text = avgRevenue.ToString("C2");

        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            /*the code for the clear button makes sure all selections are cleared on listboxes
             and panels. it also sets default selections for radio buttons and disenables the book and summary buttons*/
            
            fullBoardRadioButton.Checked = false;
            halfBoardRadioButton.Checked = false;
            breakfastRadioButton.Checked = false;
            noMealRadioButton.Checked = false;
            printedCertRadioButton.Checked = false;
            digitalCertRadioButton.Checked = false;
            selectWorkshopListbox.ClearSelected();
            selectLocationListBox.ClearSelected();
            orderOverviewBox.Visible = false;
            summaryBox.Visible = false;
            bookButton.Enabled = false;
            summaryButton.Enabled = false;
        }



        private void exitButon_Click(object sender, EventArgs e)
        {
            //this closes the application//
            this.Close();
        }



    }
}
