namespace ABC_car_trade
{
    partial class ChildCars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CarsMainLabel = new System.Windows.Forms.Label();
            this.DataGridForCars = new System.Windows.Forms.DataGridView();
            this.SearchCars = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewCar = new System.Windows.Forms.Button();
            this.refreshTable = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturing_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engine_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuel_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridForCars)).BeginInit();
            this.SuspendLayout();
            // 
            // CarsMainLabel
            // 
            this.CarsMainLabel.AutoSize = true;
            this.CarsMainLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsMainLabel.ForeColor = System.Drawing.Color.White;
            this.CarsMainLabel.Location = new System.Drawing.Point(23, 28);
            this.CarsMainLabel.Name = "CarsMainLabel";
            this.CarsMainLabel.Size = new System.Drawing.Size(91, 32);
            this.CarsMainLabel.TabIndex = 0;
            this.CarsMainLabel.Text = "CARS";
            this.CarsMainLabel.Click += new System.EventHandler(this.CarsMainLabel_Click);
            // 
            // DataGridForCars
            // 
            this.DataGridForCars.AllowUserToAddRows = false;
            this.DataGridForCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGridForCars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataGridForCars.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.DataGridForCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridForCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridForCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridForCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.make,
            this.model,
            this.manufacturing_year,
            this.price,
            this.color,
            this.engine_type,
            this.transmission,
            this.fuel_type,
            this.mileage,
            this.description});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridForCars.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridForCars.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridForCars.Location = new System.Drawing.Point(29, 79);
            this.DataGridForCars.Name = "DataGridForCars";
            this.DataGridForCars.Size = new System.Drawing.Size(1076, 413);
            this.DataGridForCars.TabIndex = 1;
            this.DataGridForCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridForCars_CellContentClick);
            // 
            // SearchCars
            // 
            this.SearchCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.SearchCars.ForeColor = System.Drawing.Color.White;
            this.SearchCars.Location = new System.Drawing.Point(891, 42);
            this.SearchCars.Name = "SearchCars";
            this.SearchCars.Size = new System.Drawing.Size(214, 20);
            this.SearchCars.TabIndex = 2;
            this.SearchCars.TextChanged += new System.EventHandler(this.SearchCars_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(808, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search";
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.btnAddNewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCar.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCar.Location = new System.Drawing.Point(937, 516);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(168, 46);
            this.btnAddNewCar.TabIndex = 4;
            this.btnAddNewCar.Text = "Add New Car";
            this.btnAddNewCar.UseVisualStyleBackColor = false;
            this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);
            // 
            // refreshTable
            // 
            this.refreshTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.refreshTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshTable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.refreshTable.Location = new System.Drawing.Point(29, 516);
            this.refreshTable.Name = "refreshTable";
            this.refreshTable.Size = new System.Drawing.Size(118, 46);
            this.refreshTable.TabIndex = 5;
            this.refreshTable.Text = "Refresh";
            this.refreshTable.UseVisualStyleBackColor = false;
            this.refreshTable.Click += new System.EventHandler(this.refreshTable_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.btnDeleteRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRow.ForeColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRow.Location = new System.Drawing.Point(792, 516);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(118, 46);
            this.btnDeleteRow.TabIndex = 6;
            this.btnDeleteRow.Text = "Delete";
            this.btnDeleteRow.UseVisualStyleBackColor = false;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.DarkGray;
            this.editButton.Location = new System.Drawing.Point(650, 516);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(118, 46);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 69;
            // 
            // make
            // 
            this.make.DataPropertyName = "make";
            this.make.HeaderText = "Make";
            this.make.Name = "make";
            this.make.Width = 94;
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            this.model.Width = 99;
            // 
            // manufacturing_year
            // 
            this.manufacturing_year.DataPropertyName = "manufacturing_year";
            this.manufacturing_year.HeaderText = "Year";
            this.manufacturing_year.Name = "manufacturing_year";
            this.manufacturing_year.Width = 87;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.Width = 92;
            // 
            // color
            // 
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.Width = 95;
            // 
            // engine_type
            // 
            this.engine_type.DataPropertyName = "engine_type";
            this.engine_type.HeaderText = "Engine (CC)";
            this.engine_type.Name = "engine_type";
            this.engine_type.Width = 135;
            // 
            // transmission
            // 
            this.transmission.DataPropertyName = "transmission";
            this.transmission.HeaderText = "Transmission";
            this.transmission.Name = "transmission";
            this.transmission.Width = 155;
            // 
            // fuel_type
            // 
            this.fuel_type.DataPropertyName = "fuel_type";
            this.fuel_type.HeaderText = "Fuel";
            this.fuel_type.Name = "fuel_type";
            this.fuel_type.Width = 85;
            // 
            // mileage
            // 
            this.mileage.DataPropertyName = "mileage";
            this.mileage.HeaderText = "Milage (KM)";
            this.mileage.Name = "mileage";
            this.mileage.Width = 134;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Details";
            this.description.Name = "description";
            this.description.Width = 105;
            // 
            // ChildCars
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1134, 591);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.refreshTable);
            this.Controls.Add(this.btnAddNewCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchCars);
            this.Controls.Add(this.DataGridForCars);
            this.Controls.Add(this.CarsMainLabel);
            this.Name = "ChildCars";
            this.Load += new System.EventHandler(this.ChildCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridForCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CarsMainLabel;
        private System.Windows.Forms.DataGridView DataGridForCars;
        private System.Windows.Forms.TextBox SearchCars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewCar;
        private System.Windows.Forms.Button refreshTable;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn make;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturing_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn engine_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuel_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}