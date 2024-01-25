using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    enum Attacks
    {
        Attack, Sp_Attack, Defense, Sp_Defense
    }
    struct Pokemon
    {
        public string Name;
        public string Type;
        public int Level;
        public Attacks attackType;
        public int HP;
        public int Exp;
        public bool Legendary;
        public bool Shiny;
        public int Gen;
    }
    public partial class Form1 : Form
    {
        private int current;
        private int last;

        public Form1()
        {
            InitializeComponent();
            current = 0;
            last = 0;
            currentLabel.Text = current.ToString();
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon.txt"))
            {
                StreamReader inFile = new StreamReader("Pokemon.txt");
                while (!inFile.EndOfStream)
                {
                    string S = inFile.ReadLine();
                    Pokemon p = ReadPokemon(S);
                    ShowPokemon(p);
                    last++;
                }
                inFile.Close();
            }
        }

        private Pokemon ReadPokemon(string s)
        {
            Pokemon p = new Pokemon();
            string[] fields = s.Split('|');
            p.Name = fields[0];
            p.Type = fields[1];
            p.Level = int.Parse(fields[2]);
            p.attackType = (Attacks)Enum.Parse(typeof(Attacks), fields[3]);
            p.HP = int.Parse(fields[4]);
            p.Exp = int.Parse(fields[5]);
            if (fields[6] == "True")
                p.Legendary = true;
            else
                p.Legendary = false;
            if (fields[7] == "True")
                p.Shiny = true;
            else
                p.Shiny = false;
            p.Gen = int.Parse(fields[8]);

            return p;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            debugTbox.Text += nameTbox.Text;
            debugTbox.Text += "|";
            debugTbox.Text += TypeTbox.Text;
            debugTbox.Text += "|";
            debugTbox.Text += levelTbox.Text;
            debugTbox.Text += "|";
            debugTbox.Text +=  attackComboBox.Text;
            debugTbox.Text += "|";
            debugTbox.Text += hpTbox.Text;
            debugTbox.Text += "|";
            debugTbox.Text += expTbox.Text;
            debugTbox.Text += "|";
            debugTbox.Text += legendaryCbox.Checked;
            debugTbox.Text += "|";
            debugTbox.Text += shinyCbox.Checked;
            debugTbox.Text += "|";
            debugTbox.Text += genUpDown.Value;

            StreamWriter outFile = new StreamWriter("Pokemon.txt");
            outFile.Write(debugTbox.Text);
            outFile.Close();
        }
        
        private void ShowPokemon(Pokemon p)
        {
            nameTbox.Text = p.Name;
            TypeTbox.Text = p.Type;
            levelTbox.Text = p.Level.ToString();
            attackComboBox.Text = p.attackType.ToString();
            hpTbox.Text = p.HP.ToString();
            expTbox.Text = p.Exp.ToString();
            legendaryCbox.Checked = p.Legendary;
            shinyCbox.Checked = p.Shiny;
            genUpDown.Value = p.Gen;
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            current = 1;
            currentLabel.Text = current.ToString();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            current = last;
            currentLabel.Text = current.ToString();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (current > 1)
            {
                //this line makes you a cool programmer!
                current--;
                currentLabel.Text = current.ToString();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (current < last)
            {
                current++;
                currentLabel.Text = current.ToString();
            }
        }
    }
}