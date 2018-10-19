namespace MegaDesk_5_IrynaKyman
{
    partial class AddQuote
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
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNamelb = new System.Windows.Forms.Label();
            this.Widthlb = new System.Windows.Forms.Label();
            this.Depthlb = new System.Windows.Forms.Label();
            this.DepthTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.rushThreeButton = new System.Windows.Forms.RadioButton();
            this.rushFiveButton = new System.Windows.Forms.RadioButton();
            this.rushSevenButton = new System.Windows.Forms.RadioButton();
            this.NumberOfDrawers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.desktopMaterialBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(173, 46);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.CustomerNameTextBox.TabIndex = 1;
            // 
            // CustomerNamelb
            // 
            this.CustomerNamelb.AutoSize = true;
            this.CustomerNamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerNamelb.Location = new System.Drawing.Point(35, 45);
            this.CustomerNamelb.Name = "CustomerNamelb";
            this.CustomerNamelb.Size = new System.Drawing.Size(94, 15);
            this.CustomerNamelb.TabIndex = 2;
            this.CustomerNamelb.Text = "CustomerName";
            // 
            // Widthlb
            // 
            this.Widthlb.AutoSize = true;
            this.Widthlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Widthlb.Location = new System.Drawing.Point(37, 79);
            this.Widthlb.Name = "Widthlb";
            this.Widthlb.Size = new System.Drawing.Size(38, 15);
            this.Widthlb.TabIndex = 5;
            this.Widthlb.Text = "Width";
            // 
            // Depthlb
            // 
            this.Depthlb.AutoSize = true;
            this.Depthlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Depthlb.Location = new System.Drawing.Point(37, 122);
            this.Depthlb.Name = "Depthlb";
            this.Depthlb.Size = new System.Drawing.Size(40, 15);
            this.Depthlb.TabIndex = 6;
            this.Depthlb.Text = "Depth";
            // 
            // DepthTextBox
            // 
            this.DepthTextBox.Location = new System.Drawing.Point(173, 117);
            this.DepthTextBox.Name = "DepthTextBox";
            this.DepthTextBox.Size = new System.Drawing.Size(134, 20);
            this.DepthTextBox.TabIndex = 7;
            this.DepthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthTextBox_KeyPress);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.CausesValidation = false;
            this.WidthTextBox.Location = new System.Drawing.Point(173, 79);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(134, 20);
            this.WidthTextBox.TabIndex = 8;
            this.WidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthTextBox_Validating);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(38, 289);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(140, 63);
            this.CalculateBtn.TabIndex = 9;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // rushThreeButton
            // 
            this.rushThreeButton.AutoSize = true;
            this.rushThreeButton.Location = new System.Drawing.Point(38, 240);
            this.rushThreeButton.Name = "rushThreeButton";
            this.rushThreeButton.Size = new System.Drawing.Size(58, 17);
            this.rushThreeButton.TabIndex = 10;
            this.rushThreeButton.TabStop = true;
            this.rushThreeButton.Text = "3 Days";
            this.rushThreeButton.UseVisualStyleBackColor = true;
            // 
            // rushFiveButton
            // 
            this.rushFiveButton.AutoSize = true;
            this.rushFiveButton.Location = new System.Drawing.Point(173, 240);
            this.rushFiveButton.Name = "rushFiveButton";
            this.rushFiveButton.Size = new System.Drawing.Size(58, 17);
            this.rushFiveButton.TabIndex = 11;
            this.rushFiveButton.TabStop = true;
            this.rushFiveButton.Text = "5 Days";
            this.rushFiveButton.UseVisualStyleBackColor = true;
            // 
            // rushSevenButton
            // 
            this.rushSevenButton.AutoSize = true;
            this.rushSevenButton.Location = new System.Drawing.Point(310, 240);
            this.rushSevenButton.Name = "rushSevenButton";
            this.rushSevenButton.Size = new System.Drawing.Size(58, 17);
            this.rushSevenButton.TabIndex = 12;
            this.rushSevenButton.TabStop = true;
            this.rushSevenButton.Text = "7 Days";
            this.rushSevenButton.UseVisualStyleBackColor = true;
            // 
            // NumberOfDrawers
            // 
            this.NumberOfDrawers.FormattingEnabled = true;
            this.NumberOfDrawers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.NumberOfDrawers.Location = new System.Drawing.Point(173, 166);
            this.NumberOfDrawers.Name = "NumberOfDrawers";
            this.NumberOfDrawers.Size = new System.Drawing.Size(134, 21);
            this.NumberOfDrawers.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Drawers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Material";
            // 
            // desktopMaterialBox
            // 
            this.desktopMaterialBox.FormattingEnabled = true;
            this.desktopMaterialBox.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.desktopMaterialBox.Location = new System.Drawing.Point(173, 198);
            this.desktopMaterialBox.Name = "desktopMaterialBox";
            this.desktopMaterialBox.Size = new System.Drawing.Size(134, 21);
            this.desktopMaterialBox.TabIndex = 16;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 384);
            this.Controls.Add(this.desktopMaterialBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOfDrawers);
            this.Controls.Add(this.rushSevenButton);
            this.Controls.Add(this.rushFiveButton);
            this.Controls.Add(this.rushThreeButton);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.DepthTextBox);
            this.Controls.Add(this.Depthlb);
            this.Controls.Add(this.Widthlb);
            this.Controls.Add(this.CustomerNamelb);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.button1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label CustomerNamelb;
        private System.Windows.Forms.Label Widthlb;
        private System.Windows.Forms.Label Depthlb;
        private System.Windows.Forms.TextBox DepthTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.RadioButton rushThreeButton;
        private System.Windows.Forms.RadioButton rushFiveButton;
        private System.Windows.Forms.RadioButton rushSevenButton;
        private System.Windows.Forms.ComboBox NumberOfDrawers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox desktopMaterialBox;
    }
}