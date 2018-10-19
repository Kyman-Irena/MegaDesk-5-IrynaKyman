using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_5_IrynaKyman
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote AddQuoteForm = new AddQuote { Tag = this };
            AddQuoteForm.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAllQuotes AddViewAllQuotesForm = new ViewAllQuotes { Tag = this};
            AddViewAllQuotesForm.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchQuotes AddSearchQuotesForm = new SearchQuotes { Tag = this };
            AddSearchQuotesForm.Show(this);
            Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
