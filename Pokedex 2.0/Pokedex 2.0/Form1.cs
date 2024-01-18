using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex_2._0
{
    enum attack
    {
        Special_Attack, Special_Defense, Attack, Defense
    }
    struct pokemon
    {
        string name;
        string type;
        int level;
        attack attackType;
        int hp;
        int exp;
        bool legendary;
        bool shiny;
        int gen;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon.txt"))
            {
                StreamReader inFile = new StreamReader("Pokemon.txt");
                string S = inFile.ReadToEnd();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            debugTbox.Clear();
            debugTbox.Text += nameTbox.Text;
            debugTbox.Text += "|";
            debugTbox.Text += TypeTbox.Text;
            debugTbox.Text += "|";
            debugTbox.Text += levelTbox.Text;
            debugTbox.Text += "|";
            debugTbox.Text += shinyCbox.Checked;
            debugTbox.Text += "|";
            debugTbox.Text += legendaryCbox.Checked;
            debugTbox.Text += "|";
            debugTbox.Text += genUpDown.Value;
            debugTbox.Text += "|";
            debugTbox.Text += hpUpDown.Value;
            debugTbox.Text += "|";
            debugTbox.Text += expUpDown.Value;


        }
    }


}
