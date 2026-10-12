namespace task7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            flowertype = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            totalamount = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            button1 = new Button();
            panel3 = new Panel();
            txtQuantity = new MaskedTextBox();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            txtPrice = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            txtType = new TextBox();
            label4 = new Label();
            lblIncome = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.BlueViolet;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { flowertype, quantity, price, totalamount });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(874, 245);
            dataGridView1.TabIndex = 0;
            // 
            // flowertype
            // 
            flowertype.HeaderText = "Flower Type";
            flowertype.MinimumWidth = 8;
            flowertype.Name = "flowertype";
            flowertype.Width = 360;
            // 
            // quantity
            // 
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 8;
            quantity.Name = "quantity";
            quantity.Width = 150;
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.MinimumWidth = 8;
            price.Name = "price";
            price.Width = 150;
            // 
            // totalamount
            // 
            totalamount.HeaderText = "Total Amount";
            totalamount.MinimumWidth = 8;
            totalamount.Name = "totalamount";
            totalamount.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtType);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(0, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 314);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Flower Information";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(63, 237);
            button1.Name = "button1";
            button1.Size = new Size(169, 46);
            button1.TabIndex = 10;
            button1.Text = "MAKE SALE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(181, 194);
            panel3.Name = "panel3";
            panel3.Size = new Size(50, 1);
            panel3.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.MediumPurple;
            txtQuantity.BorderStyle = BorderStyle.None;
            txtQuantity.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtQuantity.Location = new Point(180, 171);
            txtQuantity.Mask = "000";
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(50, 24);
            txtQuantity.TabIndex = 9;
            txtQuantity.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(171, 132);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 7;
            label3.Text = "Quantity:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(62, 194);
            panel2.Name = "panel2";
            panel2.Size = new Size(50, 1);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(52, 132);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 4;
            label2.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.MediumPurple;
            txtPrice.BorderStyle = BorderStyle.None;
            txtPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtPrice.ForeColor = Color.FromArgb(37, 37, 38);
            txtPrice.Location = new Point(61, 171);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(50, 24);
            txtPrice.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(62, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 1);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(52, 49);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 1;
            label1.Text = "Flower type:";
            // 
            // txtType
            // 
            txtType.BackColor = Color.MediumPurple;
            txtType.BorderStyle = BorderStyle.None;
            txtType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtType.ForeColor = Color.FromArgb(37, 37, 38);
            txtType.Location = new Point(61, 88);
            txtType.Name = "txtType";
            txtType.Size = new Size(170, 24);
            txtType.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(394, 377);
            label4.Name = "label4";
            label4.Size = new Size(201, 41);
            label4.TabIndex = 13;
            label4.Text = "Total income:";
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblIncome.ForeColor = Color.WhiteSmoke;
            lblIncome.Location = new Point(631, 377);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(35, 41);
            lblIncome.TabIndex = 14;
            lblIncome.Text = "0";
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExit.ForeColor = Color.WhiteSmoke;
            btnExit.Location = new Point(705, 501);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(169, 46);
            btnExit.TabIndex = 15;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(874, 559);
            Controls.Add(btnExit);
            Controls.Add(lblIncome);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn flowertype;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn totalamount;
        private GroupBox groupBox1;
        private Panel panel1;
        private Label label1;
        private TextBox txtType;
        private Panel panel2;
        private Label label2;
        private TextBox txtPrice;
        private MaskedTextBox txtQuantity;
        private Panel panel3;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label lblIncome;
        private Button btnExit;
    }
}
