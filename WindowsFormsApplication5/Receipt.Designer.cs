namespace WindowsFormsApplication3
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.label18 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListView();
            this.iName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(49, 9);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(182, 60);
            this.label18.TabIndex = 18;
            this.label18.Text = "Receipt\r\nSeoul\r\n***THE 7th COFFEE***\r\n\r\n";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.SystemColors.Window;
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.iName,
            this.amount,
            this.price});
            this.list.ForeColor = System.Drawing.Color.Black;
            this.list.FullRowSelect = true;
            this.list.GridLines = true;
            this.list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list.HoverSelection = true;
            this.list.Location = new System.Drawing.Point(15, 72);
            this.list.Margin = new System.Windows.Forms.Padding(2);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(244, 280);
            this.list.TabIndex = 29;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // iName
            // 
            this.iName.Text = "상품명";
            this.iName.Width = 120;
            // 
            // amount
            // 
            this.amount.Text = "수량";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount.Width = 50;
            // 
            // price
            // 
            this.price.Text = "가격";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.Width = 70;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 423);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 31);
            this.button1.TabIndex = 35;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(124, 361);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 15);
            this.label15.TabIndex = 34;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(78, 391);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(22, 391);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 32;
            this.label13.Text = "Date : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(20, 361);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total Price :";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label18);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.ListView list;
        protected System.Windows.Forms.ColumnHeader iName;
        protected System.Windows.Forms.ColumnHeader amount;
        protected System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
    }
}