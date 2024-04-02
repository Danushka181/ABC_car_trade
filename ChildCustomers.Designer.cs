namespace ABC_car_trade
{
    partial class ChildCustomers
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
            this.DataGridForCustomers = new System.Windows.Forms.DataGridView();
            this.CarsMainLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.refreshTable = new System.Windows.Forms.Button();
            this.SearchCustomers = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridForCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridForCustomers
            // 
            this.DataGridForCustomers.AllowUserToResizeColumns = false;
            this.DataGridForCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGridForCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataGridForCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.DataGridForCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridForCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridForCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridForCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridForCustomers.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridForCustomers.Location = new System.Drawing.Point(29, 89);
            this.DataGridForCustomers.Name = "DataGridForCustomers";
            this.DataGridForCustomers.Size = new System.Drawing.Size(1076, 413);
            this.DataGridForCustomers.TabIndex = 3;
            // 
            // CarsMainLabel
            // 
            this.CarsMainLabel.AutoSize = true;
            this.CarsMainLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsMainLabel.ForeColor = System.Drawing.Color.White;
            this.CarsMainLabel.Location = new System.Drawing.Point(23, 28);
            this.CarsMainLabel.Name = "CarsMainLabel";
            this.CarsMainLabel.Size = new System.Drawing.Size(188, 32);
            this.CarsMainLabel.TabIndex = 4;
            this.CarsMainLabel.Text = "CUSTOMERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(805, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search";
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.btnDeleteRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRow.ForeColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRow.Location = new System.Drawing.Point(987, 517);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(118, 46);
            this.btnDeleteRow.TabIndex = 18;
            this.btnDeleteRow.Text = "Delete";
            this.btnDeleteRow.UseVisualStyleBackColor = false;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.DarkGray;
            this.editButton.Location = new System.Drawing.Point(849, 517);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(118, 46);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // refreshTable
            // 
            this.refreshTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.refreshTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshTable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.refreshTable.Location = new System.Drawing.Point(27, 517);
            this.refreshTable.Name = "refreshTable";
            this.refreshTable.Size = new System.Drawing.Size(118, 46);
            this.refreshTable.TabIndex = 15;
            this.refreshTable.Text = "Refresh";
            this.refreshTable.UseVisualStyleBackColor = false;
            this.refreshTable.Click += new System.EventHandler(this.refreshTable_Click);
            // 
            // SearchCustomers
            // 
            this.SearchCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.SearchCustomers.ForeColor = System.Drawing.Color.White;
            this.SearchCustomers.Location = new System.Drawing.Point(891, 39);
            this.SearchCustomers.Name = "SearchCustomers";
            this.SearchCustomers.Size = new System.Drawing.Size(214, 20);
            this.SearchCustomers.TabIndex = 13;
            this.SearchCustomers.TextChanged += new System.EventHandler(this.SearchCustomers_TextChanged);
            // 
            // ChildCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1134, 591);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.refreshTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchCustomers);
            this.Controls.Add(this.CarsMainLabel);
            this.Controls.Add(this.DataGridForCustomers);
            this.Name = "ChildCustomers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.ChildCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridForCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridForCustomers;
        private System.Windows.Forms.Label CarsMainLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button refreshTable;
        private System.Windows.Forms.TextBox SearchCustomers;
    }
}