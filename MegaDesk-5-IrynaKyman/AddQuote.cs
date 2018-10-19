using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace MegaDesk_5_IrynaKyman
{
    public partial class AddQuote : Form
    {

        string CustomerName = String.Empty;
        int DeskWidth = 0;
        int DeskDepth = 0;
        int Drawers = 0;
        DesktopMaterial DesktopMaterial;
        int RushOrderDays = 0;
        int DeskQuoteTotal = 0;

        public AddQuote()
        {
            InitializeComponent();

            List<DesktopMaterial> DesktopMaterialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            desktopMaterialBox.DataSource = DesktopMaterialList;

         }
        private void button1_Click(object sender, EventArgs e)
        {
            var MainMenuForm = (MainMenu)Tag;
            MainMenuForm.Show();
            Close();
        }

               
        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerName = CustomerNameTextBox.Text;
                DeskWidth = int.Parse(WidthTextBox.Text);
                DeskDepth = int.Parse(DepthTextBox.Text);
                Drawers = int.Parse(NumberOfDrawers.SelectedItem.ToString());
                DesktopMaterial = (DesktopMaterial)desktopMaterialBox.SelectedValue;
                if (rushThreeButton.Checked) {
                    RushOrderDays = 3;
                }
                if (rushFiveButton.Checked) {
                    RushOrderDays = 5;
                }
                if (rushSevenButton.Checked) {
                    RushOrderDays = 7;
                }

                DeskQuote NewQuote = new DeskQuote(CustomerName, DateTime.Now, DeskWidth, DeskDepth, Drawers, DesktopMaterial, RushOrderDays);
                DeskQuoteTotal = NewQuote.CalculateQuoteTotal();

                //build output string using csv

                var DeskRecord = CustomerName + "," + DateTime.Now + "," + DeskWidth + "," + DeskDepth + "," + Drawers + "," + DesktopMaterial + "," + RushOrderDays + "," + DeskQuoteTotal;
                string cFile = @"quotes.txt";
                if (!File.Exists(cFile))
                {
                    using (StreamWriter sw = File.CreateText("quotes.txt")) { }
                }
                using (StreamWriter swa = File.AppendText("quotes.txt")) { swa.WriteLine(DeskRecord); }
                // display quote  

               // DeskQuoteView NewOrderView = new DeskQuoteView(NewQuote);

               // var MainMenu = (MainMenu)Tag;
                //{ Tag = MainMenu; };
                //NewOrderView.Show(MainMenu);
                //this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }  
        }

        private void WidthTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (int.TryParse(WidthTextBox.Text, out int WidthInput))
            {
                if (WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show("The width of the desk should be more than 24 and less than 96 inches");
                    WidthTextBox.Text = String.Empty;
                    WidthTextBox.Focus();

                }
                else
                { }
            }
        }

        private void DepthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }

}
