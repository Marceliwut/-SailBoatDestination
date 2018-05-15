namespace SailboatDestinationWinForms
{
    public partial class SailboatDestination
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
            this.checkButton = new MetroFramework.Controls.MetroButton();
            this.typeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.difficultyComboBox = new MetroFramework.Controls.MetroComboBox();
            this.crewSizeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.budgetComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(337, 417);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(135, 23);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "Check";
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.ItemHeight = 23;
            this.typeComboBox.Items.AddRange(new object[] {
            "Relax",
            "Hardcore"});
            this.typeComboBox.Location = new System.Drawing.Point(366, 127);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 29);
            this.typeComboBox.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(270, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Crew size:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(276, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Difficulty:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(260, 137);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Cruise type:";
            // 
            // difficultyComboBox
            // 
            this.difficultyComboBox.FormattingEnabled = true;
            this.difficultyComboBox.ItemHeight = 23;
            this.difficultyComboBox.Items.AddRange(new object[] {
            "Newbie",
            "Normal",
            "Intermiediate",
            "Advanced",
            "Pro"});
            this.difficultyComboBox.Location = new System.Drawing.Point(366, 92);
            this.difficultyComboBox.Name = "difficultyComboBox";
            this.difficultyComboBox.Size = new System.Drawing.Size(121, 29);
            this.difficultyComboBox.Style = MetroFramework.MetroColorStyle.Red;
            this.difficultyComboBox.TabIndex = 9;
            this.difficultyComboBox.SelectedIndexChanged += new System.EventHandler(this.difficultyComboBox_SelectedIndexChanged);
            // 
            // crewSizeTextBox
            // 
            this.crewSizeTextBox.Location = new System.Drawing.Point(366, 60);
            this.crewSizeTextBox.Name = "crewSizeTextBox";
            this.crewSizeTextBox.Size = new System.Drawing.Size(121, 23);
            this.crewSizeTextBox.TabIndex = 10;
            // 
            // budgetComboBox
            // 
            this.budgetComboBox.FormattingEnabled = true;
            this.budgetComboBox.ItemHeight = 23;
            this.budgetComboBox.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "Medium",
            "High",
            "Expensive"});
            this.budgetComboBox.Location = new System.Drawing.Point(366, 162);
            this.budgetComboBox.Name = "budgetComboBox";
            this.budgetComboBox.Size = new System.Drawing.Size(121, 29);
            this.budgetComboBox.TabIndex = 12;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(283, 172);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Budget:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataName,
            this.Accuracy});
            this.dataGridView1.Location = new System.Drawing.Point(167, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 183);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // dataName
            // 
            this.dataName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataName.HeaderText = "Name:";
            this.dataName.Name = "dataName";
            // 
            // Accuracy
            // 
            this.Accuracy.HeaderText = "Accuracy";
            this.Accuracy.Name = "Accuracy";
            // 
            // SailboatDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.budgetComboBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.crewSizeTextBox);
            this.Controls.Add(this.difficultyComboBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.checkButton);
            this.Name = "SailboatDestination";
            this.Text = "Sailboat Destination";
            this.Load += new System.EventHandler(this.SailboatDestination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton checkButton;
        private MetroFramework.Controls.MetroComboBox typeComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox difficultyComboBox;
        private MetroFramework.Controls.MetroTextBox crewSizeTextBox;
        private MetroFramework.Controls.MetroComboBox budgetComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accuracy;
    }
}

