namespace GolfBooking
{
    partial class MainPage
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
            regRoundPanel = new Panel();
            registerRoundButton = new Button();
            courseComboBox = new ComboBox();
            clubComboBox = new ComboBox();
            label66 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            par18Label = new Label();
            panel2 = new Panel();
            par17Label = new Label();
            label9 = new Label();
            par16Label = new Label();
            par1Label = new Label();
            par15Label = new Label();
            par2Label = new Label();
            par14Label = new Label();
            par7Label = new Label();
            par13Label = new Label();
            par3Label = new Label();
            par12Label = new Label();
            par4Label = new Label();
            par11Label = new Label();
            par5Label = new Label();
            par10Label = new Label();
            par6Label = new Label();
            par9Label = new Label();
            par8Label = new Label();
            panel5 = new Panel();
            hål18Label = new Label();
            panel6 = new Panel();
            hål17Label = new Label();
            label6 = new Label();
            hål16Label = new Label();
            hål9Label = new Label();
            hål6Label = new Label();
            hål8Label = new Label();
            hål15Label = new Label();
            hål5Label = new Label();
            hål1Label = new Label();
            hål10Label = new Label();
            hål14Label = new Label();
            hål4Label = new Label();
            hål2Label = new Label();
            hål11Label = new Label();
            hål13Label = new Label();
            hål3Label = new Label();
            hål7Label = new Label();
            hål12Label = new Label();
            panel9 = new Panel();
            hål10SlagBox = new TextBox();
            hål18SlagBox = new TextBox();
            hål9SlagBox = new TextBox();
            hål8SlagBox = new TextBox();
            hål14SlagBox = new TextBox();
            hål4SlagBox = new TextBox();
            hål16SlagBox = new TextBox();
            hål6SlagBox = new TextBox();
            hål17SlagBox = new TextBox();
            hål7SlagBox = new TextBox();
            hål12SlagBox = new TextBox();
            hål2SlagBox = new TextBox();
            hål15SlagBox = new TextBox();
            hål5SlagBox = new TextBox();
            hål13SlagBox = new TextBox();
            hål11SlagBox = new TextBox();
            hål3SlagBox = new TextBox();
            hål1SlagBox = new TextBox();
            panel10 = new Panel();
            label8 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            regRoundButton = new Button();
            userInfoLabel = new Label();
            userHcpInfoLabel = new Label();
            prevRoundButton = new Button();
            logOutButton = new Button();
            userHcpLabel = new Label();
            pastRoundsPanel = new Panel();
            removeButton = new Button();
            label4 = new Label();
            clubsListBox = new ListBox();
            label3 = new Label();
            bestRoundsListBox = new ListBox();
            label68 = new Label();
            label67 = new Label();
            roundsListbox = new ListBox();
            label123 = new Label();
            clubInfoButton = new Button();
            clubInfoPanel = new Panel();
            showHandicapButton = new Button();
            showAllMembersButton = new Button();
            viewAllButton = new Button();
            searchButton = new Button();
            clubSearchTextBox = new TextBox();
            clubListBox = new ListBox();
            label10 = new Label();
            clubMembersListBox = new ListBox();
            label52 = new Label();
            label53 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            regRoundPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            pastRoundsPanel.SuspendLayout();
            clubInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // regRoundPanel
            // 
            regRoundPanel.Controls.Add(registerRoundButton);
            regRoundPanel.Controls.Add(courseComboBox);
            regRoundPanel.Controls.Add(clubComboBox);
            regRoundPanel.Controls.Add(label66);
            regRoundPanel.Controls.Add(label7);
            regRoundPanel.Controls.Add(panel1);
            regRoundPanel.Controls.Add(panel5);
            regRoundPanel.Controls.Add(panel9);
            regRoundPanel.Controls.Add(label5);
            regRoundPanel.Controls.Add(label2);
            regRoundPanel.Controls.Add(label1);
            regRoundPanel.Location = new Point(95, 78);
            regRoundPanel.Name = "regRoundPanel";
            regRoundPanel.Size = new Size(640, 399);
            regRoundPanel.TabIndex = 0;
            // 
            // registerRoundButton
            // 
            registerRoundButton.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            registerRoundButton.Location = new Point(455, 290);
            registerRoundButton.Name = "registerRoundButton";
            registerRoundButton.Size = new Size(159, 38);
            registerRoundButton.TabIndex = 9;
            registerRoundButton.Text = "Registrera Rond";
            registerRoundButton.UseVisualStyleBackColor = true;
            registerRoundButton.Click += registerRoundButton_Click;
            // 
            // courseComboBox
            // 
            courseComboBox.FormattingEnabled = true;
            courseComboBox.Location = new Point(315, 70);
            courseComboBox.Name = "courseComboBox";
            courseComboBox.Size = new Size(162, 23);
            courseComboBox.TabIndex = 34;
            courseComboBox.SelectedIndexChanged += courseComboBox_SelectedIndexChanged;
            // 
            // clubComboBox
            // 
            clubComboBox.FormattingEnabled = true;
            clubComboBox.Location = new Point(69, 68);
            clubComboBox.Name = "clubComboBox";
            clubComboBox.Size = new Size(177, 23);
            clubComboBox.TabIndex = 33;
            clubComboBox.SelectedIndexChanged += clubComboBox_SelectedIndexChanged;
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label66.Location = new Point(252, 59);
            label66.Name = "label66";
            label66.Size = new Size(57, 34);
            label66.TabIndex = 32;
            label66.Text = "Bana";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(7, 299);
            label7.Name = "label7";
            label7.Size = new Size(394, 25);
            label7.TabIndex = 31;
            label7.Text = "Vänligen fyll i antal spelade slag per hål med siffra i scorekortet.";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(par18Label);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(par17Label);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(par16Label);
            panel1.Controls.Add(par1Label);
            panel1.Controls.Add(par15Label);
            panel1.Controls.Add(par2Label);
            panel1.Controls.Add(par14Label);
            panel1.Controls.Add(par7Label);
            panel1.Controls.Add(par13Label);
            panel1.Controls.Add(par3Label);
            panel1.Controls.Add(par12Label);
            panel1.Controls.Add(par4Label);
            panel1.Controls.Add(par11Label);
            panel1.Controls.Add(par5Label);
            panel1.Controls.Add(par10Label);
            panel1.Controls.Add(par6Label);
            panel1.Controls.Add(par9Label);
            panel1.Controls.Add(par8Label);
            panel1.Location = new Point(13, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 30);
            panel1.TabIndex = 29;
            // 
            // par18Label
            // 
            par18Label.AutoSize = true;
            par18Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par18Label.Location = new Point(577, 8);
            par18Label.Name = "par18Label";
            par18Label.Size = new Size(12, 20);
            par18Label.TabIndex = 49;
            par18Label.Text = ".";
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(592, 30);
            panel2.TabIndex = 20;
            // 
            // par17Label
            // 
            par17Label.AutoSize = true;
            par17Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par17Label.Location = new Point(546, 8);
            par17Label.Name = "par17Label";
            par17Label.Size = new Size(12, 20);
            par17Label.TabIndex = 50;
            par17Label.Text = ".";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 8);
            label9.Name = "label9";
            label9.Size = new Size(27, 20);
            label9.TabIndex = 15;
            label9.Text = "Par";
            // 
            // par16Label
            // 
            par16Label.AutoSize = true;
            par16Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par16Label.Location = new Point(515, 8);
            par16Label.Name = "par16Label";
            par16Label.Size = new Size(12, 20);
            par16Label.TabIndex = 51;
            par16Label.Text = ".";
            // 
            // par1Label
            // 
            par1Label.AutoSize = true;
            par1Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par1Label.Location = new Point(53, 8);
            par1Label.Name = "par1Label";
            par1Label.Size = new Size(12, 20);
            par1Label.TabIndex = 44;
            par1Label.Text = ".";
            // 
            // par15Label
            // 
            par15Label.AutoSize = true;
            par15Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par15Label.Location = new Point(484, 8);
            par15Label.Name = "par15Label";
            par15Label.Size = new Size(12, 20);
            par15Label.TabIndex = 52;
            par15Label.Text = ".";
            // 
            // par2Label
            // 
            par2Label.AutoSize = true;
            par2Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par2Label.Location = new Point(84, 8);
            par2Label.Name = "par2Label";
            par2Label.Size = new Size(12, 20);
            par2Label.TabIndex = 48;
            par2Label.Text = ".";
            // 
            // par14Label
            // 
            par14Label.AutoSize = true;
            par14Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par14Label.Location = new Point(453, 8);
            par14Label.Name = "par14Label";
            par14Label.Size = new Size(12, 20);
            par14Label.TabIndex = 53;
            par14Label.Text = ".";
            // 
            // par7Label
            // 
            par7Label.AutoSize = true;
            par7Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par7Label.Location = new Point(239, 8);
            par7Label.Name = "par7Label";
            par7Label.Size = new Size(12, 20);
            par7Label.TabIndex = 56;
            par7Label.Text = ".";
            // 
            // par13Label
            // 
            par13Label.AutoSize = true;
            par13Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par13Label.Location = new Point(422, 8);
            par13Label.Name = "par13Label";
            par13Label.Size = new Size(12, 20);
            par13Label.TabIndex = 54;
            par13Label.Text = ".";
            // 
            // par3Label
            // 
            par3Label.AutoSize = true;
            par3Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par3Label.Location = new Point(115, 8);
            par3Label.Name = "par3Label";
            par3Label.Size = new Size(12, 20);
            par3Label.TabIndex = 45;
            par3Label.Text = ".";
            // 
            // par12Label
            // 
            par12Label.AutoSize = true;
            par12Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par12Label.Location = new Point(391, 8);
            par12Label.Name = "par12Label";
            par12Label.Size = new Size(12, 20);
            par12Label.TabIndex = 55;
            par12Label.Text = ".";
            // 
            // par4Label
            // 
            par4Label.AutoSize = true;
            par4Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par4Label.Location = new Point(146, 8);
            par4Label.Name = "par4Label";
            par4Label.Size = new Size(12, 20);
            par4Label.TabIndex = 46;
            par4Label.Text = ".";
            // 
            // par11Label
            // 
            par11Label.AutoSize = true;
            par11Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par11Label.Location = new Point(360, 8);
            par11Label.Name = "par11Label";
            par11Label.Size = new Size(12, 20);
            par11Label.TabIndex = 57;
            par11Label.Text = ".";
            // 
            // par5Label
            // 
            par5Label.AutoSize = true;
            par5Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par5Label.Location = new Point(177, 8);
            par5Label.Name = "par5Label";
            par5Label.Size = new Size(12, 20);
            par5Label.TabIndex = 47;
            par5Label.Text = ".";
            // 
            // par10Label
            // 
            par10Label.AutoSize = true;
            par10Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par10Label.Location = new Point(329, 8);
            par10Label.Name = "par10Label";
            par10Label.Size = new Size(12, 20);
            par10Label.TabIndex = 58;
            par10Label.Text = ".";
            // 
            // par6Label
            // 
            par6Label.AutoSize = true;
            par6Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par6Label.Location = new Point(208, 8);
            par6Label.Name = "par6Label";
            par6Label.Size = new Size(12, 20);
            par6Label.TabIndex = 61;
            par6Label.Text = ".";
            // 
            // par9Label
            // 
            par9Label.AutoSize = true;
            par9Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par9Label.Location = new Point(301, 8);
            par9Label.Name = "par9Label";
            par9Label.Size = new Size(12, 20);
            par9Label.TabIndex = 59;
            par9Label.Text = ".";
            // 
            // par8Label
            // 
            par8Label.AutoSize = true;
            par8Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            par8Label.Location = new Point(270, 8);
            par8Label.Name = "par8Label";
            par8Label.Size = new Size(12, 20);
            par8Label.TabIndex = 60;
            par8Label.Text = ".";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(hål18Label);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(hål17Label);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(hål16Label);
            panel5.Controls.Add(hål9Label);
            panel5.Controls.Add(hål6Label);
            panel5.Controls.Add(hål8Label);
            panel5.Controls.Add(hål15Label);
            panel5.Controls.Add(hål5Label);
            panel5.Controls.Add(hål1Label);
            panel5.Controls.Add(hål10Label);
            panel5.Controls.Add(hål14Label);
            panel5.Controls.Add(hål4Label);
            panel5.Controls.Add(hål2Label);
            panel5.Controls.Add(hål11Label);
            panel5.Controls.Add(hål13Label);
            panel5.Controls.Add(hål3Label);
            panel5.Controls.Add(hål7Label);
            panel5.Controls.Add(hål12Label);
            panel5.Location = new Point(13, 159);
            panel5.Name = "panel5";
            panel5.Size = new Size(612, 30);
            panel5.TabIndex = 27;
            // 
            // hål18Label
            // 
            hål18Label.AutoSize = true;
            hål18Label.BorderStyle = BorderStyle.FixedSingle;
            hål18Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål18Label.Location = new Point(577, 5);
            hål18Label.Name = "hål18Label";
            hål18Label.Size = new Size(22, 22);
            hål18Label.TabIndex = 67;
            hål18Label.Text = "18";
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 31);
            panel6.Name = "panel6";
            panel6.Size = new Size(592, 30);
            panel6.TabIndex = 20;
            // 
            // hål17Label
            // 
            hål17Label.AutoSize = true;
            hål17Label.BorderStyle = BorderStyle.FixedSingle;
            hål17Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål17Label.Location = new Point(546, 5);
            hål17Label.Name = "hål17Label";
            hål17Label.Size = new Size(21, 22);
            hål17Label.TabIndex = 68;
            hål17Label.Text = "17";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 8);
            label6.Name = "label6";
            label6.Size = new Size(25, 20);
            label6.TabIndex = 12;
            label6.Text = "Hål";
            label6.Click += label6_Click;
            // 
            // hål16Label
            // 
            hål16Label.AutoSize = true;
            hål16Label.BorderStyle = BorderStyle.FixedSingle;
            hål16Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål16Label.Location = new Point(515, 5);
            hål16Label.Name = "hål16Label";
            hål16Label.Size = new Size(22, 22);
            hål16Label.TabIndex = 69;
            hål16Label.Text = "16";
            // 
            // hål9Label
            // 
            hål9Label.AutoSize = true;
            hål9Label.BorderStyle = BorderStyle.FixedSingle;
            hål9Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål9Label.Location = new Point(301, 5);
            hål9Label.Name = "hål9Label";
            hål9Label.Size = new Size(18, 22);
            hål9Label.TabIndex = 77;
            hål9Label.Text = "9";
            // 
            // hål6Label
            // 
            hål6Label.AutoSize = true;
            hål6Label.BorderStyle = BorderStyle.FixedSingle;
            hål6Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål6Label.Location = new Point(208, 5);
            hål6Label.Name = "hål6Label";
            hål6Label.Size = new Size(18, 22);
            hål6Label.TabIndex = 79;
            hål6Label.Text = "6";
            // 
            // hål8Label
            // 
            hål8Label.AutoSize = true;
            hål8Label.BorderStyle = BorderStyle.FixedSingle;
            hål8Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål8Label.Location = new Point(270, 5);
            hål8Label.Name = "hål8Label";
            hål8Label.Size = new Size(18, 22);
            hål8Label.TabIndex = 78;
            hål8Label.Text = "8";
            // 
            // hål15Label
            // 
            hål15Label.AutoSize = true;
            hål15Label.BorderStyle = BorderStyle.FixedSingle;
            hål15Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål15Label.Location = new Point(484, 5);
            hål15Label.Name = "hål15Label";
            hål15Label.Size = new Size(22, 22);
            hål15Label.TabIndex = 70;
            hål15Label.Text = "15";
            // 
            // hål5Label
            // 
            hål5Label.AutoSize = true;
            hål5Label.BorderStyle = BorderStyle.FixedSingle;
            hål5Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål5Label.Location = new Point(177, 5);
            hål5Label.Name = "hål5Label";
            hål5Label.Size = new Size(18, 22);
            hål5Label.TabIndex = 65;
            hål5Label.Text = "5";
            // 
            // hål1Label
            // 
            hål1Label.AutoSize = true;
            hål1Label.BorderStyle = BorderStyle.FixedSingle;
            hål1Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål1Label.Location = new Point(53, 5);
            hål1Label.Name = "hål1Label";
            hål1Label.Size = new Size(15, 22);
            hål1Label.TabIndex = 62;
            hål1Label.Text = "1";
            // 
            // hål10Label
            // 
            hål10Label.AutoSize = true;
            hål10Label.BorderStyle = BorderStyle.FixedSingle;
            hål10Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål10Label.Location = new Point(329, 5);
            hål10Label.Name = "hål10Label";
            hål10Label.Size = new Size(22, 22);
            hål10Label.TabIndex = 76;
            hål10Label.Text = "10";
            // 
            // hål14Label
            // 
            hål14Label.AutoSize = true;
            hål14Label.BorderStyle = BorderStyle.FixedSingle;
            hål14Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål14Label.Location = new Point(453, 5);
            hål14Label.Name = "hål14Label";
            hål14Label.Size = new Size(22, 22);
            hål14Label.TabIndex = 71;
            hål14Label.Text = "14";
            // 
            // hål4Label
            // 
            hål4Label.AutoSize = true;
            hål4Label.BorderStyle = BorderStyle.FixedSingle;
            hål4Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål4Label.Location = new Point(146, 5);
            hål4Label.Name = "hål4Label";
            hål4Label.Size = new Size(18, 22);
            hål4Label.TabIndex = 64;
            hål4Label.Text = "4";
            // 
            // hål2Label
            // 
            hål2Label.AutoSize = true;
            hål2Label.BorderStyle = BorderStyle.FixedSingle;
            hål2Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål2Label.Location = new Point(84, 5);
            hål2Label.Name = "hål2Label";
            hål2Label.Size = new Size(18, 22);
            hål2Label.TabIndex = 66;
            hål2Label.Text = "2";
            // 
            // hål11Label
            // 
            hål11Label.AutoSize = true;
            hål11Label.BorderStyle = BorderStyle.FixedSingle;
            hål11Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål11Label.Location = new Point(360, 5);
            hål11Label.Name = "hål11Label";
            hål11Label.Size = new Size(19, 22);
            hål11Label.TabIndex = 75;
            hål11Label.Text = "11";
            // 
            // hål13Label
            // 
            hål13Label.AutoSize = true;
            hål13Label.BorderStyle = BorderStyle.FixedSingle;
            hål13Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål13Label.Location = new Point(422, 5);
            hål13Label.Name = "hål13Label";
            hål13Label.Size = new Size(22, 22);
            hål13Label.TabIndex = 72;
            hål13Label.Text = "13";
            // 
            // hål3Label
            // 
            hål3Label.AutoSize = true;
            hål3Label.BorderStyle = BorderStyle.FixedSingle;
            hål3Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål3Label.Location = new Point(115, 5);
            hål3Label.Name = "hål3Label";
            hål3Label.Size = new Size(18, 22);
            hål3Label.TabIndex = 63;
            hål3Label.Text = "3";
            // 
            // hål7Label
            // 
            hål7Label.AutoSize = true;
            hål7Label.BorderStyle = BorderStyle.FixedSingle;
            hål7Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål7Label.Location = new Point(239, 5);
            hål7Label.Name = "hål7Label";
            hål7Label.Size = new Size(17, 22);
            hål7Label.TabIndex = 74;
            hål7Label.Text = "7";
            // 
            // hål12Label
            // 
            hål12Label.AutoSize = true;
            hål12Label.BorderStyle = BorderStyle.FixedSingle;
            hål12Label.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hål12Label.Location = new Point(391, 5);
            hål12Label.Name = "hål12Label";
            hål12Label.Size = new Size(22, 22);
            hål12Label.TabIndex = 73;
            hål12Label.Text = "12";
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(hål10SlagBox);
            panel9.Controls.Add(hål18SlagBox);
            panel9.Controls.Add(hål9SlagBox);
            panel9.Controls.Add(hål8SlagBox);
            panel9.Controls.Add(hål14SlagBox);
            panel9.Controls.Add(hål4SlagBox);
            panel9.Controls.Add(hål16SlagBox);
            panel9.Controls.Add(hål6SlagBox);
            panel9.Controls.Add(hål17SlagBox);
            panel9.Controls.Add(hål7SlagBox);
            panel9.Controls.Add(hål12SlagBox);
            panel9.Controls.Add(hål2SlagBox);
            panel9.Controls.Add(hål15SlagBox);
            panel9.Controls.Add(hål5SlagBox);
            panel9.Controls.Add(hål13SlagBox);
            panel9.Controls.Add(hål11SlagBox);
            panel9.Controls.Add(hål3SlagBox);
            panel9.Controls.Add(hål1SlagBox);
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(label8);
            panel9.Location = new Point(13, 222);
            panel9.Name = "panel9";
            panel9.Size = new Size(612, 30);
            panel9.TabIndex = 23;
            // 
            // hål10SlagBox
            // 
            hål10SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål10SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål10SlagBox.Location = new Point(329, 3);
            hål10SlagBox.Name = "hål10SlagBox";
            hål10SlagBox.Size = new Size(26, 23);
            hål10SlagBox.TabIndex = 41;
            // 
            // hål18SlagBox
            // 
            hål18SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål18SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål18SlagBox.Location = new Point(577, 3);
            hål18SlagBox.Name = "hål18SlagBox";
            hål18SlagBox.Size = new Size(26, 23);
            hål18SlagBox.TabIndex = 45;
            // 
            // hål9SlagBox
            // 
            hål9SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål9SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål9SlagBox.Location = new Point(300, 3);
            hål9SlagBox.Name = "hål9SlagBox";
            hål9SlagBox.Size = new Size(26, 23);
            hål9SlagBox.TabIndex = 40;
            // 
            // hål8SlagBox
            // 
            hål8SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål8SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål8SlagBox.Location = new Point(271, 3);
            hål8SlagBox.Name = "hål8SlagBox";
            hål8SlagBox.Size = new Size(26, 23);
            hål8SlagBox.TabIndex = 37;
            // 
            // hål14SlagBox
            // 
            hål14SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål14SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål14SlagBox.Location = new Point(452, 3);
            hål14SlagBox.Name = "hål14SlagBox";
            hål14SlagBox.Size = new Size(26, 23);
            hål14SlagBox.TabIndex = 41;
            // 
            // hål4SlagBox
            // 
            hål4SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål4SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål4SlagBox.Location = new Point(146, 3);
            hål4SlagBox.Name = "hål4SlagBox";
            hål4SlagBox.Size = new Size(26, 23);
            hål4SlagBox.TabIndex = 33;
            // 
            // hål16SlagBox
            // 
            hål16SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål16SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål16SlagBox.Location = new Point(514, 3);
            hål16SlagBox.Name = "hål16SlagBox";
            hål16SlagBox.Size = new Size(26, 23);
            hål16SlagBox.TabIndex = 43;
            // 
            // hål6SlagBox
            // 
            hål6SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål6SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål6SlagBox.Location = new Point(208, 3);
            hål6SlagBox.Name = "hål6SlagBox";
            hål6SlagBox.Size = new Size(26, 23);
            hål6SlagBox.TabIndex = 35;
            // 
            // hål17SlagBox
            // 
            hål17SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål17SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål17SlagBox.Location = new Point(546, 3);
            hål17SlagBox.Name = "hål17SlagBox";
            hål17SlagBox.Size = new Size(26, 23);
            hål17SlagBox.TabIndex = 44;
            // 
            // hål7SlagBox
            // 
            hål7SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål7SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål7SlagBox.Location = new Point(240, 3);
            hål7SlagBox.Name = "hål7SlagBox";
            hål7SlagBox.Size = new Size(26, 23);
            hål7SlagBox.TabIndex = 36;
            // 
            // hål12SlagBox
            // 
            hål12SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål12SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål12SlagBox.Location = new Point(389, 3);
            hål12SlagBox.Name = "hål12SlagBox";
            hål12SlagBox.Size = new Size(26, 23);
            hål12SlagBox.TabIndex = 39;
            // 
            // hål2SlagBox
            // 
            hål2SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål2SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål2SlagBox.Location = new Point(83, 3);
            hål2SlagBox.Name = "hål2SlagBox";
            hål2SlagBox.Size = new Size(26, 23);
            hål2SlagBox.TabIndex = 31;
            hål2SlagBox.TextChanged += textBox2_TextChanged;
            // 
            // hål15SlagBox
            // 
            hål15SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål15SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål15SlagBox.Location = new Point(483, 3);
            hål15SlagBox.Name = "hål15SlagBox";
            hål15SlagBox.Size = new Size(26, 23);
            hål15SlagBox.TabIndex = 42;
            // 
            // hål5SlagBox
            // 
            hål5SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål5SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål5SlagBox.Location = new Point(177, 3);
            hål5SlagBox.Name = "hål5SlagBox";
            hål5SlagBox.Size = new Size(26, 23);
            hål5SlagBox.TabIndex = 34;
            // 
            // hål13SlagBox
            // 
            hål13SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål13SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål13SlagBox.Location = new Point(421, 3);
            hål13SlagBox.Name = "hål13SlagBox";
            hål13SlagBox.Size = new Size(26, 23);
            hål13SlagBox.TabIndex = 40;
            // 
            // hål11SlagBox
            // 
            hål11SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål11SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål11SlagBox.Location = new Point(360, 3);
            hål11SlagBox.Name = "hål11SlagBox";
            hål11SlagBox.Size = new Size(26, 23);
            hål11SlagBox.TabIndex = 38;
            // 
            // hål3SlagBox
            // 
            hål3SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål3SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål3SlagBox.Location = new Point(115, 3);
            hål3SlagBox.Name = "hål3SlagBox";
            hål3SlagBox.Size = new Size(26, 23);
            hål3SlagBox.TabIndex = 32;
            // 
            // hål1SlagBox
            // 
            hål1SlagBox.BorderStyle = BorderStyle.FixedSingle;
            hål1SlagBox.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            hål1SlagBox.Location = new Point(52, 3);
            hål1SlagBox.Name = "hål1SlagBox";
            hål1SlagBox.Size = new Size(26, 23);
            hål1SlagBox.TabIndex = 30;
            hål1SlagBox.TextAlign = HorizontalAlignment.Center;
            // 
            // panel10
            // 
            panel10.Location = new Point(0, 31);
            panel10.Name = "panel10";
            panel10.Size = new Size(592, 30);
            panel10.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 8);
            label8.Name = "label8";
            label8.Size = new Size(31, 20);
            label8.TabIndex = 14;
            label8.Text = "Slag";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 118);
            label5.Name = "label5";
            label5.Size = new Size(57, 34);
            label5.TabIndex = 11;
            label5.Text = "Rond";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(61, 34);
            label2.TabIndex = 5;
            label2.Text = "Klubb";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(45, 34);
            label1.TabIndex = 4;
            label1.Text = "Var";
            // 
            // regRoundButton
            // 
            regRoundButton.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            regRoundButton.Location = new Point(92, 12);
            regRoundButton.Name = "regRoundButton";
            regRoundButton.Size = new Size(210, 49);
            regRoundButton.TabIndex = 1;
            regRoundButton.Text = "Registrera Ronder";
            regRoundButton.UseVisualStyleBackColor = true;
            regRoundButton.Click += regRoundButton_Click;
            // 
            // userInfoLabel
            // 
            userInfoLabel.AutoSize = true;
            userInfoLabel.BackColor = Color.Transparent;
            userInfoLabel.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            userInfoLabel.ForeColor = Color.White;
            userInfoLabel.Location = new Point(325, 6);
            userInfoLabel.Name = "userInfoLabel";
            userInfoLabel.Size = new Size(139, 31);
            userInfoLabel.TabIndex = 3;
            userInfoLabel.Text = "Hugo Andersson";
            // 
            // userHcpInfoLabel
            // 
            userHcpInfoLabel.AutoSize = true;
            userHcpInfoLabel.BackColor = Color.Transparent;
            userHcpInfoLabel.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            userHcpInfoLabel.ForeColor = Color.White;
            userHcpInfoLabel.Location = new Point(348, 37);
            userHcpInfoLabel.Name = "userHcpInfoLabel";
            userHcpInfoLabel.Size = new Size(57, 31);
            userHcpInfoLabel.TabIndex = 4;
            userHcpInfoLabel.Text = "HCP: ";
            // 
            // prevRoundButton
            // 
            prevRoundButton.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            prevRoundButton.Location = new Point(510, 12);
            prevRoundButton.Name = "prevRoundButton";
            prevRoundButton.Size = new Size(210, 49);
            prevRoundButton.TabIndex = 5;
            prevRoundButton.Text = "Tidigare Ronder";
            prevRoundButton.UseVisualStyleBackColor = true;
            prevRoundButton.Click += prevRoundButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            logOutButton.Location = new Point(4, 532);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(85, 30);
            logOutButton.TabIndex = 6;
            logOutButton.Text = "Logga ut";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // userHcpLabel
            // 
            userHcpLabel.AutoSize = true;
            userHcpLabel.BackColor = Color.Transparent;
            userHcpLabel.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            userHcpLabel.ForeColor = Color.White;
            userHcpLabel.Location = new Point(393, 37);
            userHcpLabel.Name = "userHcpLabel";
            userHcpLabel.Size = new Size(30, 31);
            userHcpLabel.TabIndex = 7;
            userHcpLabel.Text = "12";
            // 
            // pastRoundsPanel
            // 
            pastRoundsPanel.Controls.Add(removeButton);
            pastRoundsPanel.Controls.Add(label4);
            pastRoundsPanel.Controls.Add(clubsListBox);
            pastRoundsPanel.Controls.Add(label3);
            pastRoundsPanel.Controls.Add(bestRoundsListBox);
            pastRoundsPanel.Controls.Add(label68);
            pastRoundsPanel.Controls.Add(label67);
            pastRoundsPanel.Controls.Add(roundsListbox);
            pastRoundsPanel.Controls.Add(label123);
            pastRoundsPanel.Location = new Point(95, 78);
            pastRoundsPanel.Name = "pastRoundsPanel";
            pastRoundsPanel.Size = new Size(640, 399);
            pastRoundsPanel.TabIndex = 8;
            // 
            // removeButton
            // 
            removeButton.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removeButton.Location = new Point(160, 163);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(116, 30);
            removeButton.TabIndex = 40;
            removeButton.Text = "Ta bort vald runda";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(222, 265);
            label4.Name = "label4";
            label4.Size = new Size(163, 34);
            label4.TabIndex = 39;
            label4.Text = "Dina medlemskap";
            // 
            // clubsListBox
            // 
            clubsListBox.FormattingEnabled = true;
            clubsListBox.ItemHeight = 15;
            clubsListBox.Location = new Point(178, 299);
            clubsListBox.Name = "clubsListBox";
            clubsListBox.Size = new Size(266, 94);
            clubsListBox.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 228);
            label3.Name = "label3";
            label3.Size = new Size(462, 34);
            label3.TabIndex = 37;
            label3.Text = "Registrera nya ronder för att förbättra ditt handicap";
            // 
            // bestRoundsListBox
            // 
            bestRoundsListBox.FormattingEnabled = true;
            bestRoundsListBox.ItemHeight = 15;
            bestRoundsListBox.Location = new Point(319, 50);
            bestRoundsListBox.Name = "bestRoundsListBox";
            bestRoundsListBox.Size = new Size(266, 109);
            bestRoundsListBox.TabIndex = 35;
            // 
            // label68
            // 
            label68.AutoSize = true;
            label68.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label68.Location = new Point(317, 13);
            label68.Name = "label68";
            label68.Size = new Size(186, 34);
            label68.TabIndex = 34;
            label68.Text = "Dina bästa 4 ronder";
            // 
            // label67
            // 
            label67.AutoSize = true;
            label67.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label67.Location = new Point(26, 13);
            label67.Name = "label67";
            label67.Size = new Size(151, 34);
            label67.TabIndex = 33;
            label67.Text = "Alla dina ronder";
            // 
            // roundsListbox
            // 
            roundsListbox.FormattingEnabled = true;
            roundsListbox.ItemHeight = 15;
            roundsListbox.Location = new Point(13, 50);
            roundsListbox.Name = "roundsListbox";
            roundsListbox.Size = new Size(266, 109);
            roundsListbox.TabIndex = 32;
            // 
            // label123
            // 
            label123.AutoSize = true;
            label123.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label123.Location = new Point(13, 192);
            label123.Name = "label123";
            label123.Size = new Size(455, 34);
            label123.TabIndex = 11;
            label123.Text = "Ditt Handicap är beräknat efter dina 4 bästa ronder";
            // 
            // clubInfoButton
            // 
            clubInfoButton.Font = new Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            clubInfoButton.Location = new Point(309, 505);
            clubInfoButton.Name = "clubInfoButton";
            clubInfoButton.Size = new Size(171, 48);
            clubInfoButton.TabIndex = 9;
            clubInfoButton.Text = "Visa Olika Klubb Info";
            clubInfoButton.UseVisualStyleBackColor = true;
            clubInfoButton.Click += clubInfoButton_Click;
            // 
            // clubInfoPanel
            // 
            clubInfoPanel.Controls.Add(showHandicapButton);
            clubInfoPanel.Controls.Add(showAllMembersButton);
            clubInfoPanel.Controls.Add(viewAllButton);
            clubInfoPanel.Controls.Add(searchButton);
            clubInfoPanel.Controls.Add(clubSearchTextBox);
            clubInfoPanel.Controls.Add(clubListBox);
            clubInfoPanel.Controls.Add(label10);
            clubInfoPanel.Controls.Add(clubMembersListBox);
            clubInfoPanel.Controls.Add(label52);
            clubInfoPanel.Controls.Add(label53);
            clubInfoPanel.Location = new Point(95, 78);
            clubInfoPanel.Name = "clubInfoPanel";
            clubInfoPanel.Size = new Size(640, 399);
            clubInfoPanel.TabIndex = 10;
            // 
            // showHandicapButton
            // 
            showHandicapButton.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            showHandicapButton.Location = new Point(374, 366);
            showHandicapButton.Name = "showHandicapButton";
            showHandicapButton.Size = new Size(251, 30);
            showHandicapButton.TabIndex = 41;
            showHandicapButton.Text = "Visa Medlemar under 30 hcp";
            showHandicapButton.UseVisualStyleBackColor = true;
            showHandicapButton.Click += showHandicapButton_Click;
            // 
            // showAllMembersButton
            // 
            showAllMembersButton.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            showAllMembersButton.Location = new Point(375, 334);
            showAllMembersButton.Name = "showAllMembersButton";
            showAllMembersButton.Size = new Size(250, 30);
            showAllMembersButton.TabIndex = 40;
            showAllMembersButton.Text = "Visa alla medlemar i alla klubbar";
            showAllMembersButton.UseVisualStyleBackColor = true;
            showAllMembersButton.Click += showAllMembersButton_Click;
            // 
            // viewAllButton
            // 
            viewAllButton.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            viewAllButton.Location = new Point(143, 330);
            viewAllButton.Name = "viewAllButton";
            viewAllButton.Size = new Size(122, 30);
            viewAllButton.TabIndex = 39;
            viewAllButton.Text = "Visa alla klubbar";
            viewAllButton.UseVisualStyleBackColor = true;
            viewAllButton.Click += viewAllButton_Click;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            searchButton.Location = new Point(270, 76);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(85, 30);
            searchButton.TabIndex = 38;
            searchButton.Text = "Sök";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // clubSearchTextBox
            // 
            clubSearchTextBox.Location = new Point(257, 47);
            clubSearchTextBox.Name = "clubSearchTextBox";
            clubSearchTextBox.Size = new Size(112, 23);
            clubSearchTextBox.TabIndex = 37;
            // 
            // clubListBox
            // 
            clubListBox.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clubListBox.FormattingEnabled = true;
            clubListBox.ItemHeight = 20;
            clubListBox.Location = new Point(14, 140);
            clubListBox.Name = "clubListBox";
            clubListBox.Size = new Size(251, 184);
            clubListBox.TabIndex = 36;
            clubListBox.SelectedIndexChanged += clubListBox_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(405, 103);
            label10.Name = "label10";
            label10.Size = new Size(182, 34);
            label10.TabIndex = 35;
            label10.Text = "Medlemar i Klubben";
            // 
            // clubMembersListBox
            // 
            clubMembersListBox.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clubMembersListBox.FormattingEnabled = true;
            clubMembersListBox.ItemHeight = 20;
            clubMembersListBox.Location = new Point(375, 144);
            clubMembersListBox.Name = "clubMembersListBox";
            clubMembersListBox.Size = new Size(251, 184);
            clubMembersListBox.TabIndex = 34;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label52.Location = new Point(3, 103);
            label52.Name = "label52";
            label52.Size = new Size(270, 34);
            label52.TabIndex = 5;
            label52.Text = "Välj Klubb Baserat på Sökning";
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label53.Location = new Point(222, 13);
            label53.Name = "label53";
            label53.Size = new Size(181, 34);
            label53.TabIndex = 4;
            label53.Text = "Sök på vilken klubb";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 565);
            Controls.Add(clubInfoButton);
            Controls.Add(userHcpLabel);
            Controls.Add(logOutButton);
            Controls.Add(prevRoundButton);
            Controls.Add(userHcpInfoLabel);
            Controls.Add(userInfoLabel);
            Controls.Add(regRoundButton);
            Controls.Add(regRoundPanel);
            Controls.Add(pastRoundsPanel);
            Controls.Add(clubInfoPanel);
            Name = "MainPage";
            Text = "MainPage";
            regRoundPanel.ResumeLayout(false);
            regRoundPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            pastRoundsPanel.ResumeLayout(false);
            pastRoundsPanel.PerformLayout();
            clubInfoPanel.ResumeLayout(false);
            clubInfoPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel regRoundPanel;
        private Button regRoundButton;
        private Label userInfoLabel;
        private Label userHcpInfoLabel;
        private Button prevRoundButton;
        private Button logOutButton;
        private Label label2;
        private Label label1;
        private Panel panel9;
        private Panel panel10;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private Label par18Label;
        private Label par17Label;
        private Label par16Label;
        private Label par1Label;
        private Label par15Label;
        private Label par2Label;
        private Label par14Label;
        private Label par7Label;
        private Label par13Label;
        private Label par3Label;
        private Label par12Label;
        private Label par4Label;
        private Label par11Label;
        private Label par5Label;
        private Label par10Label;
        private Label par6Label;
        private Label par9Label;
        private Label par8Label;
        private Label label84;
        private Label label85;
        private Label label86;
        private Label label101;
        private Label label87;
        private Label label100;
        private Label label88;
        private Label label99;
        private Label label89;
        private Label label98;
        private Label label90;
        private Label label97;
        private Label label91;
        private Label label96;
        private Label label92;
        private Label label95;
        private Label label93;
        private Label label66;
        private Label label67;
        private Label label68;
        private Label label83;
        private Label label69;
        private Label label82;
        private Label label70;
        private Label label81;
        private Label label71;
        private Label label80;
        private Label label72;
        private Label label79;
        private Label label73;
        private Label label78;
        private Label label74;
        private Label label77;
        private Label label75;
        private Label label76;
        private TextBox hål2SlagBox;
        private TextBox hål1SlagBox;
        private TextBox hål10SlagBox;
        private TextBox hål18SlagBox;
        private TextBox hål9SlagBox;
        private TextBox hål8SlagBox;
        private TextBox hål14SlagBox;
        private TextBox hål4SlagBox;
        private TextBox hål16SlagBox;
        private TextBox hål6SlagBox;
        private TextBox hål17SlagBox;
        private TextBox hål7SlagBox;
        private TextBox hål12SlagBox;
        private TextBox hål15SlagBox;
        private TextBox hål5SlagBox;
        private TextBox hål13SlagBox;
        private TextBox hål11SlagBox;
        private TextBox hål3SlagBox;
        private Label hål18Label;
        private Label hål17Label;
        private Label hål16Label;
        private Label hål9Label;
        private Label hål6Label;
        private Label hål8Label;
        private Label hål15Label;
        private Label hål5Label;
        private Label hål1Label;
        private Label hål10Label;
        private Label hål14Label;
        private Label hål4Label;
        private Label hål2Label;
        private Label hål11Label;
        private Label hål13Label;
        private Label hål3Label;
        private Label hål7Label;
        private Label hål12Label;
        private Label label7;
        private Label userHcpLabel;
        private Panel pastRoundsPanel;
        private Label label123;
        private ListBox roundsListbox;
        private ListBox bestRoundsListBox;
        private ComboBox clubComboBox;
        private ComboBox courseComboBox;
        private Button registerRoundButton;
        private Label label4;
        private ListBox clubsListBox;
        private Label label3;
        private Button clubInfoButton;
        private Panel clubInfoPanel;
        private Label label52;
        private Label label53;
        private ListBox clubMembersListBox;
        private Label label10;
        private Button searchButton;
        private TextBox clubSearchTextBox;
        private ListBox clubListBox;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button viewAllButton;
        private Button removeButton;
        private Button showHandicapButton;
        private Button showAllMembersButton;
    }
}