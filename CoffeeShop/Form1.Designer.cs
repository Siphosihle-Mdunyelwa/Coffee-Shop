namespace CoffeeShop
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxQuantity = new System.Windows.Forms.ComboBox();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Coffee Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Payment";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(245, 133);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(211, 20);
            this.textBoxID.TabIndex = 6;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxID_KeyPress);
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Items.AddRange(new object[] {
            "Latte",
            "Cappucino",
            "Chocolate"});
            this.comboBoxName.Location = new System.Drawing.Point(245, 178);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(211, 21);
            this.comboBoxName.TabIndex = 7;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Frapp",
            "Ice",
            "Hot"});
            this.comboBoxType.Location = new System.Drawing.Point(245, 230);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(211, 21);
            this.comboBoxType.TabIndex = 8;
            // 
            // comboBoxQuantity
            // 
            this.comboBoxQuantity.FormattingEnabled = true;
            this.comboBoxQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxQuantity.Location = new System.Drawing.Point(245, 283);
            this.comboBoxQuantity.Name = "comboBoxQuantity";
            this.comboBoxQuantity.Size = new System.Drawing.Size(211, 21);
            this.comboBoxQuantity.TabIndex = 9;
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Location = new System.Drawing.Point(245, 337);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(211, 20);
            this.textBoxPayment.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.coffeename,
            this.type,
            this.quantity,
            this.payment});
            this.dataGridView1.Location = new System.Drawing.Point(517, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(551, 175);
            this.dataGridView1.TabIndex = 11;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // coffeename
            // 
            this.coffeename.HeaderText = "Coffee Name";
            this.coffeename.Name = "coffeename";
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // payment
            // 
            this.payment.HeaderText = "Payment";
            this.payment.Name = "payment";
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Green;
            this.buttonInsert.ForeColor = System.Drawing.Color.White;
            this.buttonInsert.Location = new System.Drawing.Point(517, 334);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 28);
            this.buttonInsert.TabIndex = 12;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClear.Location = new System.Drawing.Point(608, 334);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 28);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(1026, 436);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(78, 28);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 476);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxPayment);
            this.Controls.Add(this.comboBoxQuantity);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Shop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxQuantity;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeename;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
    }
}

