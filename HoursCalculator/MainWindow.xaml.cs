using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HoursCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string rwDirectory = "C:/Temp";
        private static string rwFile = "hoursCalculatorContents.txt";
        public MainWindow()
        {
            InitializeComponent();
            InitialiseImage();
            InitialiseBanner();
            InitialiseValues();
        }

        private void log(List<string> values)
        {
            System.IO.File.WriteAllText(rwDirectory + "\\" + rwFile, string.Empty);

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(rwDirectory + "\\" + rwFile))
            {
                foreach (string v in values)
                {
                    file.WriteLine(v);
                }
            }
        }

        private void InitialiseValues()
        {
            bool folderExists = Directory.Exists(rwDirectory);
            bool fileExists = File.Exists(rwDirectory + "\\" + rwFile);

            if (!folderExists)
                Directory.CreateDirectory(rwDirectory);
            if (!fileExists)
                File.Create(rwDirectory + "\\" + rwFile);

            if(folderExists && fileExists)
            {
                List<string> values = File.ReadAllLines(rwDirectory + "\\" + rwFile).ToList<string>();
                foreach(string value in values)
                {
                    string[] lineValues = value.Split(' ');
                    if(lineValues[0] == "MON:")
                    {
                        txt1.Text = (lineValues[1] == "NULL" ? "8.0" : lineValues[1]);
                        txtStart1.Text = (lineValues[2] == "NULL" ? "" : lineValues[2]);
                        txtFinish1.Text = (lineValues[3] == "NULL" ? "" : lineValues[3]);
                    }
                    else if (lineValues[0] == "TUES:")
                    {
                        txt2.Text = (lineValues[1] == "NULL" ? "8.0" : lineValues[1]);
                        txtStart2.Text = (lineValues[2] == "NULL" ? "" : lineValues[2]);
                        txtFinish2.Text = (lineValues[3] == "NULL" ? "" : lineValues[3]);
                    }
                    else if (lineValues[0] == "WED:")
                    {
                        txt3.Text = (lineValues[1] == "NULL" ? "8.0" : lineValues[1]);
                        txtStart3.Text = (lineValues[2] == "NULL" ? "" : lineValues[2]);
                        txtFinish3.Text = (lineValues[3] == "NULL" ? "" : lineValues[3]);
                    }
                    else if (lineValues[0] == "THURS:")
                    {
                        txt4.Text = (lineValues[1] == "NULL" ? "8.0" : lineValues[1]);
                        txtStart4.Text = (lineValues[2] == "NULL" ? "" : lineValues[2]);
                        txtFinish4.Text = (lineValues[3] == "NULL" ? "" : lineValues[3]);
                    }
                    else if (lineValues[0] == "FRI:")
                    {
                        txt5.Text = (lineValues[1] == "NULL" ? "8.0" : lineValues[1]);
                        txtStart5.Text = (lineValues[2] == "NULL" ? "" : lineValues[2]);
                        txtFinish5.Text = (lineValues[3] == "NULL" ? "" : lineValues[3]);
                    }
                }
            }
        }

        private void InitialiseBanner()
        {
            Random r = new Random();
            int rInt = r.Next(1, 3);
            string uri = "./Images/banner" + rInt + ".png";
            img3.Source = new BitmapImage(new Uri(uri, UriKind.Relative));
        }

        private void InitialiseImage()
        {
            Random r = new Random();
            int rInt = r.Next(1, 21);
            string uri = "./Images/" + rInt + ".jpg";
            img1.Source = new BitmapImage(new Uri(uri, UriKind.Relative));  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double total = 0;
            double remaining = 0;
            double mon = 0;
            double tues = 0;
            double wed = 0;
            double thurs = 0;
            double fri = 0;
            double.TryParse(txt1?.Text, out mon);
            double.TryParse(txt2?.Text, out tues);
            double.TryParse(txt3?.Text, out wed);
            double.TryParse(txt4?.Text, out thurs);
            double.TryParse(txt5?.Text, out fri);

            total = mon + tues + wed + thurs + fri;
            lbl1.Content = total + " hrs";

            remaining = 40 - total;
            if(remaining < 0)
                lbl2.Content = remaining + " hrs (Too many hours)";
            else
                lbl2.Content = remaining + " hrs"; 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InitialiseImage();
        }

        private string calculateHrsWorked(string startTime, string endTime)
        {
            int startTimeHrs = 0;
            int startTimeMins = 0;
            int finishTimeHrs = 0;
            int finishTimeMins = 0;

            if (startTime.Contains(":"))
            {
                int.TryParse(startTime.ToString().Split(':')[0], out startTimeHrs);
                int.TryParse(startTime.ToString().Split(':')[1], out startTimeMins);
            }
            if (endTime.Contains(":"))
            {
                int.TryParse(endTime.ToString().Split(':')[0], out finishTimeHrs);
                int.TryParse(endTime.ToString().Split(':')[1], out finishTimeMins);
            }

            int hrsWorked = (finishTimeHrs + 12) - startTimeHrs;
            int minsWorked = finishTimeMins - startTimeMins;

            if (Regex.IsMatch(startTime, "^([0-9]|0[0-9]|1?[0-9]|2[0-3]):[0-5]?[0-9]$") && Regex.IsMatch(endTime, "^([0-9]|0[0-9]|1?[0-9]|2[0-3]):[0-5]?[0-9]$") &&
                !hrsWorked.ToString().Contains("-") && !minsWorked.ToString().Contains("-"))
                return hrsWorked + "." + minsWorked;
            else return "8.0";
        }

        private void txtStart1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Mon Start
            if (txtStart1?.Text != null && txtStart1?.Text != "" && txt1?.Text != null && txt1?.Text != "")
            {
                txt1.Text = calculateHrsWorked(txtStart1.Text, txtFinish1.Text);
            }
        }

        private void txtFinish1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Mon Finish
            if(txtStart1?.Text != null && txtStart1?.Text != "" && txt1?.Text != null && txt1?.Text != "")
            {
                txt1.Text = calculateHrsWorked(txtStart1.Text, txtFinish1.Text);
            }
        }

        private void txtStart2_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Tues Start
            if (txtStart2?.Text != null && txtStart2?.Text != "" && txt2?.Text != null && txt2?.Text != "")
            {
                txt2.Text = calculateHrsWorked(txtStart2.Text, txtFinish2.Text);
            }
        }

        private void txtFinish2_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Tues Finish
            if (txtStart2?.Text != null && txtStart2?.Text != "" && txt2?.Text != null && txt2?.Text != "")
            {
                txt2.Text = calculateHrsWorked(txtStart2.Text, txtFinish2.Text);
            }
        }

        private void txtStart3_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Wed Start
            if (txtStart3?.Text != null && txtStart3?.Text != "" && txt3?.Text != null && txt3?.Text != "")
            {
                txt3.Text = calculateHrsWorked(txtStart3.Text, txtFinish3.Text);
            }
        }

        private void txtFinish3_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Wed Finish
            if (txtStart3?.Text != null && txtStart3?.Text != "" && txt3?.Text != null && txt3?.Text != "")
            {
                txt3.Text = calculateHrsWorked(txtStart3.Text, txtFinish3.Text);
            }
        }

        private void txtStart4_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Thurs Start
            if (txtStart4?.Text != null && txtStart4?.Text != "" && txt4?.Text != null && txt4?.Text != "")
            {
                txt4.Text = calculateHrsWorked(txtStart4.Text, txtFinish4.Text);
            }
        }

        private void txtFinish4_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Thurs Finish
            if (txtStart4?.Text != null && txtStart4?.Text != "" && txt4?.Text != null && txt4?.Text != "")
            {
                txt4.Text = calculateHrsWorked(txtStart4.Text, txtFinish4.Text);
            }
        }

        private void txtStart5_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Fri Start
            if (txtStart5?.Text != null && txtStart5?.Text != "" && txt5?.Text != null && txt5?.Text != "")
            {
                txt5.Text = calculateHrsWorked(txtStart5.Text, txtFinish5.Text);
            }
        }

        private void txtFinish5_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Fri Finish
            if (txtStart5?.Text != null && txtStart5?.Text != "" && txt5?.Text != null && txt5?.Text != "")
            {
                txt5.Text = calculateHrsWorked(txtStart5.Text, txtFinish5.Text);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Save Week
            List<string> values = new List<string>();
            string value = "";

            value = "MON: " + 
                (txt1.Text == "" ? "NULL" : txt1.Text) + " " + 
                (txtStart1.Text == "" ? "NULL" : txtStart1.Text) + " " + 
                (txtFinish1.Text == "" ? "NULL" : txtFinish1.Text);
            values.Add(value);

            value = "TUES: " + 
                (txt2.Text == "" ? "NULL" : txt2.Text) + " " + 
                (txtStart2.Text == "" ? "NULL" : txtStart2.Text) + " " + 
                (txtFinish2.Text == "" ? "NULL" : txtFinish2.Text);
            values.Add(value);

            value = "WED: " +
               (txt3.Text == "" ? "NULL" : txt3.Text) + " " +
               (txtStart3.Text == "" ? "NULL" : txtStart3.Text) + " " +
               (txtFinish3.Text == "" ? "NULL" : txtFinish3.Text);
            values.Add(value);

            value = "THURS: " +
                (txt4.Text == "" ? "NULL" : txt4.Text) + " " +
                (txtStart4.Text == "" ? "NULL" : txtStart4.Text) + " " +
                (txtFinish4.Text == "" ? "NULL" : txtFinish4.Text);
            values.Add(value);

            value = "FRI: " +
                (txt5.Text == "" ? "NULL" : txt5.Text) + " " +
                (txtStart5.Text == "" ? "NULL" : txtStart5.Text) + " " +
                (txtFinish5.Text == "" ? "NULL" : txtFinish5.Text);
            values.Add(value);

            log(values);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Mon
            txt1.Text = "8.0";
            txtStart1.Text = "";
            txtFinish1.Text = "";
            //Tues
            txt2.Text = "8.0";
            txtStart2.Text = "";
            txtFinish2.Text = "";
            //Wed
            txt3.Text = "8.0";
            txtStart3.Text = "";
            txtFinish3.Text = "";
            //Thurs
            txt4.Text = "8.0";
            txtStart4.Text = "";
            txtFinish4.Text = "";
            //Fri
            txt5.Text = "8.0";
            txtStart5.Text = "";
            txtFinish5.Text = "";

        }
    }
}
