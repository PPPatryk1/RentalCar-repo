namespace RentalCar
{
    partial class AdminPanel
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddNewCar = new System.Windows.Forms.Button();
            this.CarDataGrid = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.BrandTextBox = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.EngineCombo1 = new System.Windows.Forms.ComboBox();
            this.TransmissionCombo1 = new System.Windows.Forms.ComboBox();
            this.Transmission = new System.Windows.Forms.Label();
            this.EngineType = new System.Windows.Forms.Label();
            this.BootyCapacityUpDown = new System.Windows.Forms.NumericUpDown();
            this.DoorCombo1 = new System.Windows.Forms.ComboBox();
            this.DoorNumber = new System.Windows.Forms.Label();
            this.BootyCapacity = new System.Windows.Forms.Label();
            this.AvailablecheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Price = new System.Windows.Forms.Label();
            this.Confrim = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.EditingPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BootyCapacityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).BeginInit();
            this.EditingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNewCar
            // 
            this.AddNewCar.BackColor = System.Drawing.Color.Black;
            this.AddNewCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddNewCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddNewCar.Location = new System.Drawing.Point(27, 307);
            this.AddNewCar.Name = "AddNewCar";
            this.AddNewCar.Size = new System.Drawing.Size(132, 35);
            this.AddNewCar.TabIndex = 0;
            this.AddNewCar.Text = "Add New Car";
            this.AddNewCar.UseVisualStyleBackColor = false;
            this.AddNewCar.Click += new System.EventHandler(this.AddNewCar_Click);
            // 
            // CarDataGrid
            // 
            this.CarDataGrid.AllowUserToAddRows = false;
            this.CarDataGrid.AllowUserToDeleteRows = false;
            this.CarDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarDataGrid.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.CarDataGrid.Location = new System.Drawing.Point(12, 21);
            this.CarDataGrid.Name = "CarDataGrid";
            this.CarDataGrid.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CarDataGrid.Size = new System.Drawing.Size(765, 207);
            this.CarDataGrid.TabIndex = 2;
            this.CarDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarDataGrid_CellContentClick);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Black;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateButton.Location = new System.Drawing.Point(27, 348);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(135, 35);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update Car";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Black;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteButton.Location = new System.Drawing.Point(27, 389);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(135, 35);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete Car";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(90, 55);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(204, 20);
            this.ModelTextBox.TabIndex = 34;
            // 
            // BrandTextBox
            // 
            this.BrandTextBox.Location = new System.Drawing.Point(90, 29);
            this.BrandTextBox.Name = "BrandTextBox";
            this.BrandTextBox.Size = new System.Drawing.Size(204, 20);
            this.BrandTextBox.TabIndex = 33;
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(29, 58);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(36, 13);
            this.Model.TabIndex = 32;
            this.Model.Text = "Model";
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Location = new System.Drawing.Point(29, 32);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(35, 13);
            this.Brand.TabIndex = 31;
            this.Brand.Text = "Brand";
            // 
            // EngineCombo1
            // 
            this.EngineCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EngineCombo1.FormattingEnabled = true;
            this.EngineCombo1.Items.AddRange(new object[] {
            "petrol",
            "diesel",
            "electric",
            "hybrid"});
            this.EngineCombo1.Location = new System.Drawing.Point(91, 84);
            this.EngineCombo1.Name = "EngineCombo1";
            this.EngineCombo1.Size = new System.Drawing.Size(121, 21);
            this.EngineCombo1.TabIndex = 38;
            // 
            // TransmissionCombo1
            // 
            this.TransmissionCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransmissionCombo1.FormattingEnabled = true;
            this.TransmissionCombo1.Items.AddRange(new object[] {
            "manual",
            "automatic"});
            this.TransmissionCombo1.Location = new System.Drawing.Point(90, 111);
            this.TransmissionCombo1.Name = "TransmissionCombo1";
            this.TransmissionCombo1.Size = new System.Drawing.Size(121, 21);
            this.TransmissionCombo1.TabIndex = 37;
            // 
            // Transmission
            // 
            this.Transmission.AutoSize = true;
            this.Transmission.Location = new System.Drawing.Point(1, 114);
            this.Transmission.Name = "Transmission";
            this.Transmission.Size = new System.Drawing.Size(68, 13);
            this.Transmission.TabIndex = 36;
            this.Transmission.Text = "Transmission";
            // 
            // EngineType
            // 
            this.EngineType.AutoSize = true;
            this.EngineType.Location = new System.Drawing.Point(6, 87);
            this.EngineType.Name = "EngineType";
            this.EngineType.Size = new System.Drawing.Size(63, 13);
            this.EngineType.TabIndex = 35;
            this.EngineType.Text = "Engine type";
            // 
            // BootyCapacityUpDown
            // 
            this.BootyCapacityUpDown.Location = new System.Drawing.Point(416, 56);
            this.BootyCapacityUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BootyCapacityUpDown.Name = "BootyCapacityUpDown";
            this.BootyCapacityUpDown.Size = new System.Drawing.Size(120, 20);
            this.BootyCapacityUpDown.TabIndex = 42;
            // 
            // DoorCombo1
            // 
            this.DoorCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoorCombo1.FormattingEnabled = true;
            this.DoorCombo1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.DoorCombo1.Location = new System.Drawing.Point(416, 29);
            this.DoorCombo1.Name = "DoorCombo1";
            this.DoorCombo1.Size = new System.Drawing.Size(63, 21);
            this.DoorCombo1.TabIndex = 41;
            // 
            // DoorNumber
            // 
            this.DoorNumber.AutoSize = true;
            this.DoorNumber.Location = new System.Drawing.Point(333, 32);
            this.DoorNumber.Name = "DoorNumber";
            this.DoorNumber.Size = new System.Drawing.Size(68, 13);
            this.DoorNumber.TabIndex = 40;
            this.DoorNumber.Text = "Door number";
            // 
            // BootyCapacity
            // 
            this.BootyCapacity.AutoSize = true;
            this.BootyCapacity.Location = new System.Drawing.Point(329, 58);
            this.BootyCapacity.Name = "BootyCapacity";
            this.BootyCapacity.Size = new System.Drawing.Size(72, 13);
            this.BootyCapacity.TabIndex = 39;
            this.BootyCapacity.Text = "Boot capacity";
            // 
            // AvailablecheckBox
            // 
            this.AvailablecheckBox.AutoSize = true;
            this.AvailablecheckBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AvailablecheckBox.ForeColor = System.Drawing.Color.Black;
            this.AvailablecheckBox.Location = new System.Drawing.Point(416, 115);
            this.AvailablecheckBox.Name = "AvailablecheckBox";
            this.AvailablecheckBox.Size = new System.Drawing.Size(40, 17);
            this.AvailablecheckBox.TabIndex = 46;
            this.AvailablecheckBox.Text = "No";
            this.AvailablecheckBox.UseVisualStyleBackColor = false;
            this.AvailablecheckBox.CheckedChanged += new System.EventHandler(this.AvailablecheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Availability";
            // 
            // PriceNumericUpDown
            // 
            this.PriceNumericUpDown.Location = new System.Drawing.Point(416, 85);
            this.PriceNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PriceNumericUpDown.Name = "PriceNumericUpDown";
            this.PriceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.PriceNumericUpDown.TabIndex = 44;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(330, 87);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(71, 13);
            this.Price.TabIndex = 43;
            this.Price.Text = "Price (zł/day)";
            // 
            // Confrim
            // 
            this.Confrim.BackColor = System.Drawing.Color.Black;
            this.Confrim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Confrim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Confrim.Location = new System.Drawing.Point(326, 137);
            this.Confrim.Name = "Confrim";
            this.Confrim.Size = new System.Drawing.Size(75, 23);
            this.Confrim.TabIndex = 47;
            this.Confrim.Text = "Confrim";
            this.Confrim.UseVisualStyleBackColor = false;
            this.Confrim.Click += new System.EventHandler(this.Confrim_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Black;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cancel.Location = new System.Drawing.Point(219, 137);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 48;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // EditingPanel
            // 
            this.EditingPanel.Controls.Add(this.BrandTextBox);
            this.EditingPanel.Controls.Add(this.Cancel);
            this.EditingPanel.Controls.Add(this.Brand);
            this.EditingPanel.Controls.Add(this.Confrim);
            this.EditingPanel.Controls.Add(this.Model);
            this.EditingPanel.Controls.Add(this.AvailablecheckBox);
            this.EditingPanel.Controls.Add(this.ModelTextBox);
            this.EditingPanel.Controls.Add(this.label1);
            this.EditingPanel.Controls.Add(this.EngineType);
            this.EditingPanel.Controls.Add(this.PriceNumericUpDown);
            this.EditingPanel.Controls.Add(this.Transmission);
            this.EditingPanel.Controls.Add(this.Price);
            this.EditingPanel.Controls.Add(this.TransmissionCombo1);
            this.EditingPanel.Controls.Add(this.BootyCapacityUpDown);
            this.EditingPanel.Controls.Add(this.EngineCombo1);
            this.EditingPanel.Controls.Add(this.DoorCombo1);
            this.EditingPanel.Controls.Add(this.BootyCapacity);
            this.EditingPanel.Controls.Add(this.DoorNumber);
            this.EditingPanel.Location = new System.Drawing.Point(178, 289);
            this.EditingPanel.Name = "EditingPanel";
            this.EditingPanel.Size = new System.Drawing.Size(588, 176);
            this.EditingPanel.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Sorting by";
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
            this.comboBox1.Location = new System.Drawing.Point(279, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 51;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "All",
            "Only available",
            "Only unavailable"});
            this.comboBox2.Location = new System.Drawing.Point(406, 246);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 52;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditingPanel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CarDataGrid);
            this.Controls.Add(this.AddNewCar);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BootyCapacityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).EndInit();
            this.EditingPanel.ResumeLayout(false);
            this.EditingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewCar;
        private System.Windows.Forms.DataGridView CarDataGrid;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.ComboBox EngineCombo1;
        private System.Windows.Forms.ComboBox TransmissionCombo1;
        private System.Windows.Forms.Label Transmission;
        private System.Windows.Forms.Label EngineType;
        private System.Windows.Forms.NumericUpDown BootyCapacityUpDown;
        private System.Windows.Forms.ComboBox DoorCombo1;
        private System.Windows.Forms.Label DoorNumber;
        private System.Windows.Forms.Label BootyCapacity;
        private System.Windows.Forms.CheckBox AvailablecheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PriceNumericUpDown;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Button Confrim;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Panel EditingPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

