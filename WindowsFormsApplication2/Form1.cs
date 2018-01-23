using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using JR.Utils.GUI.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        //Variables, custom font, etc. 
        String[] to_exclude = { ",", ".", ":", "-", "\r\n", "=", " ", "(", ")", '"'.ToString(), "<", ">", };
        OpenFileDialog ofd = new OpenFileDialog();
        String file_contents;
        bool file_loaded = false;
        Font font = new Font(
            "Courier New",
            10, 
            FontStyle.Regular,
            GraphicsUnit.Point
            );


        public Form1()
        {
            InitializeComponent();
        }

        //For loading in the file itself
        private void ofd_button_Click(object sender, EventArgs e)
        {
            ofd.Filter = "txt files (*.txt)|*.txt";
            ofd.InitialDirectory = "c:\\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((ofd.OpenFile()) != null)
                    {
                        using (StreamReader sr = new StreamReader(ofd.FileName))
                        {
                            String text = sr.ReadToEnd();
                            file_contents = text;
                            file_loaded = true;
                            loaded_file_display.Text = "Loaded file: " + ofd.SafeFileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        //This is what happens if you hit "Analyze"
        private void Start_Click(object sender, EventArgs e)
        {
            if (file_loaded)
            {
                file_length.Text = "Total signs in file: " + file_contents.Length.ToString();
                spaces_display.Text = "Spaces: " + file_contents.Split(' ').Length;
                show_frequenzy.Enabled = true;
                pBar1.Enabled = true;
                pBar1.Maximum = file_contents.Length;
            }
            else
            {
                MessageBox.Show("Error: Load file first");
            }
        }

        //Returns the total amount of times a letter has been used in the input file
        internal Letter[] get_letter_frequenzy (String input) 
        {
            List<Letter> letters = new List<Letter>();
            try
            {
                letters.Add(new Letter() { letter = input[0], count = 1 });
                for ( int i = 1; i < input.Length; i++) {
                    bool need_to_add = true;
                    foreach (Letter l in letters)
                    {
                        if (to_exclude.Contains(input[i].ToString())) //Excludes any Strings from the exclude array
                        {
                            need_to_add = false;
                            continue;
                        }
                        if (input[i] == l.letter)
                        {
                            l.count++;
                            need_to_add = false;
                        }
                    }
                    if (need_to_add)
                    {
                        letters.Add(new Letter { letter = input[i], count = 1 });
                    }
                    pBar1.PerformStep();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Analysis failed. Error Code: " + e);
            }
            letters.Sort((x, y) => y.count.CompareTo(x.count));
            return letters.ToArray();
        }

        private void show_frequenzy_Click(object sender, EventArgs e)
        {
            FlexibleMessageBox.FONT = font;
            FlexibleMessageBox.Show(build_text(get_letter_frequenzy(file_contents.ToLower())));
            pBar1.Value = 0;
        }

        // Generates the text which will be displayed in the final Message box
        private String build_text (Letter[] input)
        {
            String return_text = "Letters by frequency: \r\n";
            foreach (Letter l in input)
            {
                return_text = return_text + l.letter + ": "
                    + percentage(l.count * 100 / (file_contents.Length - file_contents.Split(' ').Length)) + "% || " 
                    + l.count + " times total \r\n";
            }
            return return_text;
        }


        //Adds a "0" in front of the number if it is <10
        private String percentage (int number)
        {
            if (number < 10)
            {
                return "0" + number;
            }
            return number.ToString();
        }
    }
}
