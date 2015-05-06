using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Data.OleDb;
using System.IO;
//using MySql;
//using MySql.Data.MySqlClient;

namespace PerformancePrediction
{
    public partial class FormMain : Form
    {

        ArrayList comboBoxModule4 = new ArrayList();
        ArrayList comboBoxModule5 = new ArrayList();
        ArrayList comboBoxModule6 = new ArrayList();

        ArrayList labelsModule4 = new ArrayList();
        ArrayList labelsModule5 = new ArrayList();
        ArrayList labelsModule6 = new ArrayList();

        ArrayList labelAssesCount4 = new ArrayList();
        ArrayList labelAssesCount5 = new ArrayList();
        ArrayList labelAssesCount6 = new ArrayList();
 
        ArrayList myNumericUpDown4 = new ArrayList();
        ArrayList myNumericUpDown5 = new ArrayList();
        ArrayList myNumericUpDown6 = new ArrayList();
 
        NumericTextBox[,] textBoxMarks4 = new NumericTextBox[,] { };
        NumericTextBox[,] textBoxMarks5 = new NumericTextBox[,] { };
        NumericTextBox[,] textBoxMarks6 = new NumericTextBox[,] { };

        Label[,] lebelAssesNum4 = new Label[,] { };
        Label[,] lebelAssesNum5 = new Label[,] { };
        Label[,] lebelAssesNum6 = new Label[,] { };

        Label[,] lableMarks4 = new Label[,] { };
        Label[,] lableMarks5 = new Label[,] { };
        Label[,] lableMarks6 = new Label[,] { };

        
        Label[,] labelWeight4 = new Label[,] { };
        Label[,] labelWeight5 = new Label[,] { };
        Label[,] labelWeight6 = new Label[,] { };

        NumericTextBox[,] textBoxWeight4 = new NumericTextBox[,] { };
        NumericTextBox[,] textBoxWeight5 = new NumericTextBox[,] { };
        NumericTextBox[,] textBoxWeight6 = new NumericTextBox[,] { };




