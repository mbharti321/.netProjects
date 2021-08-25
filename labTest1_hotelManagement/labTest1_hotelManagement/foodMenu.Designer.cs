
namespace labTest1_hotelManagement
{
    partial class formFoodMenu
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
            this.components = new System.ComponentModel.Container();
            this.Login = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnFoodMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboFoodtype = new System.Windows.Forms.ComboBox();
            this.richTextDescription = new System.Windows.Forms.RichTextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.manoCafeDataSet = new labTest1_hotelManagement.ManoCafeDataSet();
            this.food1947235BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.food1947235TableAdapter = new labTest1_hotelManagement.ManoCafeDataSetTableAdapters.Food1947235TableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.manoCafeDataSet1 = new labTest1_hotelManagement.ManoCafeDataSet1();
            this.food1947235BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.food1947235TableAdapter1 = new labTest1_hotelManagement.ManoCafeDataSet1TableAdapters.Food1947235TableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fooNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodFescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manoCafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food1947235BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manoCafeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food1947235BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Controls.Add(this.groupBox2);
            this.Login.Controls.Add(this.label3);
            this.Login.Controls.Add(this.groupBox1);
            this.Login.Controls.Add(this.label1);
            this.Login.Location = new System.Drawing.Point(63, 30);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(848, 494);
            this.Login.TabIndex = 2;
            this.Login.TabStop = false;
            this.Login.Enter += new System.EventHandler(this.Login_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.btnRooms);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.btnFoodMenu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 392);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(15, 243);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(128, 34);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.ForeColor = System.Drawing.Color.Black;
            this.btnRooms.Location = new System.Drawing.Point(15, 192);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(128, 34);
            this.btnRooms.TabIndex = 7;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(15, 79);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(128, 34);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnFoodMenu
            // 
            this.btnFoodMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFoodMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodMenu.ForeColor = System.Drawing.Color.Black;
            this.btnFoodMenu.Location = new System.Drawing.Point(15, 131);
            this.btnFoodMenu.Name = "btnFoodMenu";
            this.btnFoodMenu.Size = new System.Drawing.Size(128, 34);
            this.btnFoodMenu.TabIndex = 5;
            this.btnFoodMenu.Text = "Food Menu";
            this.btnFoodMenu.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Actions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mano Cafe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(362, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Food Menu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.richTextDescription);
            this.groupBox2.Controls.Add(this.comboFoodtype);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFoodName);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Location = new System.Drawing.Point(184, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 416);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Food Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Location = new System.Drawing.Point(24, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 49);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(244, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(136, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(6, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Food Name";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(101, 47);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(104, 20);
            this.txtFoodName.TabIndex = 0;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(242, 47);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(104, 20);
            this.txtPrice.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(356, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Food Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descriptions";
            // 
            // comboFoodtype
            // 
            this.comboFoodtype.FormattingEnabled = true;
            this.comboFoodtype.Items.AddRange(new object[] {
            "Veg",
            "Non-veg"});
            this.comboFoodtype.Location = new System.Drawing.Point(363, 48);
            this.comboFoodtype.Name = "comboFoodtype";
            this.comboFoodtype.Size = new System.Drawing.Size(103, 21);
            this.comboFoodtype.TabIndex = 7;
            // 
            // richTextDescription
            // 
            this.richTextDescription.Location = new System.Drawing.Point(483, 51);
            this.richTextDescription.Name = "richTextDescription";
            this.richTextDescription.Size = new System.Drawing.Size(169, 100);
            this.richTextDescription.TabIndex = 8;
            this.richTextDescription.Text = "";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Yellow;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(350, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // manoCafeDataSet
            // 
            this.manoCafeDataSet.DataSetName = "ManoCafeDataSet";
            this.manoCafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // food1947235BindingSource
            // 
            this.food1947235BindingSource.DataMember = "Food1947235";
            this.food1947235BindingSource.DataSource = this.manoCafeDataSet;
            // 
            // food1947235TableAdapter
            // 
            this.food1947235TableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(24, 46);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(60, 20);
            this.txtId.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fooNameDataGridViewTextBoxColumn,
            this.foodPriceDataGridViewTextBoxColumn,
            this.foodTypeDataGridViewTextBoxColumn,
            this.foodFescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.food1947235BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(27, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 223);
            this.dataGridView1.TabIndex = 12;
            // 
            // manoCafeDataSet1
            // 
            this.manoCafeDataSet1.DataSetName = "ManoCafeDataSet1";
            this.manoCafeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // food1947235BindingSource1
            // 
            this.food1947235BindingSource1.DataMember = "Food1947235";
            this.food1947235BindingSource1.DataSource = this.manoCafeDataSet1;
            // 
            // food1947235TableAdapter1
            // 
            this.food1947235TableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fooNameDataGridViewTextBoxColumn
            // 
            this.fooNameDataGridViewTextBoxColumn.DataPropertyName = "fooName";
            this.fooNameDataGridViewTextBoxColumn.HeaderText = "fooName";
            this.fooNameDataGridViewTextBoxColumn.Name = "fooNameDataGridViewTextBoxColumn";
            // 
            // foodPriceDataGridViewTextBoxColumn
            // 
            this.foodPriceDataGridViewTextBoxColumn.DataPropertyName = "foodPrice";
            this.foodPriceDataGridViewTextBoxColumn.HeaderText = "foodPrice";
            this.foodPriceDataGridViewTextBoxColumn.Name = "foodPriceDataGridViewTextBoxColumn";
            // 
            // foodTypeDataGridViewTextBoxColumn
            // 
            this.foodTypeDataGridViewTextBoxColumn.DataPropertyName = "foodType";
            this.foodTypeDataGridViewTextBoxColumn.HeaderText = "foodType";
            this.foodTypeDataGridViewTextBoxColumn.Name = "foodTypeDataGridViewTextBoxColumn";
            // 
            // foodFescriptionDataGridViewTextBoxColumn
            // 
            this.foodFescriptionDataGridViewTextBoxColumn.DataPropertyName = "foodFescription";
            this.foodFescriptionDataGridViewTextBoxColumn.HeaderText = "foodFescription";
            this.foodFescriptionDataGridViewTextBoxColumn.Name = "foodFescriptionDataGridViewTextBoxColumn";
            // 
            // formFoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 536);
            this.Controls.Add(this.Login);
            this.Name = "formFoodMenu";
            this.Text = "foodMenu";
            this.Load += new System.EventHandler(this.foodMenu_Load);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manoCafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food1947235BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manoCafeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food1947235BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnFoodMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextDescription;
        private System.Windows.Forms.ComboBox comboFoodtype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.Button btnRefresh;
        private ManoCafeDataSet manoCafeDataSet;
        private System.Windows.Forms.BindingSource food1947235BindingSource;
        private ManoCafeDataSetTableAdapters.Food1947235TableAdapter food1947235TableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ManoCafeDataSet1 manoCafeDataSet1;
        private System.Windows.Forms.BindingSource food1947235BindingSource1;
        private ManoCafeDataSet1TableAdapters.Food1947235TableAdapter food1947235TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fooNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodFescriptionDataGridViewTextBoxColumn;
    }
}