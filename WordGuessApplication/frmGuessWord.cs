using System.Text;

namespace WordGuessApplication
{
    public partial class frmGuessWord : Form
    {
   
        private string wordToGuess = "REVERIE";

        private StringBuilder revealedWord;
        public frmGuessWord()
        {
            InitializeComponent();
        
            revealedWord = new StringBuilder(new string('_', wordToGuess.Length));
            lblWord.Text = revealedWord.ToString();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string userGuess = txtGuess.Text.Trim(); 

            if (string.IsNullOrEmpty(userGuess))
            {
                MessageBox.Show("Please enter a word!");
                return;
            }

          
            if (userGuess.Equals(wordToGuess, StringComparison.OrdinalIgnoreCase))
            {
                revealedWord.Clear();
                revealedWord.Append(wordToGuess);

                lblWord.Text = revealedWord.ToString();
                MessageBox.Show("Correct guess!");

                txtGuess.Clear();
            }
            else
            {
               
                lstWrongGuesses.Items.Add(userGuess);

                MessageBox.Show("Wrong guess! Try again.");
                txtGuess.Clear();
            }
        }
    }
}
        
