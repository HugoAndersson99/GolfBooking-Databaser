using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolfBooking
{
    public partial class LoginView : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        GolfUser GolfUser;
        Dictionary<int, GolfUser> golfUsers = new Dictionary<int, GolfUser>();
        Dictionary<int, GolfClub> golfClubs = new Dictionary<int, GolfClub>();
        public LoginView()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Images/Golf1.jpg");
            LogInPanel.BringToFront();
            Run();
        }
        public void Run()
        {
            golfUsers = databaseConnection.GetGolfUsers();
            golfClubs = databaseConnection.GetClubs();
            PopulateMembershipBoxes();
        }
        private void PopulateMembershipBoxes()
        {
            yearMembershipBox.Items.Clear();
            monthMembershipBox.Items.Clear();
            foreach (GolfClub club in golfClubs.Values)
            {
                yearMembershipBox.Items.Add(club.ClubName);
                monthMembershipBox.Items.Add(club.ClubName);
            }
        }

        public void UpdateUsers()
        {
            golfUsers.Clear();
            golfUsers = databaseConnection.GetGolfUsers();
        }

        private void registerNewUserButton_Click(object sender, EventArgs e)
        {
            registerPanel.BringToFront();
        }
        public void registerNewUser()
        {
            string email = emailTextBox.Text;
            string password = registerPasswordTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;

            GolfUser newGolfUser = databaseConnection.AddNewGolfUser(email, password, firstName, lastName);
            golfUsers.Add(newGolfUser.GolfUserID, newGolfUser);
            GolfUser = newGolfUser;
        }
        private void AddUserToMonthClub(GolfUser user)
        {
            string monthClub = monthMembershipBox.SelectedItem.ToString();
            string yearClub = yearMembershipBox.SelectedItem.ToString();

            if (monthClub == yearClub)
            {
                MessageBox.Show("Du måste välja 2 olika klubbar!");
                return;
            }

            foreach (GolfClub golfClub in golfClubs.Values)
            {
                if (golfClub.ClubName == monthClub)
                {
                    databaseConnection.AssignUserToClub(user, golfClub.ClubID);
                }
            }
        }
        private void AddUserToYearClub(GolfUser user)
        {
            string monthClub = monthMembershipBox.SelectedItem.ToString();
            string yearClub = yearMembershipBox.SelectedItem.ToString();

            if (monthClub == yearClub)
            {
                MessageBox.Show("Du måste välja 2 olika klubbar!");
                return;
            }
            foreach (GolfClub golfClub in golfClubs.Values)
            {
                if (golfClub.ClubName == yearClub)
                {
                    databaseConnection.AssignUserToClub(user, golfClub.ClubID);
                }
            }
        }

        private void registerUserButton_Click(object sender, EventArgs e)
        {


            if (firstNameTextBox.Text == null)
            {
                MessageBox.Show("You must enter your first name!");
                return;
            }
            if (lastNameTextBox.Text == null)
            {
                MessageBox.Show("You must enter your last name!");
                return;
            }
            if (emailTextBox.Text == null)
            {
                MessageBox.Show("You must enter a email!");
                return;
            }
            if (registerPasswordTextBox.Text == null)
            {
                MessageBox.Show("You must enter a password!");
                return;
            }
            foreach (GolfUser golfUser in golfUsers.Values)
            {
                if (emailTextBox.Text == golfUser.Email)
                {
                    MessageBox.Show("Det finns redan en användare med denna emailen! Prova igen");
                    emailTextBox.Clear();
                    return;
                }
            }
            registerNewUser();
            UpdateUsers();
            registerPanel.SendToBack();
            selectMembershipPanel.Visible = true;
            selectMembershipPanel.BringToFront();

        }
        private bool CheckLogIn()
        {
            foreach (GolfUser golfUser in golfUsers.Values)
            {
                if (GolfIdTextBox.Text == golfUser.Email)
                {
                    return true;
                }
            }
            return false;
        }


        private void logInButton_Click(object sender, EventArgs e)
        {
            if (GolfIdTextBox != null && passwordTextBox != null)
            {
                bool logIn = CheckLogIn();
                if (logIn == true)
                {
                    foreach (GolfUser golfUser in golfUsers.Values)
                    {
                        if (GolfIdTextBox.Text == golfUser.Email && passwordTextBox.Text == golfUser.UserPassword)
                        {
                            MainPage mainPage = new MainPage(golfUser, this);
                            GolfIdTextBox.Clear();
                            passwordTextBox.Clear();
                            mainPage.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ogiltlig Email / Lösenord");
                    passwordTextBox.Clear();
                }
                // MainPage mainPage = new MainPage();
                // mainPage.Show();
                // this.Hide();
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (monthMembershipBox != null && yearMembershipBox != null)
            {
                AddUserToMonthClub(GolfUser);
                AddUserToYearClub(GolfUser);
                selectMembershipPanel.Visible = false;
                LogInPanel.BringToFront();
            }
            else
            {
                MessageBox.Show("Du måste välja i båda boxarna!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yearMembershipBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                int selectedIndex = yearMembershipBox.SelectedIndex;
                monthMembershipBox.Items.RemoveAt(selectedIndex);
            }
            catch
            {
                MessageBox.Show("Vänligen klicka ladda om knappen!");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

            PopulateMembershipBoxes();
        }
    }
}
