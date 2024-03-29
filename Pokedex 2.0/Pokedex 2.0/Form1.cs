﻿using System;
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
using System.Text.Json;
using System.Runtime.ConstrainedExecution;

namespace Pokedex
{
    enum Attacks
    {
        Attack, Sp_Attack, Defense, Sp_Defense
    }
    
    public partial class Form1 : Form
    {
        private int current;
        private int count;
        private Pokemon[] pokemons;

        public Form1()
        {
            InitializeComponent();
            current = 0;
            count = 0;
            currentLabel.Text = current.ToString();
            pokemons = new Pokemon[50];
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon.txt"))
            {
                StreamReader inFile = new StreamReader("Pokemon.txt");
                while (!inFile.EndOfStream)
                {
                    string S = inFile.ReadLine();
                    Pokemon p = JsonSerializer.Deserialize<Pokemon>(S);
                    pokemons[count] = p;
                    count++;
                }
                inFile.Close();
                ShowPokemon(pokemons[0]);
            }
            else
            {
                Pokemon p = new Pokemon(); 
                p.Name = "Pikachu";
                p.Type = "Electric";
                p.attackType = Attacks.Attack;
                p.Level = 18;
                p.HP = 43;
                p.Exp = 3003;
                p.Legendary = true;
                p.Shiny = false;
                p.Gen = 1;
                count = 1;
                pokemons[0] = p;
            }
        }
        public void Save()
        {
            UpdatePokemon();
            StreamWriter outFile = new System.IO.StreamWriter("Pokemon.txt");
            for (int i = 0; i < count; i++)
            {
                string jsonString = JsonSerializer.Serialize(pokemons[i]);
                outFile.WriteLine(jsonString);
            }
            outFile.Close();
        }

        public void UpdatePokemon()
        {
            Pokemon p = pokemons[current];
            if (p != null)
            {
                p.Name = nameTbox.Text;
                p.Type = TypeTbox.Text;
                p.Level = int.Parse(levelTbox.Text);
                p.attackType = (Attacks)Enum.Parse(typeof(Attacks), attackComboBox.Text);
                p.HP = int.Parse(hpTbox.Text);
                p.Exp = int.Parse(expTbox.Text);
                if (legendaryCbox.Checked)
                    p.Legendary = true;
                else
                    p.Legendary = false;
                if (shinyCbox.Checked)
                    p.Shiny = true;
                else
                    p.Shiny = false;
                p.Gen = int.Parse(genUpDown.Value.ToString());
            }

        }

        private Pokemon ReadPokemon(string s)
        {
            Pokemon p = JsonSerializer.Deserialize<Pokemon>(s);
            return p;
        }
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Save();
        }
        
        private void ShowPokemon(Pokemon p)
        {
            if (p != null)
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
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            //set this to 0
            Save();
            current = 0;
            currentLabel.Text = current.ToString();
            ShowPokemon(pokemons[current]);
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            //set this to count -1
            Save();
            current = count - 1;
            currentLabel.Text = current.ToString();
            ShowPokemon(pokemons[current]);
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            //set this to 0
            if (current > 0)
            {
                Save();
                //this line makes you a cool programmer!
                current--;
                currentLabel.Text = current.ToString();
                ShowPokemon(pokemons[current]);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (current < count - 1)
            {
                Save();
                current++;
                currentLabel.Text = current.ToString();
                ShowPokemon(pokemons[current]);
            }
        }
        private void Clear()
        {
            nameTbox.Text = "";
            TypeTbox.Text = "";
            levelTbox.Text = "";
            attackComboBox.Text = "";
            hpTbox.Text = "";
            expTbox.Text = "";
            legendaryCbox.Checked = false;
            shinyCbox.Checked = false;
            genUpDown.Value = 0;
        }
        private void newButton_Click(object sender, EventArgs e)
        {
            current = count;
            pokemons[current] = new Pokemon();
            count++;
            Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdatePokemon();
            Save();
        }
    }
    class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
        public Attacks attackType { get; set; }
        public int HP { get; set; }
        public int Exp { get; set; }
        public bool Legendary { get; set; }
        public bool Shiny { get; set; }
        public int Gen { get; set; }
    }
}