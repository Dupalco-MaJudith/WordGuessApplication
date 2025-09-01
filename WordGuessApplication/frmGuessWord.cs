using System.Text;

namespace WordGuessApplication
{
    public partial class frmGuessWord : Form
    {
        // The word to guess
        private string wordToGuess = "REVERIE";

        // StringBuilder for hidden word
        private StringBuilder revealedWord;
        public frmGuessWord()
        {
            InitializeComponent();

            // Initialize with underscores
            revealedWord = new StringBuilder(new string('_', wordToGuess.Length));
            lblWord.Text = revealedWord.ToString();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string userGuess = txtGuess.Text.Trim(); // String class usage

            if (string.IsNullOrEmpty(userGuess))
            {
                MessageBox.Show("Please enter a word!");
                return;
            }

            // Correct guess
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
                // Wrong guess → add to ListBox
                lstWrongGuesses.Items.Add(userGuess);

                MessageBox.Show("Wrong guess! Try again.");
                txtGuess.Clear();
            }
        }
    }
}
        
