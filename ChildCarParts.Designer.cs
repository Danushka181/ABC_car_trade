namespace ABC_car_trade
{
    partial class ChildCarParts
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
            this.DataGridForCarParts = new System.Windows.Forms.DataGridView();
            this.refreshTable = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.btnAddNewCar = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.SearchCars = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridForCarParts)).BeginInit();
            this.SuspendLayout();
            // 
            // CarsMainLabel
            // 
            this.CarsMainLabel.AutoSize = true;
            this.CarsMainLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsMainLabel.ForeColor = System.Drawing.Color.White;
            this.CarsMainLabel.Location = new System.Drawing.Point(23, 32);
            this.CarsMainLabel.Name = "CarsMainLabel";
            this.CarsMainLabel.Size = new System.Drawing.Size(172, 32);
            this.CarsMainLabel.TabIndex = 1;
            this.CarsMainLabel.Text = "CAR PARTS";
            // 
            // DataGridForCarParts
            // 
            this.DataGridForCarParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGridForCarParts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataGridForCarParts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.DataGridForCarParts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridForCarParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridForCarParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridForCarParts.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridForCarParts.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridForCarParts.Location = new System.Drawing.Point(29, 89);
            this.DataGridForCarParts.Name = "DataGridForCarParts";
            this.DataGridForCarParts.Size = new System.Drawing.Size(1076, 413);
            this.DataGridForCarParts.TabIndex = 2;
            // 
            // refreshTable
            // 
            this.refreshTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.refreshTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshTable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.refreshTable.Location = new System.Drawing.Point(29, 523);
            this.refreshTable.Name = "refreshTable";
            this.refreshTable.Size = new System.Drawing.Size(118, 46);
            this.refreshTable.TabIndex = 6;
            this.refreshTable.Text = "Refresh";
            this.refreshTable.UseVisualStyleBackColor = false;
            this.refreshTable.Click += new System.EventHandler(this.refreshTable_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.DarkGray;
            this.editButton.Location = new System.Drawing.Point(652, 523);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(118, 46);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.btnAddNewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCar.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCar.Location = new System.Drawing.Point(937, 523);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(168, 46);
            this.btnAddNewCar.TabIndex = 9;
            this.btnAddNewCar.Text = "Add New Part";
            this.btnAddNewCar.UseVisualStyleBackColor = false;
            this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.btnDeleteRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRow.ForeColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRow.Location = new System.Drawing.Point(796, 523);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(118, 46);
            this.btnDeleteRow.TabIndex = 10;
            this.btnDeleteRow.Text = "Delete";
            this.btnDeleteRow.UseVisualStyleBackColor = false;
            // 
            // SearchCars
            // 
            this.SearchCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.SearchCars.ForeColor = System.Drawing.Color.White;
            this.SearchCars.Location = new System.Drawing.Point(891, 44);
            this.SearchCars.Name = "SearchCars";
            this.SearchCars.Size = new System.Drawing.Size(214, 20);
            this.SearchCars.TabIndex = 11;
            this.SearchCars.TextChanged += new System.EventHandler(this.SearchCars_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(805, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search";
            // 
            // ChildCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1134, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchCars);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnAddNewCar);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.refreshTable);
            this.Controls.Add(this.DataGridForCarParts);
            this.Controls.Add(this.CarsMainLabel);
            this.Name = "ChildCarParts";
            this.Text = "ChildCarParts";
            this.Load += new System.EventHandler(this.ChildCarParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridForCarParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CarsMainLabel;
        private System.Windows.Forms.DataGridView DataGridForCarParts;
        private System.Windows.Forms.Button refreshTable;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button btnAddNewCar;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.TextBox SearchCars;
        private System.Windows.Forms.Label label2;
    }
}