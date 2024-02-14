using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planner
{
    
    enum Category { Work, School, Entertainment, Goal, Memory, }

    public partial class Form1 : Form
    {
        private Day[] days;
        private int count;
        private int current;
        string date;

        public Form1()
        {
            InitializeComponent();
            count = 0;
            current = 0;
            days = new Day[50];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Planner.txt"))
            {
                StreamReader infile = new StreamReader("Planner.txt");
                while (!infile.EndOfStream)
                {
                    string S = infile.ReadLine();
                    Day d = JsonSerializer.Deserialize<Day>(S);
                    days[count] = d;
                    count++;
                }
                infile.Close();
                DisplayDate(days[0]);
            }
            else
            {
                Day d = new Day();
                d.date = "12/14/24";
                d.notes = "Current Date";
                d.priority = 5;
                d.category = Category.School;
                d.done = false;
                days[0] = d; 
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            date = monthCalendar1.SelectionRange.Start.ToShortDateString();
            dateTbox.Text = date.ToString();
        }

        private void DisplayDate(Day d)
        {
            if (d != null)
            {
                dateTbox.Text = d.date;
                noteTbox.Text = d.notes;
                priorityUpDown.Value = d.priority;
                categoryCombox.Text = d.category.ToString();
                doneCheckBox.Checked = d.done;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //i < 1, instead of i < count
            count++;
            UpdatePlans();
            StreamWriter outFile = new System.IO.StreamWriter("Planner.txt");
            for (int i = 0; i < 2; i++)
            {
                string jsonString = JsonSerializer.Serialize(days[i]);
                outFile.WriteLine(jsonString);
            }
            outFile.Close();
        }

        private void UpdatePlans()
        {
            //WARNING NOT SET TO CURRENT, NEED A WAY TO MAKE CURRENT!!
            //Currently sets current to debugtextbox, which can be set while running the program
            //current = int.Parse(debugTbox.Text.ToString());
            days[1] = new Day();
            Day d = days[1];

            if (d != null)
            {
                d.date = dateTbox.Text.ToString();
                d.notes = noteTbox.Text.ToString();
                d.priority = int.Parse(priorityUpDown.Value.ToString());
                d.category = (Category)Enum.Parse(typeof(Category), categoryCombox.Text.ToString());
                    //Set "done" true or false
                if (doneCheckBox.Checked)
                    d.done = true;
                else
                    d.done = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int date = int.Parse(debugTbox.Text);

            DisplayDate(days[date]);
        }
    }

    class Day
    {
        public string date { get; set; }
        public string notes { get; set; }
        public int priority { get; set; }
        public Category category { get; set; }
        public bool done { get; set; }
    }

}
