namespace MegaDesk_5_IrynaKyman
{
    partial class SearchQuotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SearchByMaterialBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchResultsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Return to the Main Screen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchByMaterialBox
            // 
            this.SearchByMaterialBox.FormattingEnabled = true;
            this.SearchByMaterialBox.Location = new System.Drawing.Point(328, 12);
            this.SearchByMaterialBox.Name = "SearchByMaterialBox";
            this.SearchByMaterialBox.Size = new System.Drawing.Size(152, 21);
            this.SearchByMaterialBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(530, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(122, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search by Material";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchResultsListView
            // 
            this.SearchResultsListView.FullRowSelect = true;
            this.SearchResultsListView.GridLines = true;
            this.SearchResultsListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SearchResultsListView.Location = new System.Drawing.Point(30, 60);
            this.SearchResultsListView.Name = "SearchResultsListView";
            this.SearchResultsListView.Size = new System.Drawing.Size(770, 192);
            this.SearchResultsListView.TabIndex = 3;
            this.SearchResultsListView.UseCompatibleStateImageBehavior = false;
            this.SearchResultsListView.View = System.Windows.Forms.View.Details;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchResultsListView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchByMaterialBox);
            this.Controls.Add(this.button1);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox SearchByMaterialBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListView SearchResultsListView;
    }
}