namespace RentalCar
{
    partial class CustomerPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CarDataGrid = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Contractsbutton = new System.Windows.Forms.Button();
            this.Accoptionsbutton = new System.Windows.Forms.Button();
            this.Messagesbutton = new System.Windows.Forms.Button();
            this.Historybutton = new System.Windows.Forms.Button();
            this.Rentbutton = new System.Windows.Forms.Button();
            this.Logoutbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CarDataGrid
            // 
            this.CarDataGrid.AllowUserToAddRows = false;
            this.CarDataGrid.AllowUserToDeleteRows = false;
            this.CarDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarDataGrid.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.CarDataGrid.Location = new System.Drawing.Point(12, 12);
            this.CarDataGrid.Name = "CarDataGrid";
            this.CarDataGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CarDataGrid.Size = new System.Drawing.Size(765, 243);
            this.CarDataGrid.TabIndex = 3;
            this.CarDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarDataGrid_CellContentClick);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "All",
            "Only available",
            "Only unavailable"});
            this.comboBox2.Location = new System.Drawing.Point(429, 261);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 55;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Price lowest",
            "Price highest",
            "Brand A-Z",
            "Brand Z-A",
            "Capacity lowest",
            "Capacity highest"});
            this.comboBox1.Location = new System.Drawing.Point(302, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 54;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Sorting by";
            // 
            // Contractsbutton
            // 
            this.Contractsbutton.BackColor = System.Drawing.Color.Black;
            this.Contractsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Contractsbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Contractsbutton.Location = new System.Drawing.Point(12, 349);
            this.Contractsbutton.Name = "Contractsbutton";
            this.Contractsbutton.Size = new System.Drawing.Size(132, 35);
            this.Contractsbutton.TabIndex = 56;
            this.Contractsbutton.Text = "Actual contracts";
            this.Contractsbutton.UseVisualStyleBackColor = false;
            // 
            // Accoptionsbutton
            // 
            this.Accoptionsbutton.BackColor = System.Drawing.Color.Black;
            this.Accoptionsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Accoptionsbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Accoptionsbutton.Location = new System.Drawing.Point(233, 349);
            this.Accoptionsbutton.Name = "Accoptionsbutton";
            this.Accoptionsbutton.Size = new System.Drawing.Size(132, 35);
            this.Accoptionsbutton.TabIndex = 57;
            this.Accoptionsbutton.Text = "Account options";
            this.Accoptionsbutton.UseVisualStyleBackColor = false;
            // 
            // Messagesbutton
            // 
            this.Messagesbutton.BackColor = System.Drawing.Color.Black;
            this.Messagesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Messagesbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Messagesbutton.Location = new System.Drawing.Point(429, 349);
            this.Messagesbutton.Name = "Messagesbutton";
            this.Messagesbutton.Size = new System.Drawing.Size(132, 35);
            this.Messagesbutton.TabIndex = 58;
            this.Messagesbutton.Text = "Messages";
            this.Messagesbutton.UseVisualStyleBackColor = false;
            // 
            // Historybutton
            // 
            this.Historybutton.BackColor = System.Drawing.Color.Black;
            this.Historybutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Historybutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Historybutton.Location = new System.Drawing.Point(12, 403);
            this.Historybutton.Name = "Historybutton";
            this.Historybutton.Size = new System.Drawing.Size(132, 35);
            this.Historybutton.TabIndex = 61;
            this.Historybutton.Text = "History";
            this.Historybutton.UseVisualStyleBackColor = false;
            // 
            // Rentbutton
            // 
            this.Rentbutton.BackColor = System.Drawing.Color.Black;
            this.Rentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Rentbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Rentbutton.Location = new System.Drawing.Point(12, 297);
            this.Rentbutton.Name = "Rentbutton";
            this.Rentbutton.Size = new System.Drawing.Size(132, 35);
            this.Rentbutton.TabIndex = 62;
            this.Rentbutton.Text = "Rent car";
            this.Rentbutton.UseVisualStyleBackColor = false;
            this.Rentbutton.Click += new System.EventHandler(this.Rentbutton_Click);
            // 
            // Logoutbutton
            // 
            this.Logoutbutton.BackColor = System.Drawing.Color.Black;
            this.Logoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logoutbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Logoutbutton.Location = new System.Drawing.Point(702, 403);
            this.Logoutbutton.Name = "Logoutbutton";
            this.Logoutbutton.Size = new System.Drawing.Size(75, 35);
            this.Logoutbutton.TabIndex = 63;
            this.Logoutbutton.Text = "Logout";
            this.Logoutbutton.UseVisualStyleBackColor = false;
            this.Logoutbutton.Click += new System.EventHandler(this.Logoutbutton_Click);
            // 
            // CustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logoutbutton);
            this.Controls.Add(this.Rentbutton);
            this.Controls.Add(this.Historybutton);
            this.Controls.Add(this.Messagesbutton);
            this.Controls.Add(this.Accoptionsbutton);
            this.Controls.Add(this.Contractsbutton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CarDataGrid);
            this.Name = "CustomerPanel";
            this.Text = "CustomerPanel";
            this.Load += new System.EventHandler(this.CustomerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CarDataGrid;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Contractsbutton;
        private System.Windows.Forms.Button Accoptionsbutton;
        private System.Windows.Forms.Button Messagesbutton;
        private System.Windows.Forms.Button Historybutton;
        private System.Windows.Forms.Button Rentbutton;
        private System.Windows.Forms.Button Logoutbutton;
    }
}