        public FormMain()
        {
            InitializeComponent();
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        private void textBox_mouseEnter(object sender, EventArgs e)
        {
            ComboBox tempBox = (ComboBox)sender;
            tempBox.BackColor = Color.PaleGoldenrod;
        }

        private void textBox_mouseLeave(object sender, EventArgs e)
        {
            ComboBox tempBox = (ComboBox)sender;
            tempBox.BackColor = Color.White;
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        
        int makeMod4 = 0;
        //generates modules for level 4
        private void button2_Click(object sender, EventArgs e)
        {
          

            int length = (int)this.numericUpDown1.Value;
           
            for (int i = makeMod4; i < length; i++)
            {
                makeMod4++;

                //instantiate and configure the text boxes
                comboBoxModule4.Add(new ComboBox());


                System.Drawing.Point p = new System.Drawing.Point(126, 94 + i * 140);
                //to evoke an object in an ArrayList we use the 'as' keyword

                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("EBSY400 Communication and Learning Skills", 15));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("EBSY401 Information & Data Modelling", 15));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("EBSY402 Programming the Technology", 15));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("EBSY403 Business Mathematics", 15));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("EBSY404 Requirements Analysis", 15));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("EBSY405 Business Information Systems Concepts 1", 15));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("EBSY406 Business Information Systems Concepts 2", 15));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("ECSC404 Computer Systems Fundamentals", 15));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("ECSC405 Software Development Principles II", 15));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("ECSC405 Software Development Principles I", 30));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("ECSC407 Web Technology", 15));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("ECSC408 Mathematics for Computing", 15));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("ECSC410 Software Development Principles", 15));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("ECSC411 Information Systems", 15));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("ECWM401 User Experience Design", 15));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("ECWM402 Interactive Product Development", 15));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("EICG402 Maths for Games Development", 15));
                (comboBoxModule4[i] as ComboBox).Items.Add(new Item("EICG406 Games Group Project I", 15));

                (comboBoxModule4[i] as ComboBox).Location = p;
                (comboBoxModule4[i] as ComboBox).Size = new System.Drawing.Size(350, 20);
                (comboBoxModule4[i] as ComboBox).SelectedIndexChanged += new System.EventHandler(comboBoxModule4_SelectedIndexChanged);

                //use 'as' again here to add the control to the controls Collection
                tabPageLevel4.Controls.Add(comboBoxModule4[i] as ComboBox);
                //instantiate and configure the labels
                this.labelsModule4.Add(new Label());
                System.Drawing.Point pLabel = new System.Drawing.Point(50, 99 + i * 140);
                (labelsModule4[i] as Label).Location = pLabel;
                (labelsModule4[i] as Label).Size = new System.Drawing.Size(80, 13);
                (labelsModule4[i] as Label).Text = "Module " + (i + 1).ToString() + ":";
                tabPageLevel4.Controls.Add((labelsModule4[i] as Label));


                //numeric drop dow condrolls to select anount of assgnments per module
                this.myNumericUpDown4.Add(new NumericUpDown());
                System.Drawing.Point pnum = new System.Drawing.Point(250, 120 + i * 140);
                (myNumericUpDown4[i] as NumericUpDown).Location = pnum;
                (myNumericUpDown4[i] as NumericUpDown).Size = new System.Drawing.Size(51, 20);
                (myNumericUpDown4[i] as NumericUpDown).Maximum = new decimal(new int[] { 6, 0, 0, 0 });
                tabPageLevel4.Controls.Add((myNumericUpDown4[i] as NumericUpDown));

                //labels of numeric up done components
                this.labelAssesCount4.Add(new Label());
                System.Drawing.Point asslabLabel = new System.Drawing.Point(126, 125 + i * 140);
                (labelAssesCount4[i] as Label).Location = asslabLabel;
                (labelAssesCount4[i] as Label).Size = new System.Drawing.Size(150, 13);
                (labelAssesCount4[i] as Label).Text = "Number of Assignments ";
                tabPageLevel4.Controls.Add(((labelAssesCount4[i] as Label)));

                

            }

        }
        //calculates amount of credits left to use
        private void comboBoxModule4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedVal = 0;
            int credit = 120;
            int length = (int)this.numericUpDown1.Value;


            for (int i = 0; i < length; i++)
            {

                if ((comboBoxModule4[i] as ComboBox).SelectedIndex > -1)
                {

                    if (credit >= 0)
                    {


                        selectedVal = ((comboBoxModule4[i] as ComboBox).SelectedItem as Item).Value;
                        credit = credit - selectedVal;
                        labelCredit4.Text = credit.ToString();

                        if (credit < 0)
                        {
                            credit = 0;
                            labelCredit4.Text = credit.ToString();
                            MessageBox.Show("You run out of credints", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            (labelAssesCount4[i] as Label).Visible = false;
                            (myNumericUpDown4[i] as NumericUpDown).Visible = false;
                            (labelsModule4[i] as Label).Visible = false;
                            (comboBoxModule4[i] as ComboBox).Visible = false;


                            comboBoxModule4.RemoveAt(comboBoxModule4.Count - 1);
                            labelAssesCount4.RemoveAt(labelAssesCount4.Count - 1);
                            myNumericUpDown4.RemoveAt(myNumericUpDown4.Count - 1);
                            labelsModule4.RemoveAt(labelsModule4.Count - 1);

                        }
                    }

                }


            }
        }

        int makeMod5 = 0;
        //geberates modules for level 5
        private void button3_Click(object sender, EventArgs e)
        {
            int length = (int)this.numericUpDown2.Value;
            for (int i = makeMod5; i < length; i++)
            {
                makeMod5++;
                //instantiate and configure the text boxes
                comboBoxModule5.Add(new ComboBox());


                System.Drawing.Point p = new System.Drawing.Point(126, 94 + i * 140);
                //to evoke an object in an ArrayList we use the 'as' keyword


                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("EBSY500 Professional Practice", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("EBSY501 Project Management", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("EBSY502 BIS Design and Development", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("EBSY504 Networked Enterprise", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("EBSY505 Database Design and Practice 1", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("EBSY506 Database Design and Practice 2", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("EBSY507 Web Development", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("EBSY508 Business Analytics", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("ECSC500 Professional Practice in Computer Science", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("ECSC501 Object Oriented Programming I", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("ECSC502 Object Oriented Programming II", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("ECSC503 Software Development Group Project", 30));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("ECSC504 Algorithms and Complexity", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("ECSC505 Professional Practice", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("ECWM501 3D Modelling & Animation", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("ECWM502 Advanced Client Side Web Development", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("ECWM506 Mobile Computing Principles", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("ECWM511 Mobile Application Development", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("ECWM512 Web Server Side Programming", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("EICG501 3D Graphics Programming", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("EICG502 Physics for Games Programming", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("EICG503 Game Engine Architecture", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("EICG505 Games Group Project II", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("EICG508 Professional Practice for Games", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("EICG509 Applied Maths & Physics", 15));
                (comboBoxModule5[i] as ComboBox).Items.Add(new Item("EBSY511 Service Operations Management", 15));




                (comboBoxModule5[i] as ComboBox).Location = p;
                (comboBoxModule5[i] as ComboBox).Size = new System.Drawing.Size(350, 20);
                (comboBoxModule5[i] as ComboBox).SelectedIndexChanged += new System.EventHandler(comboBoxModule5_SelectedIndexChanged);

                //use 'as' again here to add the control to the controls Collection
                tabPageLevel5.Controls.Add(comboBoxModule5[i] as ComboBox);
                //instantiate and configure the labels
                this.labelsModule5.Add(new Label());
                System.Drawing.Point pLabel = new System.Drawing.Point(50, 99 + i * 140);
                (labelsModule5[i] as Label).Location = pLabel;
                (labelsModule5[i] as Label).Size = new System.Drawing.Size(80, 13);
                (labelsModule5[i] as Label).Text = "Module " + (i + 1).ToString() + ":";
                tabPageLevel5.Controls.Add((labelsModule5[i] as Label));



                //numeric drop dow condrolls to select anount of assgnments per module
                this.myNumericUpDown5.Add(new NumericUpDown());
                System.Drawing.Point pnum = new System.Drawing.Point(250, 120 + i * 140);
                (myNumericUpDown5[i] as NumericUpDown).Location = pnum;
                (myNumericUpDown5[i] as NumericUpDown).Size = new System.Drawing.Size(51, 20);
                (myNumericUpDown5[i] as NumericUpDown).Maximum = new decimal(new int[] { 6, 0, 0, 0 });
                tabPageLevel5.Controls.Add((myNumericUpDown5[i] as NumericUpDown));

                //labels of numeric up done components
                this.labelAssesCount5.Add(new Label());
                System.Drawing.Point asslabLabel = new System.Drawing.Point(126, 125 + i * 140);
                (labelAssesCount5[i] as Label).Location = asslabLabel;
                (labelAssesCount5[i] as Label).Size = new System.Drawing.Size(150, 13);
                (labelAssesCount5[i] as Label).Text = "Number of Assignments ";
                tabPageLevel5.Controls.Add(((labelAssesCount5[i] as Label)));
            }
 
        }


        //calculates amount of credit left after module been selected and display message to user if no credits left
        private void comboBoxModule5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedVal = 0;
            int credit = 120;
            int length = (int)this.numericUpDown2.Value;


            for (int i = 0; i < length; i++)
            {

                if ((comboBoxModule5[i] as ComboBox).SelectedIndex > -1)
                {

                    if (credit >= 0)
                    {


                        selectedVal = ((comboBoxModule5[i] as ComboBox).SelectedItem as Item).Value;
                        credit = credit - selectedVal;
                        labelCredit5.Text = credit.ToString();

                        if (credit < 0)
                        {
                            credit = 0;
                            labelCredit5.Text = credit.ToString();
                            MessageBox.Show("You run out of credints", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            (labelAssesCount5[i] as Label).Visible = false;
                            (myNumericUpDown5[i] as NumericUpDown).Visible = false;
                            (labelsModule5[i] as Label).Visible = false;
                            (comboBoxModule5[i] as ComboBox).Visible = false;


                            comboBoxModule5.RemoveAt(comboBoxModule5.Count - 1);
                            labelAssesCount5.RemoveAt(labelAssesCount5.Count - 1);
                            myNumericUpDown5.RemoveAt(myNumericUpDown5.Count - 1);
                            labelsModule5.RemoveAt(labelsModule5.Count - 1);

                        }
                    }

                }

            }
        }

        int makeMod6;
        //generate module for level 6
        private void button4_Click(object sender, EventArgs e)
        {
            int length = (int)this.numericUpDown3.Value;

            for (int i = makeMod6; i < length; i++)
            {

                makeMod6++;

                //instantiate and configure the combo boxes
                comboBoxModule6.Add(new ComboBox());


                System.Drawing.Point p = new System.Drawing.Point(126, 94 + i * 140);
                //to evoke an object in an ArrayList we use the 'as' keyword

                //populatig combobox for level 6
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("EBSY600 Information Systems Development Methodologies", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("EBSY601 Information Systems Strategy", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("EBSY602 Information Systems Quality and Testing", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("EBSY604 Data Warehousing and Mining", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("EBSY605 Advanced Topics in Databases", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("EBSY610 Starting a Business", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("EBSY612 Web and Social Analytics", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("EBSY613 Networked Enterprise", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("EBSY699 Business Information Systems Project", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("ECSC697 Computer Science and Software Engineering Project", 45));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("ECSE609 Security and Forensics", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("ECSE610 Formal Specification", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("ECSE615 Computer Systems Administration", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("ECWM601 Native Programming", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("ECWM602 Service Oriented Architecture", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("ECWM603 Mobile User Experience", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("ECWM604 Advanced Web Technology", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("ECWM605 Advanced Animation Techniques", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("ECWM606 Web Analytics and Marketing", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("ECWM611 Real-Time Embedded Systems", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("ECWM618 Web Intelligence", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("ECWM697 Multimedia Project", 45));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("EICG601 Advanced Maths for Game Development", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("EICG603 Object Oriented Development for Games II", 15));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("EICG697 Computer Games Project", 45));
                (comboBoxModule6[i] as ComboBox).Items.Add(new Item("EBSY611 Knowledge Management", 15));



                (comboBoxModule6[i] as ComboBox).Location = p;
                (comboBoxModule6[i] as ComboBox).Size = new System.Drawing.Size(350, 20);
                (comboBoxModule6[i] as ComboBox).SelectedIndexChanged += new System.EventHandler(comboBoxModule6_SelectedIndexChanged);

                //use 'as' again here to add the control to the controls Collection
                tabPageLevel6.Controls.Add(comboBoxModule6[i] as ComboBox);
                //instantiate and configure the labels
                this.labelsModule6.Add(new Label());
                System.Drawing.Point pLabel = new System.Drawing.Point(50, 99 + i * 140);
                (labelsModule6[i] as Label).Location = pLabel;
                (labelsModule6[i] as Label).Size = new System.Drawing.Size(80, 13);
                (labelsModule6[i] as Label).Text = "Module " + (i + 1).ToString() + ":";
                tabPageLevel6.Controls.Add((labelsModule6[i] as Label));


                //numeric drop dow condrolls to select anount of assgnments per module
                this.myNumericUpDown6.Add(new NumericUpDown());
                System.Drawing.Point pnum = new System.Drawing.Point(250, 120 + i * 140);
                (myNumericUpDown6[i] as NumericUpDown).Location = pnum;
                (myNumericUpDown6[i] as NumericUpDown).Size = new System.Drawing.Size(51, 20);
                (myNumericUpDown6[i] as NumericUpDown).Maximum = new decimal(new int[] { 6, 0, 0, 0 });
                tabPageLevel6.Controls.Add((myNumericUpDown6[i] as NumericUpDown));

                //labels of numeric up done components
                this.labelAssesCount6.Add(new Label());
                System.Drawing.Point asslabLabel = new System.Drawing.Point(126, 125 + i * 140);
                (labelAssesCount6[i] as Label).Location = asslabLabel;
                (labelAssesCount6[i] as Label).Size = new System.Drawing.Size(150, 13);
                (labelAssesCount6[i] as Label).Text = "Number of Assignments ";
                tabPageLevel6.Controls.Add(((labelAssesCount6[i] as Label)));
            }

        }

        //calculates amount of credit left after module been selected and display message to user if no credits left
        private void comboBoxModule6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedVal = 0;
            int credit = 120;
            int length = (int)this.numericUpDown3.Value;


            for (int i = 0; i < length; i++)
            {

                if ((comboBoxModule6[i] as ComboBox).SelectedIndex > -1)
                {

                    if (credit >= 0)
                    {


                        selectedVal = ((comboBoxModule6[i] as ComboBox).SelectedItem as Item).Value;
                        credit = credit - selectedVal;
                        labelCredit6.Text = credit.ToString();

                        if (credit < 0)
                        {
                            credit = 0;
                            labelCredit6.Text = credit.ToString();
                            MessageBox.Show("You run out of credints", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            (labelAssesCount6[i] as Label).Visible = false;
                            (myNumericUpDown6[i] as NumericUpDown).Visible = false;
                            (labelsModule6[i] as Label).Visible = false;
                            (comboBoxModule6[i] as ComboBox).Visible = false;


                            comboBoxModule6.RemoveAt(comboBoxModule6.Count - 1);
                            labelAssesCount6.RemoveAt(labelAssesCount6.Count - 1);
                            myNumericUpDown6.RemoveAt(myNumericUpDown6.Count - 1);
                            labelsModule6.RemoveAt(labelsModule6.Count - 1);

                        }
                    }

                }





            }
        }

        //generates assessments for level 4 modules
        private void button1_Click(object sender, EventArgs e)
        {

            this.lebelAssesNum4 = new Label[this.myNumericUpDown4.Count, 6];
            this.labelWeight4 = new Label[this.myNumericUpDown4.Count, 6];
            this.textBoxMarks4 = new NumericTextBox[this.myNumericUpDown4.Count, 6];
            this.lableMarks4 = new Label[this.myNumericUpDown4.Count, 6];
            this.textBoxWeight4 = new NumericTextBox[this.myNumericUpDown4.Count, 6];

            for (int i = 0; i < this.myNumericUpDown4.Count; i++)
            {
               

                int length = (int)(this.myNumericUpDown4[i] as NumericUpDown).Value;

                for (int x = 0; x < length; x++)
                {

                   

                    this.lebelAssesNum4[i, x] = new Label();
                    System.Drawing.Point asslabLabel = new System.Drawing.Point(126 + x * 150, 150 + i * 140);
                    (lebelAssesNum4[i, x] as Label).Location = asslabLabel;
                    (lebelAssesNum4[i, x] as Label).Size = new System.Drawing.Size(80, 13);
                    (lebelAssesNum4[i, x] as Label).Text = "Assessment: " + (x + 1);
                    tabPageLevel4.Controls.Add(((lebelAssesNum4[i, x] as Label)));



                    this.labelWeight4[i, x] = new Label();
                    System.Drawing.Point pweightLab = new System.Drawing.Point(126 + x * 150, 170 + i * 140);
                    (labelWeight4[i, x] as Label).Location = pweightLab;
                    (labelWeight4[i, x] as Label).Size = new System.Drawing.Size(50, 13);
                    (labelWeight4[i, x] as Label).Text = "Weight:";
                    tabPageLevel4.Controls.Add(((labelWeight4[i, x] as Label)));



                    this.lableMarks4[i, x] = new Label();
                    System.Drawing.Point pmarkslab = new System.Drawing.Point(126 + x * 150, 200 + i * 140);
                    (lableMarks4[i, x] as Label).Location = pmarkslab;
                    (lableMarks4[i, x] as Label).Size = new System.Drawing.Size(50, 13);
                    (lableMarks4[i, x] as Label).Text = "Mark:";
                    tabPageLevel4.Controls.Add(((lableMarks4[i, x] as Label)));

                    this.textBoxWeight4[i, x] = new NumericTextBox();
                    System.Drawing.Point pweigthbox = new System.Drawing.Point(190 + x * 150, 170 + i * 140);
                    (textBoxWeight4[i, x] as NumericTextBox).Location = pweigthbox;
                    (textBoxWeight4[i, x] as NumericTextBox).Size = new System.Drawing.Size(30, 20);
                    (textBoxWeight4[i, x] as NumericTextBox).Text = "0";
                    (textBoxWeight4[i, x] as NumericTextBox).Name = "0";
                    tabPageLevel4.Controls.Add(textBoxWeight4[i, x] as NumericTextBox);


                    this.textBoxMarks4[i, x] = new NumericTextBox();
                    System.Drawing.Point pbutt = new System.Drawing.Point(190 + x * 150, 200 + i * 140);
                    (textBoxMarks4[i, x] as NumericTextBox).Location = pbutt;
                    (textBoxMarks4[i, x] as NumericTextBox).Size = new System.Drawing.Size(30, 20);
                    (textBoxMarks4[i, x] as NumericTextBox).Text = "0";
                    (textBoxMarks4[i, x] as NumericTextBox).Name = "0";
                    (textBoxMarks4[i, x] as NumericTextBox).TextChanged += textBoxMarks4_TextChanged;
                    tabPageLevel4.Controls.Add(textBoxMarks4[i, x] as NumericTextBox);

                }
               
            }



        }
        List<double> level4 = new List<double>();
        List<double> modMark4 = new List<double>();

        //calculate level 4 average mark
        private void textBoxMarks4_TextChanged(object sender, EventArgs e)
        {

            if (myNumericUpDown4.Count != 0)
            {

                level4.Clear();
                double score = 0;
                double m = 0;
                double w = 0;
                double mm = 0;
                for (int i = 0; i < myNumericUpDown4.Count; i++)
                {


                    int lenght = (int)(this.myNumericUpDown4[i] as NumericUpDown).Value;

                    modMark4.Clear();
                    for (int x = 0; x < lenght; x++)
                    {

                        if (!String.IsNullOrEmpty((textBoxMarks4[i, x] as NumericTextBox).Text) && !String.IsNullOrEmpty((textBoxWeight4[i, x] as NumericTextBox).Text))
                        {

                            m = (Convert.ToInt32((textBoxMarks4[i, x] as NumericTextBox).Text));
                            w = (Convert.ToInt32((textBoxWeight4[i, x] as NumericTextBox).Text));
                            score = m * w / 100;
                            modMark4.Add(score);


                        }

                    } mm = (modMark4.Sum());
                    level4.Add(mm);

                    labelAvg4.Text = Math.Round(level4.Average(), 2).ToString() + " %";
                    level4sum.Text = Math.Round(level4.Average(), 2).ToString() + " %";


                }

            }

        }

        //generates assessments for level 5 modules
        private void button10_Click(object sender, EventArgs e)
        {
            this.lebelAssesNum5 = new Label[this.myNumericUpDown5.Count, 6];
            this.labelWeight5 = new Label[this.myNumericUpDown5.Count, 6];
            this.textBoxMarks5 = new NumericTextBox[this.myNumericUpDown5.Count, 6];
            this.lableMarks5 = new Label[this.myNumericUpDown5.Count, 6];
            this.textBoxWeight5 = new NumericTextBox[this.myNumericUpDown5.Count, 6];

            for (int i = 0; i < myNumericUpDown5.Count; i++)
            {


                int length = (int)(myNumericUpDown5[i] as NumericUpDown).Value;

                for (int x = 0; x < length; x++)
                {
                    this.lebelAssesNum5[i, x] = new Label();
                    System.Drawing.Point asslabLabel = new System.Drawing.Point(126 + x * 150, 150 + i * 140);
                    (lebelAssesNum5[i, x] as Label).Location = asslabLabel;
                    (lebelAssesNum5[i, x] as Label).Size = new System.Drawing.Size(80, 13);
                    (lebelAssesNum5[i, x] as Label).Text = "Assessment: " + (x + 1);
                    tabPageLevel5.Controls.Add(((lebelAssesNum5[i, x] as Label)));


                    this.labelWeight5[i, x] = new Label();
                    System.Drawing.Point pweightLab = new System.Drawing.Point(126 + x * 150, 170 + i * 140);
                    (labelWeight5[i, x] as Label).Location = pweightLab;
                    (labelWeight5[i, x] as Label).Size = new System.Drawing.Size(50, 13);
                    (labelWeight5[i, x] as Label).Text = "Weight:";
                    tabPageLevel5.Controls.Add(((labelWeight5[i, x] as Label)));



                    this.lableMarks5[i, x] = new Label();
                    System.Drawing.Point pmarkslab = new System.Drawing.Point(126 + x * 150, 200 + i * 140);
                    (lableMarks5[i, x] as Label).Location = pmarkslab;
                    (lableMarks5[i, x] as Label).Size = new System.Drawing.Size(50, 13);
                    (lableMarks5[i, x] as Label).Text = "Mark:";
                    tabPageLevel5.Controls.Add(((lableMarks5[i, x] as Label)));

                    this.textBoxWeight5[i, x] = new NumericTextBox();
                    System.Drawing.Point pweigthbox = new System.Drawing.Point(190 + x * 150, 170 + i * 140);
                    (textBoxWeight5[i, x] as NumericTextBox).Location = pweigthbox;
                    (textBoxWeight5[i, x] as NumericTextBox).Size = new System.Drawing.Size(30, 20);
                    (textBoxWeight5[i, x] as NumericTextBox).Text = "0";
                    tabPageLevel5.Controls.Add(textBoxWeight5[i, x] as NumericTextBox);


                    this.textBoxMarks5[i, x] = new NumericTextBox();
                    System.Drawing.Point pbutt = new System.Drawing.Point(190 + x * 150, 200 + i * 140);
                    (textBoxMarks5[i, x] as NumericTextBox).Location = pbutt;
                    (textBoxMarks5[i, x] as NumericTextBox).Size = new System.Drawing.Size(30, 20);
                    (textBoxMarks5[i, x] as NumericTextBox).Text = "0";
                    (textBoxMarks5[i, x] as NumericTextBox).Name = "0";
                    (textBoxMarks5[i, x] as NumericTextBox).TextChanged += textBoxMarks5_TextChanged;
                    tabPageLevel5.Controls.Add(textBoxMarks5[i, x] as NumericTextBox);

                }

            }
        }
        List<double> level5 = new List<double>();
        List<double> modMark5 = new List<double>();

        //calculates level 5 average mark
        private void textBoxMarks5_TextChanged(object sender, EventArgs e)
        {

            if (myNumericUpDown5.Count != 0)
            {
                level5.Clear();
                double score = 0;
                double m = 0;
                double w = 0;
                double mm = 0;
                for (int i = 0; i < myNumericUpDown5.Count; i++)
                {
                    int lenght = (int)(this.myNumericUpDown5[i] as NumericUpDown).Value;

                    modMark5.Clear();
                    for (int x = 0; x < lenght; x++)
                    {

                        if (!String.IsNullOrEmpty((textBoxMarks5[i, x] as NumericTextBox).Text) && !String.IsNullOrEmpty((textBoxWeight5[i, x] as NumericTextBox).Text))
                        {

                            m = (Convert.ToInt32((textBoxMarks5[i, x] as NumericTextBox).Text));
                            w = (Convert.ToInt32((textBoxWeight5[i, x] as NumericTextBox).Text));
                            score = m * w / 100;
                            modMark5.Add(score);


                        }

                    } mm = (modMark5.Sum());
                    level5.Add(mm);
                    labelAvg5.Text = Math.Round((level5.Average()), 1).ToString() + " %";
                    level5sum.Text = Math.Round((level5.Average()), 1).ToString() + " %";

                }

            }
        }

        //generates assessments for level 6 modules
        private void button11_Click(object sender, EventArgs e)
        {
            this.lebelAssesNum6 = new Label[this.myNumericUpDown6.Count, 6];
            this.labelWeight6 = new Label[this.myNumericUpDown6.Count, 6];
            this.textBoxMarks6 = new NumericTextBox[this.myNumericUpDown6.Count, 6];
            this.lableMarks6 = new Label[this.myNumericUpDown6.Count, 6];
            this.textBoxWeight6 = new NumericTextBox[this.myNumericUpDown6.Count, 6];


            for (int i = 0; i < this.myNumericUpDown6.Count; i++)
            {

                int length = (int)(this.myNumericUpDown6[i] as NumericUpDown).Value;

                for (int x = 0; x < length; x++)
                {
                    this.lebelAssesNum6[i, x] = new Label();
                    System.Drawing.Point asslabLabel = new System.Drawing.Point(126 + x * 150, 150 + i * 140);
                    (lebelAssesNum6[i, x] as Label).Location = asslabLabel;
                    (lebelAssesNum6[i, x] as Label).Size = new System.Drawing.Size(80, 13);
                    (lebelAssesNum6[i, x] as Label).Text = @"Assessment: " + (x + 1);
                    tabPageLevel6.Controls.Add(((lebelAssesNum6[i, x] as Label)));



                    this.labelWeight6[i, x] = new Label();
                    System.Drawing.Point pweightLab = new System.Drawing.Point(126 + x * 150, 170 + i * 140);
                    (labelWeight6[i, x] as Label).Location = pweightLab;
                    (labelWeight6[i, x] as Label).Size = new System.Drawing.Size(50, 13);
                    (labelWeight6[i, x] as Label).Text = @"Weight:";
                    tabPageLevel6.Controls.Add(((labelWeight6[i, x] as Label)));



                    this.lableMarks6[i, x] = new Label();
                    System.Drawing.Point pmarkslab = new System.Drawing.Point(126 + x * 150, 200 + i * 140);
                    (lableMarks6[i, x] as Label).Location = pmarkslab;
                    (lableMarks6[i, x] as Label).Size = new System.Drawing.Size(50, 13);
                    (lableMarks6[i, x] as Label).Text = @"Mark:";
                    tabPageLevel6.Controls.Add(((lableMarks6[i, x] as Label)));

                    this.textBoxWeight6[i, x] = new NumericTextBox();
                    System.Drawing.Point pweigthbox = new System.Drawing.Point(190 + x * 150, 170 + i * 140);
                    (textBoxWeight6[i, x] as NumericTextBox).Location = pweigthbox;
                    (textBoxWeight6[i, x] as NumericTextBox).Size = new System.Drawing.Size(30, 20);
                    (textBoxWeight6[i, x] as NumericTextBox).Name = "0";
                    (textBoxWeight6[i, x] as NumericTextBox).Text = "0";
                    tabPageLevel6.Controls.Add(textBoxWeight6[i, x] as NumericTextBox);


                    this.textBoxMarks6[i, x] = new NumericTextBox();
                    System.Drawing.Point pbutt = new System.Drawing.Point(190 + x * 150, 200 + i * 140);
                    (textBoxMarks6[i, x] as NumericTextBox).Location = pbutt;
                    (textBoxMarks6[i, x] as NumericTextBox).Size = new System.Drawing.Size(30, 20);
                    (textBoxMarks6[i, x] as NumericTextBox).Text = "0";
                    (textBoxMarks6[i, x] as NumericTextBox).Name = "0";
                    (textBoxMarks6[i, x] as NumericTextBox).TextChanged += textBoxMarks6_TextChanged;
                    tabPageLevel6.Controls.Add(textBoxMarks6[i, x] as NumericTextBox);

                }

            }

        }


        List<double> level6 = new List<double>();
        List<double> modMark6 = new List<double>();

        //calculate level 6 average mark
        private void textBoxMarks6_TextChanged(object sender, EventArgs e)
        {

            if (myNumericUpDown6.Count != 0)
            {
                level6.Clear();
                double score = 0;
                double m = 0;
                double w = 0;
                double mm = 0;
                for (int i = 0; i < myNumericUpDown6.Count; i++)
                {
                    int lenght = (int)(this.myNumericUpDown6[i] as NumericUpDown).Value;

                    modMark6.Clear();
                    for (int x = 0; x < lenght; x++)
                    {

                        if (!String.IsNullOrEmpty((textBoxMarks6[i, x] as NumericTextBox).Text) && !String.IsNullOrEmpty((textBoxWeight6[i, x] as NumericTextBox).Text))
                        {

                            m = (Convert.ToInt32((textBoxMarks6[i, x] as NumericTextBox).Text));
                            w = (Convert.ToInt32((textBoxWeight6[i, x] as NumericTextBox).Text));
                            score = m * w / 100;
                            modMark6.Add(score);


                        }

                    } mm = (modMark6.Sum());
                    level6.Add(mm);
                    labelAvg6.Text = Math.Round((level6.Average()), 1).ToString() + " %";
                    level6sum.Text = Math.Round((level6.Average()), 1).ToString() + " %";
                }

            }
        }

        //checks if user have selected course if not display message, and sets course name as title for rest of tabs
        private void button5_Click(object sender, EventArgs e)
        {


            if (comboBoxCourse.SelectedIndex > -1)
            {
                string acct = comboBoxCourse.SelectedItem.ToString();

                label5.Text = label6.Text = label7.Text = label8.Text = acct + " Course";

                tabControl1.SelectTab(1);
            }

            else
            {

                MessageBox.Show("You haven't selected course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        //when button get hit goes to next tab
        private void button6_Click(object sender, EventArgs e)
        {

            tabControl1.SelectTab(2);
        }

        //when button get hit goes to next tab
        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        //when button get hit goes to next tab
        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

         
        //DB connection
        //private void data()
        //{
        //    MySql.Data.MySqlClient.MySqlConnection conn;   // connection variable
        //    string myConnectionString;        // server connection details string
        //    MySqlDataReader rdr = null;       // variable to receive query results
        //    string ListString = "";           // string to build MessageBox contents into

        //    myConnectionString = "server=127.0.0.1;" +   //server
        //               "uid=root;pwd=;" +      // username/password
        //               "database=w1439058_0;";       // database name

        //    try
        //    {
        //        conn = new MySql.Data.MySqlClient.MySqlConnection();   // Connect to server and open the database:
        //        conn.ConnectionString = myConnectionString;
        //        conn.Open();

        //        string query = "SELECT mid, name  FROM Modules";  // the SQL query
        //        MySqlCommand cmd = new MySqlCommand(query, conn);
        //        rdr = cmd.ExecuteReader();

        //        while (rdr.Read())          // loop through all the query results, building a string
        //        {
        //            ListString = ListString + rdr.GetString(0) + ", " +           // 0 is 1st field of query (Surname)
        //                     rdr.GetString(1) + "  " + rdr.GetString(2) + "\n";  // 1 is 2nd (Forenames), etc.
        //        }
        //        conn.Close();                     // close the database
        //        MessageBox.Show(ListString);


        //        // show the listing in a MessageBox
        //    }  // try

        //    catch (MySql.Data.MySqlClient.MySqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }  // catch.  
        //}

        //when button get hit goes to previous tab
        private void button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        //when button get hit goes to previous tab
        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        //when button get hit goes to previous tab
        private void button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        //when button get hit goes to previous tab
        private void button15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        //calculation final degree
        private void prediction()
        {

            List<double> templist = new List<double>(level6);
            List<double> templist2 = new List<double>(level5);
            

            int selectedVal = 0;
            int selectedVal2 = 0;
            double temp = 0;
            double temp2 = 0;
            double a = 0;
            double b = 0;

            //findind best 105 of level 6
            for (int i = 0; i < level6.Count; i++)
            {
 
                selectedVal = ((comboBoxModule6[i] as ComboBox).SelectedItem as Item).Value;

                if (selectedVal == 30)
                {
                    temp = level6[i];
                    templist.Add(temp);

                }
                else if (selectedVal == 45)
                {
                    temp = level6[i];
                   
                        templist.Add(temp);
                        templist.Add(temp);
                   

                }
                


                templist.Sort();
                templist.Reverse();



            }

            //finding best 105 of level 5 & 6
            for (int i = 0; i < level5.Count; i++)
            {
                selectedVal2 = ((comboBoxModule5[i] as ComboBox).SelectedItem as Item).Value;

                if (selectedVal2 == 30)
                {
                    temp2 = level5[i];
                    templist2.Add(temp2);

                }

                templist2.Add(templist[templist.Count - 1]);
                templist.Remove(templist.Count - 1);

                a = templist.GetRange(0, (templist.Count - 1)).Average();

                templist2.Sort();
                templist2.Reverse();
                b = templist2.GetRange(0, (templist2.Count - 2)).Average();



            }

            labelA.Text = Math.Round(a,1).ToString() + " %";
            labelB.Text = Math.Round(b,1).ToString() + " %";

            //finding degree classification
            if (a >= 70 && b >= 60)
            {
                labeldegree.Text = "1st class degree";
                labeldegree.ForeColor = System.Drawing.Color.Green;
                labeldegree.Font = new Font("Arial", 24, FontStyle.Bold);
            }
            else if (a >= 60 && b >= 50)
            {
                labeldegree.Text = "Upper 2nd class degree ";
                labeldegree.ForeColor = System.Drawing.Color.Lime;
                labeldegree.Font = new Font("Arial", 24, FontStyle.Bold);

            }
            else if (a >= 50 && b >= 40)
            {
                labeldegree.Text = "Lower 2nd class degree";
                labeldegree.ForeColor = System.Drawing.Color.Yellow;
                labeldegree.Font = new Font("Arial", 24, FontStyle.Bold);
            }
            else if (a >= 40)
            {
                labeldegree.Text = "3rd class degree";
                labeldegree.ForeColor = System.Drawing.Color.Orange;
                labeldegree.Font = new Font("Arial", 24, FontStyle.Bold);
            }
            else
            {
                labeldegree.Text = "You Fail";
                labeldegree.ForeColor = System.Drawing.Color.Red;
                labeldegree.Font = new Font("Arial", 24, FontStyle.Bold);
            }

        }

        //when prediction button get pressed final grade get calculated
        private void button16_Click(object sender, EventArgs e)
        {
            prediction();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FormMain NewForm = new FormMain();
            NewForm.Show();
            this.Dispose(false);
        }

        //sets selected tab name in bold
        void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

            if (e.Index == tabControl1.SelectedIndex)
            {
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                    new Font(tabControl1.Font, FontStyle.Bold),
                    Brushes.Black,
                    new PointF(e.Bounds.X + 3, e.Bounds.Y + 3));
            }
            else
            {
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                    tabControl1.Font,
                    Brushes.Black,
                    new PointF(e.Bounds.X + 3, e.Bounds.Y + 3));
            }
        }


    }

}