using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Leap_Year
{
    /*class MinusException : Exception
    {
        public MinusException()
        { }
    }*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long s1,s2;
            bool IsLeapYear;
            long year = 0;
            try
            {
                year = Convert.ToInt64(textBox1.Text);
                if (year <= 0)
                {

                    if (radioButton1.Checked || radioButton3.Checked)
                        throw new MinusException();
                }
                if (radioButton2.Checked)
                {
                    IsLeapYear = false;
                    GregorianCalendar gc = new GregorianCalendar(); 
                    if (DateTime.IsLeapYear((int)year)||gc.IsLeapYear((int)year))
                        IsLeapYear = true;
                    else
                        IsLeapYear = false;
                    if (IsLeapYear)
                        MessageBox.Show("Year " + year + " is a leap year", "Leap Year");
                    else
                        MessageBox.Show("Year " + year + " is not a leap year", "Leap Year");
                }
                
                if (radioButton5.Checked && year>0)
                {
                    IsLeapYear = false;
                    if (year % 4 == 0 && year % 100 != 0)
                        IsLeapYear = true;
                    if (year % 400 == 0)
                        IsLeapYear = true;
                    if (IsLeapYear)
                        MessageBox.Show("Year " + year + " is a leap year", "Leap Year");
                    else
                        MessageBox.Show("Year " + year + " is not a leap year", "Leap Year");
                }
                else if (year < 0 && radioButton5.Checked)
                    MessageBox.Show("Year must be positive","Error");
                if (radioButton1.Checked && year > 0)
                {
                    IsLeapYear = false;
                    s1 = (year + 2346) % 2820;
                    if (s1 == 0)
                    {
                        IsLeapYear = true;
                    }
                    else
                    {
                        s2 = s1 % 128;
                        switch (s2)
                        {
                            case 0:
                                IsLeapYear = true;
                                break;
                            case 5:
                                IsLeapYear = true;
                                break;
                            case 9:
                                IsLeapYear = true;
                                break;
                            case 13:
                                IsLeapYear = true;
                                break;
                            case 17:
                                IsLeapYear = true;
                                break;
                            case 21:
                                IsLeapYear = true;
                                break;
                            case 25:
                                IsLeapYear = true;
                                break;
                            case 29:
                                IsLeapYear = true;
                                break;
                            case 34:
                                IsLeapYear = true;
                                break;
                            case 38:
                                IsLeapYear = true;
                                break;
                            case 42:
                                IsLeapYear = true;
                                break;
                            case 46:
                                IsLeapYear = true;
                                break;
                            case 50:
                                IsLeapYear = true;
                                break;
                            case 54:
                                IsLeapYear = true;
                                break;
                            case 58:
                                IsLeapYear = true;
                                break;
                            case 62:
                                IsLeapYear = true;
                                break;
                            case 67:
                                IsLeapYear = true;
                                break;
                            case 71:
                                IsLeapYear = true;
                                break;
                            case 75:
                                IsLeapYear = true;
                                break;
                            case 79:
                                IsLeapYear = true;
                                break;
                            case 83:
                                IsLeapYear = true;
                                break;
                            case 87:
                                IsLeapYear = true;
                                break;
                            case 91:
                                IsLeapYear = true;
                                break;
                            case 95:
                                IsLeapYear = true;
                                break;
                            case 100:
                                IsLeapYear = true;
                                break;
                            case 104:
                                IsLeapYear = true;
                                break;
                            case 108:
                                IsLeapYear = true;
                                break;
                            case 112:
                                IsLeapYear = true;
                                break;
                            case 116:
                                IsLeapYear = true;
                                break;
                            case 120:
                                IsLeapYear = true;
                                break;
                            case 124:
                                IsLeapYear = true;
                                break;
                            default:
                                IsLeapYear = false;
                                break;
                        }
                    }

                    if (IsLeapYear)
                        MessageBox.Show("سال " + year + " کبیسه است", "سال کبیسه");
                    else
                        MessageBox.Show("سال " + year + " کبیسه نیست", "سال کبیسه");
                }
                if (radioButton3.Checked && year > 0)
                {
                    IsLeapYear = false;
                    s1 = year % 33;
                    switch (s1)
                    {
                        case 1:
                            IsLeapYear = true;
                            break;
                        case 5:
                            IsLeapYear = true;
                            break;
                        case 9:
                            IsLeapYear = true;
                            break;
                        case 13:
                            IsLeapYear = true;
                            break;
                        case 17:
                            IsLeapYear = true;
                            break;
                        case 22:
                            IsLeapYear = true;
                            break;
                        case 26:
                            IsLeapYear = true;
                            break;
                        case 30:
                            IsLeapYear = true;
                            break;

                    }
                    if (IsLeapYear)
                        MessageBox.Show("سال " + year + " کبیسه است", "سال کبیسه");
                    else
                        MessageBox.Show("سال " + year + " کبیسه نیست", "سال کبیسه");
                }
                if (radioButton4.Checked)
                {

                    IsLeapYear = false;
                    PersianCalendar ps = new PersianCalendar();
                    IsLeapYear = ps.IsLeapYear((int)year);
                    if (IsLeapYear)
                        MessageBox.Show("سال " + year + " کبیسه است", "سال کبیسه");
                    else
                        MessageBox.Show("سال " + year + " کبیسه نیست", "سال کبیسه");

                }

            }
            catch (OverflowException)
            {
                if (radioButton1.Checked || radioButton3.Checked)
                    MessageBox.Show("عدد وارد شده بسیار بزرگ است", "Error");
                if (radioButton5.Checked)
                    MessageBox.Show("Your Number is too great","Error");
                if (radioButton2.Checked)
                    MessageBox.Show("Your Year Number is greater than 9999", "Error");
                if (radioButton4.Checked)
                    MessageBox.Show("سال باید از 9378 کوچکتر باشد", "Error");
            }
            catch (FormatException)
            {
                if (radioButton1.Checked || radioButton3.Checked || radioButton4.Checked)
                    MessageBox.Show("ورودی معتبر نیست", "Error");
                if (radioButton2.Checked||radioButton5.Checked)
                    MessageBox.Show("Invalid Input", "Error");
            }
            catch (ArgumentOutOfRangeException)
            {
                if (radioButton2.Checked)
                    MessageBox.Show("Your Year Number must be between 1 to 9999", "Error");
                if (radioButton4.Checked)
                    MessageBox.Show("سال باید عددی طبیعی و کوچکتر از 9378 باشد", "Error");
            }
            catch (MinusException)
            {
                if (radioButton1.Checked || radioButton3.Checked)
                    MessageBox.Show("سال باید مثبت باشد", "Error");
                if (radioButton5.Checked)
                    MessageBox.Show("Year must be positive", "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;    
                this.Text = "سال کبیسه ";
                textBox1.Font = new Font("B Lotus", 12);
                button1.Font = new Font("B Lotus", 12);
                button1.Text = "کنترل";
          }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "سال کبیسه ";
            textBox1.Font = new Font("B Lotus", 12);
            button1.Font = new Font("B Lotus", 12);
            button1.Text = "کنترل";
            this.Font = new Font("B Lotus", 12);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Leap Year";
            textBox1.Font = new Font("Times New Roman", 12);
            button1.Font = new Font("Times New Roman", 12);
            button1.Text = "Check";
            this.Font = new Font("Times New Roman", 12);
            radioButton3.Font = new Font("B Lotus", 12);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "سال کبیسه ";
            textBox1.Font = new Font("B Lotus", 12);
            button1.Font = new Font("B Lotus", 12);
            button1.Text = "کنترل";
            this.Font = new Font("B Lotus", 12);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "سال کبیسه ";
            textBox1.Font = new Font("B Lotus", 12);
            button1.Font = new Font("B Lotus", 12);
            button1.Text = "کنترل";
            this.Font = new Font("B Lotus", 12);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Leap Year";
            textBox1.Font = new Font("Times New Roman", 12);
            button1.Font = new Font("Times New Roman", 12);
            button1.Text = "Check";
            this.Font = new Font("Times New Roman", 12);
            radioButton3.Font = new Font("B Lotus", 12);
        }


    }
}
