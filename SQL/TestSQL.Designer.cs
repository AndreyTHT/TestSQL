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
            tabControl1 = new TabControl();
            tabProducts = new TabPage();
            panel1 = new Panel();
            tabOrders = new TabPage();
            panel2 = new Panel();
            tabOrderProducts = new TabPage();
            tabControl1.SuspendLayout();
            tabProducts.SuspendLayout();
            tabOrders.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProducts);
            tabControl1.Controls.Add(tabOrders);
            tabControl1.Controls.Add(tabOrderProducts);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(551, 499);
            tabControl1.TabIndex = 0;
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(panel1);
            tabProducts.Location = new Point(4, 24);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3);
            tabProducts.Size = new Size(543, 471);
            tabProducts.TabIndex = 0;
            tabProducts.Text = "Products";
            tabProducts.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 465);
            panel1.TabIndex = 0;
            // 
            // tabOrders
            // 
            tabOrders.Controls.Add(panel2);
            tabOrders.Location = new Point(4, 24);
            tabOrders.Name = "tabOrders";
            tabOrders.Padding = new Padding(3);
            tabOrders.Size = new Size(543, 471);
            tabOrders.TabIndex = 1;
            tabOrders.Text = "Orders";
            tabOrders.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(537, 465);
            panel2.TabIndex = 0;
            // 
            // tabOrderProducts
            // 
            tabOrderProducts.Location = new Point(4, 24);
            tabOrderProducts.Name = "tabOrderProducts";
            tabOrderProducts.Size = new Size(543, 471);
            tabOrderProducts.TabIndex = 2;
            tabOrderProducts.Text = "OrderProducts";
            tabOrderProducts.UseVisualStyleBackColor = true;
            // 
            // TestSQL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 499);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TestSQL";
            Text = "TestSQL";
            tabControl1.ResumeLayout(false);
            tabProducts.ResumeLayout(false);
            tabOrders.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabProducts;
        private TabPage tabOrders;
        private TabPage tabOrderProducts;
        private Panel panel1;
        private Panel panel2;
    }
}
