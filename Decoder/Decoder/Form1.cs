using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            encTbox.Text = "";
            decTbox.Text = "";
        }


        private void decTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'a':
                    encTbox.Text += "@";
                    break;
                case 'b':
                    encTbox.Text += "8";
                    break;
                case 'c':
                    encTbox.Text += "[";
                    break;
                case 'd':
                    encTbox.Text += "9";
                    break;
                case 'e':
                    encTbox.Text += "#";
                    break;
                case 'f':
                    encTbox.Text += "<";
                    break;
                case 'g':
                    encTbox.Text += "6";
                    break;
                case 'h':
                    encTbox.Text += "]";
                    break;
                case 'i':
                    encTbox.Text += "(";
                    break;
                case 'j':
                    encTbox.Text += "{";
                    break;
                case 'k':
                    encTbox.Text += "}";
                    break;
                case 'l':
                    encTbox.Text += "-";
                    break;
                case 'm':
                    encTbox.Text += "$";
                    break;
                case 'n':
                    encTbox.Text += "e";
                    break;
                case 'o':
                    encTbox.Text += "%";
                    break;
                case 'p':
                    encTbox.Text += "?";
                    break;
                case 'q':
                    encTbox.Text += "u";
                    break;
                case 'r':
                    encTbox.Text += "o";
                    break;
                case 's':
                    encTbox.Text += "^";
                    break;
                case 't':
                    encTbox.Text += "+";
                    break;
                case 'u':
                    encTbox.Text += "n ";
                    break;
                case 'v':
                    encTbox.Text += "w ";
                    break;
                case 'w':
                    encTbox.Text += "v";
                    break;
                case 'x':
                    encTbox.Text += "*";
                    break;
                case 'y':
                    encTbox.Text += "\\";
                    break;
                case 'z':
                    encTbox.Text += ">";
                    break;

                case ' ':
                    encTbox.Text += "  ";
                    break;

                default:
                    encTbox.Text += "";
                    break;
            }
        }

        private void encTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '@':
                    decTbox.Text += "a";
                    break;
                case '8':
                    decTbox.Text += "b";
                    break;
                case '[':
                    decTbox.Text += "c";
                    break;
                case '9':
                    decTbox.Text += "d";
                    break;
                case '#':
                    decTbox.Text += "e";
                    break;
                case '<':
                    decTbox.Text += "f";
                    break;
                case '6':
                    decTbox.Text += "g";
                    break;
                case ']':
                    decTbox.Text += "h";
                    break;
                case '(':
                    decTbox.Text += "i";
                    break;
                case '{':
                    decTbox.Text += "j";
                    break;
                case '}':
                    decTbox.Text += "k";
                    break;
                case '-':
                    decTbox.Text += "l";
                    break;
                case '$':
                    decTbox.Text += "m";
                    break;
                case 'e':
                    decTbox.Text += "n";
                    break;
                case '%':
                    decTbox.Text += "o";
                    break;
                case '?':
                    decTbox.Text += "p";
                    break;
                case 'u':
                    decTbox.Text += "q";
                    break;
                case 'o':
                    decTbox.Text += "r";
                    break;
                case '^':
                    decTbox.Text += "s";
                    break;
                case '+':
                    decTbox.Text += "t";
                    break;
                case 'n':
                    decTbox.Text += "u";
                    break;
                case 'w':
                    decTbox.Text += "v";
                    break;
                case 'v':
                    decTbox.Text += "w";
                    break;
                case '*':
                    decTbox.Text += "x";
                    break;
                case '\\':
                    decTbox.Text += "y";
                    break;
                case '>':
                    decTbox.Text += "z";
                    break;
                case ' ':
                    decTbox.Text += "  ";
                    break;

                default:
                    decTbox.Text += "";
                    break;
            }
        }
    }
}
