/*
 * Created by SharpDevelop.
 * User: Sugi_Huang
 * Date: 20/04/2021
 * Time: 16:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ClothesShop
{
	partial class Clothes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clothes));
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearSelect = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qtyBox = new System.Windows.Forms.TextBox();
            this.dgvCloth = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.clothImg = new System.Windows.Forms.PictureBox();
            this.closebtn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clothNameBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Order = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCloth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.clearSelect);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.editBtn);
            this.panel2.Controls.Add(this.sizeBox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.priceBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.qtyBox);
            this.panel2.Controls.Add(this.dgvCloth);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.resetBtn);
            this.panel2.Controls.Add(this.saveBtn);
            this.panel2.Controls.Add(this.uploadBtn);
            this.panel2.Controls.Add(this.clothImg);
            this.panel2.Controls.Add(this.closebtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.clothNameBox);
            this.panel2.Location = new System.Drawing.Point(322, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 712);
            this.panel2.TabIndex = 5;
            // 
            // clearSelect
            // 
            this.clearSelect.BackColor = System.Drawing.Color.DimGray;
            this.clearSelect.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSelect.ForeColor = System.Drawing.Color.White;
            this.clearSelect.Location = new System.Drawing.Point(337, 288);
            this.clearSelect.Name = "clearSelect";
            this.clearSelect.Size = new System.Drawing.Size(182, 46);
            this.clearSelect.TabIndex = 30;
            this.clearSelect.Text = "Clear Selection";
            this.clearSelect.UseVisualStyleBackColor = false;
            this.clearSelect.Click += new System.EventHandler(this.ClearSelectClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(754, 288);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(182, 46);
            this.deleteBtn.TabIndex = 28;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtnClick);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.DimGray;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(555, 288);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(182, 46);
            this.editBtn.TabIndex = 27;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.EditBtnClick);
            // 
            // sizeBox
            // 
            this.sizeBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Items.AddRange(new object[] {
            "SS",
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL"});
            this.sizeBox.Location = new System.Drawing.Point(501, 147);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(133, 42);
            this.sizeBox.TabIndex = 26;
            this.sizeBox.Text = "Size";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(921, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 39);
            this.label11.TabIndex = 25;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(783, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 27);
            this.label10.TabIndex = 24;
            this.label10.Text = "Price";
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.priceBox.Location = new System.Drawing.Point(783, 149);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(145, 42);
            this.priceBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(651, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 27);
            this.label5.TabIndex = 22;
            this.label5.Text = "Quantity";
            // 
            // qtyBox
            // 
            this.qtyBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.qtyBox.Location = new System.Drawing.Point(659, 147);
            this.qtyBox.Name = "qtyBox";
            this.qtyBox.Size = new System.Drawing.Size(102, 42);
            this.qtyBox.TabIndex = 21;
            // 
            // dgvCloth
            // 
            this.dgvCloth.AllowUserToAddRows = false;
            this.dgvCloth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCloth.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCloth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCloth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCloth.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCloth.Location = new System.Drawing.Point(35, 341);
            this.dgvCloth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCloth.MultiSelect = false;
            this.dgvCloth.Name = "dgvCloth";
            this.dgvCloth.ReadOnly = true;
            this.dgvCloth.RowHeadersVisible = false;
            this.dgvCloth.RowHeadersWidth = 62;
            this.dgvCloth.RowTemplate.Height = 100;
            this.dgvCloth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCloth.Size = new System.Drawing.Size(900, 355);
            this.dgvCloth.TabIndex = 20;
            this.dgvCloth.TabStop = false;
            this.dgvCloth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClothCellClick);
            this.dgvCloth.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvClothDataBindingComplete);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label12.Location = new System.Drawing.Point(28, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 39);
            this.label12.TabIndex = 19;
            this.label12.Text = "Clothes List";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.DimGray;
            this.resetBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(752, 212);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(182, 46);
            this.resetBtn.TabIndex = 18;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtnClick);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(553, 212);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(182, 46);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtnClick);
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.DimGray;
            this.uploadBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.Location = new System.Drawing.Point(67, 212);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(182, 46);
            this.uploadBtn.TabIndex = 16;
            this.uploadBtn.Text = "Upload Image";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.UploadBtnClick);
            // 
            // clothImg
            // 
            this.clothImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clothImg.Location = new System.Drawing.Point(101, 87);
            this.clothImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clothImg.Name = "clothImg";
            this.clothImg.Size = new System.Drawing.Size(106, 107);
            this.clothImg.TabIndex = 15;
            this.clothImg.TabStop = false;
            // 
            // closebtn
            // 
            this.closebtn.AutoSize = true;
            this.closebtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.closebtn.ForeColor = System.Drawing.Color.Black;
            this.closebtn.Location = new System.Drawing.Point(1221, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(28, 30);
            this.closebtn.TabIndex = 9;
            this.closebtn.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(499, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(277, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cloth name";
            // 
            // clothNameBox
            // 
            this.clothNameBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.clothNameBox.Location = new System.Drawing.Point(278, 147);
            this.clothNameBox.Name = "clothNameBox";
            this.clothNameBox.Size = new System.Drawing.Size(202, 42);
            this.clothNameBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(16, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 712);
            this.panel1.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.Order);
            this.panel7.Controls.Add(this.pictureBox7);
            this.panel7.Location = new System.Drawing.Point(22, 334);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(264, 66);
            this.panel7.TabIndex = 14;
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Order.Location = new System.Drawing.Point(68, 17);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(108, 39);
            this.Order.TabIndex = 13;
            this.Order.Text = "Order";
            this.Order.Click += new System.EventHandler(this.OrderClick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(18, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(38, 57);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Location = new System.Drawing.Point(22, 568);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(264, 66);
            this.panel6.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(68, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 39);
            this.label9.TabIndex = 14;
            this.label9.Text = "Logout";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(18, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(38, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Location = new System.Drawing.Point(22, 422);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 66);
            this.panel5.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(68, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 39);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dashboard";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(18, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 57);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(22, 246);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 66);
            this.panel4.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(68, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 39);
            this.label7.TabIndex = 12;
            this.label7.Text = "Users";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(18, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(22, 155);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 66);
            this.panel3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(66, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "Clothes";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(69, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "Clothes Shop";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(427, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 39);
            this.label1.TabIndex = 31;
            this.label1.Text = "Stocks";
            // 
            // Clothes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1300, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Clothes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCloth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Label Order;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Button clearSelect;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox clothNameBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label closebtn;
		private System.Windows.Forms.PictureBox clothImg;
		private System.Windows.Forms.Button uploadBtn;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Button resetBtn;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DataGridView dgvCloth;
		private System.Windows.Forms.TextBox qtyBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox priceBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label label1;
    }
}
