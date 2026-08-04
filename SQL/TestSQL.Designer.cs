namespace SQL
{
    partial class TestSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestSQL));
            getProductsBtn = new Button();
            getOrdersBtn = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // getProductsBtn
            // 
            getProductsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            getProductsBtn.Location = new Point(35, 12);
            getProductsBtn.Name = "getProductsBtn";
            getProductsBtn.Size = new Size(486, 49);
            getProductsBtn.TabIndex = 0;
            getProductsBtn.Text = "Получить товары";
            getProductsBtn.UseVisualStyleBackColor = true;
            getProductsBtn.Click += getProductsBtn_Click;
            // 
            // getOrdersBtn
            // 
            getOrdersBtn.Font = new Font("Segoe UI", 12F);
            getOrdersBtn.Location = new Point(35, 79);
            getOrdersBtn.Name = "getOrdersBtn";
            getOrdersBtn.Size = new Size(486, 55);
            getOrdersBtn.TabIndex = 3;
            getOrdersBtn.Text = "Получить заказы";
            getOrdersBtn.UseVisualStyleBackColor = true;
            getOrdersBtn.Click += getOrdersBtn_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(35, 152);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(486, 335);
            dataGridView.TabIndex = 4;
            // 
            // TestSQL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 499);
            Controls.Add(dataGridView);
            Controls.Add(getOrdersBtn);
            Controls.Add(getProductsBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TestSQL";
            Text = "TestSQL";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button getProductsBtn;
        private Button getOrdersBtn;
        private DataGridView dataGridView;
    }
}
