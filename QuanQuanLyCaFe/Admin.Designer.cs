namespace QuanQuanLyCaFe
{
    partial class Admin
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
            tcAdmin = new TabControl();
            tpBill = new TabPage();
            panel2 = new Panel();
            dgvBill = new DataGridView();
            panel1 = new Panel();
            btnViewBill = new Button();
            dtpTodate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            tpFood = new TabPage();
            panel6 = new Panel();
            tbSearchFoodName = new TextBox();
            btnSearchFood = new Button();
            panel5 = new Panel();
            panel10 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label3 = new Label();
            panel9 = new Panel();
            cbFoodCategory = new ComboBox();
            label2 = new Label();
            panel8 = new Panel();
            label1 = new Label();
            tbFoodName = new TextBox();
            panel7 = new Panel();
            label5 = new Label();
            tbFoodid = new TextBox();
            panel4 = new Panel();
            btnShowFood = new Button();
            btnEditFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            panel3 = new Panel();
            dgvFood = new DataGridView();
            tpFoodCategory = new TabPage();
            panel11 = new Panel();
            btnCategoryShow = new Button();
            btnCategoryEdit = new Button();
            btnCategoryDetele = new Button();
            btnCategoruAdd = new Button();
            panel14 = new Panel();
            dgvCategory = new DataGridView();
            panel18 = new Panel();
            panel17 = new Panel();
            label9 = new Label();
            tbCategoryName = new TextBox();
            panel16 = new Panel();
            label7 = new Label();
            TbCategoryId = new TextBox();
            TpTable = new TabPage();
            panel12 = new Panel();
            BtnshowTable = new Button();
            btnEditTable = new Button();
            btnDeteleTable = new Button();
            btnAddTable = new Button();
            panel19 = new Panel();
            dgvTable = new DataGridView();
            panel21 = new Panel();
            panel22 = new Panel();
            label6 = new Label();
            tbNameTable = new TextBox();
            panel20 = new Panel();
            label4 = new Label();
            tbTableid = new TextBox();
            tpAccount = new TabPage();
            panel23 = new Panel();
            btnResetPassword = new Button();
            panel25 = new Panel();
            cbAccountType = new ComboBox();
            label11 = new Label();
            panel26 = new Panel();
            label12 = new Label();
            tbAccountDisplayName = new TextBox();
            panel27 = new Panel();
            label13 = new Label();
            tbAccountUsername = new TextBox();
            panel29 = new Panel();
            dgvAccount = new DataGridView();
            panel30 = new Panel();
            btnAccountShow = new Button();
            btnAccountEdit = new Button();
            btnAccountDetele = new Button();
            btnAccountAdd = new Button();
            label8 = new Label();
            btnAddCategory = new Button();
            tcAdmin.SuspendLayout();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            panel1.SuspendLayout();
            tpFood.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            tpFoodCategory.SuspendLayout();
            panel11.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            panel18.SuspendLayout();
            panel17.SuspendLayout();
            panel16.SuspendLayout();
            TpTable.SuspendLayout();
            panel12.SuspendLayout();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
            panel21.SuspendLayout();
            panel22.SuspendLayout();
            panel20.SuspendLayout();
            tpAccount.SuspendLayout();
            panel23.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            panel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            panel30.SuspendLayout();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpBill);
            tcAdmin.Controls.Add(tpFood);
            tcAdmin.Controls.Add(tpFoodCategory);
            tcAdmin.Controls.Add(TpTable);
            tcAdmin.Controls.Add(tpAccount);
            tcAdmin.Location = new Point(1, 0);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(885, 655);
            tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            tpBill.BackColor = Color.White;
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.ForeColor = SystemColors.ControlText;
            tpBill.Location = new Point(4, 29);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(877, 622);
            tpBill.TabIndex = 0;
            tpBill.Text = "Danh thu";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvBill);
            panel2.Location = new Point(7, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 574);
            panel2.TabIndex = 1;
            // 
            // dgvBill
            // 
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Location = new Point(3, 3);
            dgvBill.Name = "dgvBill";
            dgvBill.RowHeadersWidth = 51;
            dgvBill.Size = new Size(861, 568);
            dgvBill.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(btnViewBill);
            panel1.Controls.Add(dtpTodate);
            panel1.Controls.Add(dtpFromDate);
            panel1.Location = new Point(7, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 35);
            panel1.TabIndex = 0;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(388, 3);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(94, 29);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "Thống kê";
            btnViewBill.UseVisualStyleBackColor = true;
            // 
            // dtpTodate
            // 
            dtpTodate.Location = new Point(614, 5);
            dtpTodate.Name = "dtpTodate";
            dtpTodate.Size = new Size(250, 27);
            dtpTodate.TabIndex = 1;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(3, 3);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(250, 27);
            dtpFromDate.TabIndex = 0;
            // 
            // tpFood
            // 
            tpFood.BackColor = Color.White;
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 29);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(877, 622);
            tpFood.TabIndex = 1;
            tpFood.Text = "Thức ăn";
            // 
            // panel6
            // 
            panel6.Controls.Add(tbSearchFoodName);
            panel6.Controls.Add(btnSearchFood);
            panel6.Location = new Point(479, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(395, 71);
            panel6.TabIndex = 3;
            // 
            // tbSearchFoodName
            // 
            tbSearchFoodName.Location = new Point(3, 25);
            tbSearchFoodName.Name = "tbSearchFoodName";
            tbSearchFoodName.Size = new Size(292, 27);
            tbSearchFoodName.TabIndex = 2;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(301, 4);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(94, 67);
            btnSearchFood.TabIndex = 1;
            btnSearchFood.Text = "Tìm";
            btnSearchFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(479, 77);
            panel5.Name = "panel5";
            panel5.Size = new Size(395, 542);
            panel5.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Controls.Add(nmFoodPrice);
            panel10.Controls.Add(label3);
            panel10.Location = new Point(7, 228);
            panel10.Name = "panel10";
            panel10.Size = new Size(385, 69);
            panel10.TabIndex = 10;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(136, 22);
            nmFoodPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(246, 27);
            nmFoodPrice.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 16);
            label3.Name = "label3";
            label3.Size = new Size(57, 27);
            label3.TabIndex = 2;
            label3.Text = "Giá:";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbFoodCategory);
            panel9.Controls.Add(label2);
            panel9.Location = new Point(7, 153);
            panel9.Name = "panel9";
            panel9.Size = new Size(385, 69);
            panel9.TabIndex = 9;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(136, 18);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(245, 28);
            cbFoodCategory.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(132, 27);
            label2.TabIndex = 2;
            label2.Text = "Danh mục:";
            // 
            // panel8
            // 
            panel8.Controls.Add(label1);
            panel8.Controls.Add(tbFoodName);
            panel8.Location = new Point(7, 78);
            panel8.Name = "panel8";
            panel8.Size = new Size(385, 69);
            panel8.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(116, 27);
            label1.TabIndex = 2;
            label1.Text = "Tên món:";
            // 
            // tbFoodName
            // 
            tbFoodName.Location = new Point(136, 16);
            tbFoodName.Name = "tbFoodName";
            tbFoodName.Size = new Size(245, 27);
            tbFoodName.TabIndex = 1;
            tbFoodName.UseSystemPasswordChar = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(label5);
            panel7.Controls.Add(tbFoodid);
            panel7.Location = new Point(7, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(385, 69);
            panel7.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 16);
            label5.Name = "label5";
            label5.Size = new Size(41, 27);
            label5.TabIndex = 2;
            label5.Text = "ID:";
            // 
            // tbFoodid
            // 
            tbFoodid.Location = new Point(136, 16);
            tbFoodid.Name = "tbFoodid";
            tbFoodid.ReadOnly = true;
            tbFoodid.Size = new Size(245, 27);
            tbFoodid.TabIndex = 1;
            tbFoodid.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnShowFood);
            panel4.Controls.Add(btnEditFood);
            panel4.Controls.Add(btnDeleteFood);
            panel4.Controls.Add(btnAddFood);
            panel4.Location = new Point(5, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(468, 71);
            panel4.TabIndex = 1;
            // 
            // btnShowFood
            // 
            btnShowFood.BackColor = Color.Black;
            btnShowFood.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnShowFood.ForeColor = SystemColors.ButtonHighlight;
            btnShowFood.Location = new Point(348, 1);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(110, 67);
            btnShowFood.TabIndex = 3;
            btnShowFood.Text = "Xem";
            btnShowFood.UseVisualStyleBackColor = false;
            // 
            // btnEditFood
            // 
            btnEditFood.BackColor = Color.ForestGreen;
            btnEditFood.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnEditFood.ForeColor = SystemColors.ButtonHighlight;
            btnEditFood.Location = new Point(231, 0);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(110, 67);
            btnEditFood.TabIndex = 2;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = false;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.BackColor = Color.Red;
            btnDeleteFood.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteFood.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteFood.Location = new Point(117, 0);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(108, 67);
            btnDeleteFood.TabIndex = 1;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = false;
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.SandyBrown;
            btnAddFood.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAddFood.ForeColor = SystemColors.ButtonHighlight;
            btnAddFood.Location = new Point(6, 0);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(105, 67);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvFood);
            panel3.Location = new Point(5, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(468, 543);
            panel3.TabIndex = 0;
            // 
            // dgvFood
            // 
            dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.Location = new Point(3, 4);
            dgvFood.Name = "dgvFood";
            dgvFood.RowHeadersWidth = 51;
            dgvFood.Size = new Size(465, 534);
            dgvFood.TabIndex = 0;
            // 
            // tpFoodCategory
            // 
            tpFoodCategory.BackColor = Color.SeaShell;
            tpFoodCategory.Controls.Add(panel11);
            tpFoodCategory.Controls.Add(panel14);
            tpFoodCategory.Controls.Add(panel18);
            tpFoodCategory.Location = new Point(4, 29);
            tpFoodCategory.Name = "tpFoodCategory";
            tpFoodCategory.Padding = new Padding(3);
            tpFoodCategory.Size = new Size(877, 622);
            tpFoodCategory.TabIndex = 2;
            tpFoodCategory.Text = "Danh mục";
            // 
            // panel11
            // 
            panel11.Controls.Add(btnCategoryShow);
            panel11.Controls.Add(btnCategoryEdit);
            panel11.Controls.Add(btnCategoryDetele);
            panel11.Controls.Add(btnCategoruAdd);
            panel11.Location = new Point(4, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(468, 71);
            panel11.TabIndex = 13;
            // 
            // btnCategoryShow
            // 
            btnCategoryShow.Location = new Point(348, 1);
            btnCategoryShow.Name = "btnCategoryShow";
            btnCategoryShow.Size = new Size(110, 67);
            btnCategoryShow.TabIndex = 3;
            btnCategoryShow.Text = "Xem";
            btnCategoryShow.UseVisualStyleBackColor = true;
            // 
            // btnCategoryEdit
            // 
            btnCategoryEdit.Location = new Point(231, 0);
            btnCategoryEdit.Name = "btnCategoryEdit";
            btnCategoryEdit.Size = new Size(110, 67);
            btnCategoryEdit.TabIndex = 2;
            btnCategoryEdit.Text = "Sửa";
            btnCategoryEdit.UseVisualStyleBackColor = true;
            // 
            // btnCategoryDetele
            // 
            btnCategoryDetele.Location = new Point(116, 0);
            btnCategoryDetele.Name = "btnCategoryDetele";
            btnCategoryDetele.Size = new Size(108, 67);
            btnCategoryDetele.TabIndex = 1;
            btnCategoryDetele.Text = "Xóa";
            btnCategoryDetele.UseVisualStyleBackColor = true;
            // 
            // btnCategoruAdd
            // 
            btnCategoruAdd.Location = new Point(5, 0);
            btnCategoruAdd.Name = "btnCategoruAdd";
            btnCategoruAdd.Size = new Size(105, 67);
            btnCategoruAdd.TabIndex = 0;
            btnCategoruAdd.Text = "Thêm";
            btnCategoruAdd.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            panel14.Controls.Add(dgvCategory);
            panel14.Location = new Point(4, 78);
            panel14.Name = "panel14";
            panel14.Size = new Size(468, 543);
            panel14.TabIndex = 12;
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(3, 4);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.Size = new Size(465, 534);
            dgvCategory.TabIndex = 0;
            // 
            // panel18
            // 
            panel18.Controls.Add(panel17);
            panel18.Controls.Add(panel16);
            panel18.Location = new Point(478, 79);
            panel18.Name = "panel18";
            panel18.Size = new Size(395, 542);
            panel18.TabIndex = 14;
            // 
            // panel17
            // 
            panel17.Controls.Add(label9);
            panel17.Controls.Add(tbCategoryName);
            panel17.Location = new Point(7, 78);
            panel17.Name = "panel17";
            panel17.Size = new Size(385, 69);
            panel17.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 16);
            label9.Name = "label9";
            label9.Size = new Size(181, 27);
            label9.TabIndex = 2;
            label9.Text = "Tên Danh mục:";
            // 
            // tbCategoryName
            // 
            tbCategoryName.Location = new Point(178, 16);
            tbCategoryName.Name = "tbCategoryName";
            tbCategoryName.Size = new Size(203, 27);
            tbCategoryName.TabIndex = 1;
            tbCategoryName.UseSystemPasswordChar = true;
            // 
            // panel16
            // 
            panel16.Controls.Add(label7);
            panel16.Controls.Add(TbCategoryId);
            panel16.Location = new Point(7, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(385, 69);
            panel16.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 16);
            label7.Name = "label7";
            label7.Size = new Size(41, 27);
            label7.TabIndex = 2;
            label7.Text = "ID:";
            // 
            // TbCategoryId
            // 
            TbCategoryId.Location = new Point(178, 16);
            TbCategoryId.Name = "TbCategoryId";
            TbCategoryId.ReadOnly = true;
            TbCategoryId.Size = new Size(203, 27);
            TbCategoryId.TabIndex = 1;
            TbCategoryId.UseSystemPasswordChar = true;
            // 
            // TpTable
            // 
            TpTable.BackColor = Color.SeaShell;
            TpTable.Controls.Add(panel12);
            TpTable.Controls.Add(panel19);
            TpTable.Controls.Add(panel21);
            TpTable.Location = new Point(4, 29);
            TpTable.Name = "TpTable";
            TpTable.Padding = new Padding(3);
            TpTable.Size = new Size(877, 622);
            TpTable.TabIndex = 3;
            TpTable.Text = "Bàn ăn";
            // 
            // panel12
            // 
            panel12.Controls.Add(BtnshowTable);
            panel12.Controls.Add(btnEditTable);
            panel12.Controls.Add(btnDeteleTable);
            panel12.Controls.Add(btnAddTable);
            panel12.Location = new Point(4, 2);
            panel12.Name = "panel12";
            panel12.Size = new Size(468, 71);
            panel12.TabIndex = 9;
            // 
            // BtnshowTable
            // 
            BtnshowTable.Location = new Point(348, 1);
            BtnshowTable.Name = "BtnshowTable";
            BtnshowTable.Size = new Size(110, 67);
            BtnshowTable.TabIndex = 3;
            BtnshowTable.Text = "Xem";
            BtnshowTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            btnEditTable.Location = new Point(231, 0);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(110, 67);
            btnEditTable.TabIndex = 2;
            btnEditTable.Text = "Sửa";
            btnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnDeteleTable
            // 
            btnDeteleTable.Location = new Point(116, 0);
            btnDeteleTable.Name = "btnDeteleTable";
            btnDeteleTable.Size = new Size(108, 67);
            btnDeteleTable.TabIndex = 1;
            btnDeteleTable.Text = "Xóa";
            btnDeteleTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(5, 0);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(105, 67);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // panel19
            // 
            panel19.Controls.Add(dgvTable);
            panel19.Location = new Point(4, 78);
            panel19.Name = "panel19";
            panel19.Size = new Size(468, 543);
            panel19.TabIndex = 8;
            // 
            // dgvTable
            // 
            dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTable.Location = new Point(3, 4);
            dgvTable.Name = "dgvTable";
            dgvTable.RowHeadersWidth = 51;
            dgvTable.Size = new Size(465, 534);
            dgvTable.TabIndex = 0;
            // 
            // panel21
            // 
            panel21.Controls.Add(panel22);
            panel21.Controls.Add(panel20);
            panel21.Location = new Point(478, 79);
            panel21.Name = "panel21";
            panel21.Size = new Size(395, 542);
            panel21.TabIndex = 10;
            // 
            // panel22
            // 
            panel22.Controls.Add(label6);
            panel22.Controls.Add(tbNameTable);
            panel22.Location = new Point(7, 78);
            panel22.Name = "panel22";
            panel22.Size = new Size(385, 69);
            panel22.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 16);
            label6.Name = "label6";
            label6.Size = new Size(113, 27);
            label6.TabIndex = 2;
            label6.Text = "Tên Bàn:";
            // 
            // tbNameTable
            // 
            tbNameTable.Location = new Point(178, 16);
            tbNameTable.Name = "tbNameTable";
            tbNameTable.Size = new Size(203, 27);
            tbNameTable.TabIndex = 1;
            tbNameTable.UseSystemPasswordChar = true;
            // 
            // panel20
            // 
            panel20.Controls.Add(label4);
            panel20.Controls.Add(tbTableid);
            panel20.Location = new Point(7, 3);
            panel20.Name = "panel20";
            panel20.Size = new Size(385, 69);
            panel20.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(41, 27);
            label4.TabIndex = 2;
            label4.Text = "ID:";
            // 
            // tbTableid
            // 
            tbTableid.Location = new Point(178, 16);
            tbTableid.Name = "tbTableid";
            tbTableid.ReadOnly = true;
            tbTableid.Size = new Size(203, 27);
            tbTableid.TabIndex = 1;
            tbTableid.UseSystemPasswordChar = true;
            // 
            // tpAccount
            // 
            tpAccount.BackColor = Color.SeaShell;
            tpAccount.Controls.Add(panel23);
            tpAccount.Controls.Add(panel29);
            tpAccount.Controls.Add(panel30);
            tpAccount.Location = new Point(4, 29);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(877, 622);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Tài khoản";
            // 
            // panel23
            // 
            panel23.Controls.Add(btnResetPassword);
            panel23.Controls.Add(panel25);
            panel23.Controls.Add(panel26);
            panel23.Controls.Add(panel27);
            panel23.Location = new Point(478, 79);
            panel23.Name = "panel23";
            panel23.Size = new Size(395, 542);
            panel23.TabIndex = 6;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(282, 228);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(110, 67);
            btnResetPassword.TabIndex = 11;
            btnResetPassword.Text = "Đặt lại mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // panel25
            // 
            panel25.Controls.Add(cbAccountType);
            panel25.Controls.Add(label11);
            panel25.Location = new Point(7, 153);
            panel25.Name = "panel25";
            panel25.Size = new Size(385, 69);
            panel25.TabIndex = 9;
            // 
            // cbAccountType
            // 
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Location = new Point(174, 19);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(211, 28);
            cbAccountType.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 16);
            label11.Name = "label11";
            label11.Size = new Size(177, 27);
            label11.TabIndex = 2;
            label11.Text = "Loại tài khoản:";
            // 
            // panel26
            // 
            panel26.Controls.Add(label12);
            panel26.Controls.Add(tbAccountDisplayName);
            panel26.Location = new Point(7, 78);
            panel26.Name = "panel26";
            panel26.Size = new Size(385, 69);
            panel26.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 16);
            label12.Name = "label12";
            label12.Size = new Size(154, 27);
            label12.TabIndex = 2;
            label12.Text = "Tên hiên thị:";
            // 
            // tbAccountDisplayName
            // 
            tbAccountDisplayName.Location = new Point(174, 16);
            tbAccountDisplayName.Name = "tbAccountDisplayName";
            tbAccountDisplayName.Size = new Size(207, 27);
            tbAccountDisplayName.TabIndex = 1;
            tbAccountDisplayName.UseSystemPasswordChar = true;
            // 
            // panel27
            // 
            panel27.Controls.Add(label13);
            panel27.Controls.Add(tbAccountUsername);
            panel27.Location = new Point(7, 3);
            panel27.Name = "panel27";
            panel27.Size = new Size(385, 69);
            panel27.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(3, 16);
            label13.Name = "label13";
            label13.Size = new Size(172, 27);
            label13.TabIndex = 2;
            label13.Text = "Tên tài khoản:";
            // 
            // tbAccountUsername
            // 
            tbAccountUsername.Location = new Point(174, 16);
            tbAccountUsername.Name = "tbAccountUsername";
            tbAccountUsername.ReadOnly = true;
            tbAccountUsername.Size = new Size(207, 27);
            tbAccountUsername.TabIndex = 1;
            tbAccountUsername.UseSystemPasswordChar = true;
            // 
            // panel29
            // 
            panel29.Controls.Add(dgvAccount);
            panel29.Location = new Point(4, 78);
            panel29.Name = "panel29";
            panel29.Size = new Size(468, 543);
            panel29.TabIndex = 4;
            // 
            // dgvAccount
            // 
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Location = new Point(3, 4);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.Size = new Size(465, 534);
            dgvAccount.TabIndex = 0;
            // 
            // panel30
            // 
            panel30.Controls.Add(btnAccountShow);
            panel30.Controls.Add(btnAccountEdit);
            panel30.Controls.Add(btnAccountDetele);
            panel30.Controls.Add(btnAccountAdd);
            panel30.Location = new Point(4, 2);
            panel30.Name = "panel30";
            panel30.Size = new Size(468, 71);
            panel30.TabIndex = 5;
            // 
            // btnAccountShow
            // 
            btnAccountShow.Location = new Point(348, 1);
            btnAccountShow.Name = "btnAccountShow";
            btnAccountShow.Size = new Size(110, 67);
            btnAccountShow.TabIndex = 3;
            btnAccountShow.Text = "Xem";
            btnAccountShow.UseVisualStyleBackColor = true;
            // 
            // btnAccountEdit
            // 
            btnAccountEdit.Location = new Point(231, 0);
            btnAccountEdit.Name = "btnAccountEdit";
            btnAccountEdit.Size = new Size(110, 67);
            btnAccountEdit.TabIndex = 2;
            btnAccountEdit.Text = "Sửa";
            btnAccountEdit.UseVisualStyleBackColor = true;
            // 
            // btnAccountDetele
            // 
            btnAccountDetele.Location = new Point(117, 0);
            btnAccountDetele.Name = "btnAccountDetele";
            btnAccountDetele.Size = new Size(108, 67);
            btnAccountDetele.TabIndex = 1;
            btnAccountDetele.Text = "Xóa";
            btnAccountDetele.UseVisualStyleBackColor = true;
            // 
            // btnAccountAdd
            // 
            btnAccountAdd.Location = new Point(6, 0);
            btnAccountAdd.Name = "btnAccountAdd";
            btnAccountAdd.Size = new Size(105, 67);
            btnAccountAdd.TabIndex = 0;
            btnAccountAdd.Text = "Thêm";
            btnAccountAdd.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 0;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(5, 0);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(105, 67);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 655);
            Controls.Add(tcAdmin);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            tcAdmin.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            panel1.ResumeLayout(false);
            tpFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
            tpFoodCategory.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            panel18.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            TpTable.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
            panel21.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            tpAccount.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            panel30.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tpBill;
        private TabPage tpFood;
        private TabPage tpFoodCategory;
        private TabPage TpTable;
        private TabPage tpAccount;
        private Panel panel2;
        private DataGridView dgvBill;
        private Panel panel1;
        private DateTimePicker dtpFromDate;
        private Button btnViewBill;
        private DateTimePicker dtpTodate;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private DataGridView dgvFood;
        private Button btnShowFood;
        private Button btnEditFood;
        private TextBox tbSearchFoodName;
        private Button btnSearchFood;
        private Panel panel8;
        private Label label1;
        private TextBox tbFoodName;
        private Panel panel7;
        private Label label5;
        private TextBox tbFoodid;
        private Panel panel10;
        private NumericUpDown nmFoodPrice;
        private Label label3;
        private Panel panel9;
        private ComboBox cbFoodCategory;
        private Label label2;
        private Label label8;
        private TextBox tbNameTable;
        private Button BtnshowTable;
        private DataGridView dgvTable;
        private Button btnEditTable;
        private Button btnDeteleTable;
        private Button btnAddTable;
        private Button btnAddCategory;
        private Panel panel12;
        private Panel panel19;
        private Panel panel21;
        private Panel panel22;
        private Label label6;
        private Panel panel20;
        private Label label4;
        private TextBox tbTableid;
        private Panel panel11;
        private Button btnCategoryShow;
        private Button btnCategoryEdit;
        private Button btnCategoryDetele;
        private Button btnCategoruAdd;
        private Panel panel14;
        private DataGridView dgvCategory;
        private Panel panel18;
        private Panel panel17;
        private Label label9;
        private TextBox tbCategoryName;
        private Panel panel16;
        private Label label7;
        private TextBox TbCategoryId;
        private Panel panel23;
        private Panel panel25;
        private ComboBox cbAccountType;
        private Label label11;
        private Panel panel26;
        private Label label12;
        private TextBox tbAccountDisplayName;
        private Panel panel27;
        private Label label13;
        private TextBox tbAccountUsername;
        private Panel panel29;
        private DataGridView dgvAccount;
        private Panel panel30;
        private Button btnAccountShow;
        private Button btnAccountEdit;
        private Button btnAccountDetele;
        private Button btnAccountAdd;
        private Button btnResetPassword;
    }
}