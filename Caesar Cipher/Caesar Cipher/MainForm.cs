using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Maintimer_Tick(object sender, EventArgs e)
        {
            //updating TypeOfCiphertrackBar value in TypeOfCaesarCipherlabel
            TypeOfCaesarCipherlabel.Text = TypeOfCiphertrackBar.Value.ToString();
            //making the users input into a charArray to be processed charater by character
            char[] inputedText = TextToBeCipheredrichTextBox.Text.ToCharArray();
                //creating a string to hold the dipher texted
                string newCipheredText = "";
                //going through all the characters in the array
                for (int x = 0; x < inputedText.Length; x++)
                {
                    //check if the character is a number
                    if (Char.IsDigit(inputedText[x]))
                    {
                        newCipheredText = "Invalid entry, Please check your message.";
                        break;
                    }
                    //else it is not a number
                    else
                    {
                        //getting the numerical value of the character
                        int charIndex = Character_Changer.AlphebetToIndex(inputedText[x]);
                        //adding the TypeOfCiphertrackBar value to the characters index
                        charIndex = charIndex + (TypeOfCiphertrackBar.Value);
                        //checking if the index is greater than or equal to 26 (if it is, then minus 26 so it can start from the beginning of the alphebet)
                        if (charIndex >= 26)
                        {
                            charIndex = charIndex - 26;
                        }
                        //get the new letter of the charIndex
                        char newIndex = Character_Changer.IndexToAlphebet(charIndex);
                        //adding the new character to the rest of the message
                        newCipheredText = newCipheredText + newIndex;
                    }

                }
                //setting the CipheredTextrichTestBox to the cipher text
                CipheredTextrichTextBox.Text = newCipheredText;
        }
        //Opening a new Form1
        private void newCaesarCipherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm settingForm = new MainForm();
            settingForm.Show();
        }
        //opening a new Helpform
        private void howDoesItWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm settingForm = new HelpForm();
            settingForm.Show();
        }
        //opening a new Updateform
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm settingForm = new UpdateForm();
            settingForm.Show();
        }

    }
}
