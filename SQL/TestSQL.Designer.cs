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
            executeBtn = new Button();
            textOfSQL = new TextBox();
            clearBtn = new Button();
            dataGridView = new DataGridView();
            rbSelect = new RadioButton();
            rbExecute = new RadioButton();
            rbScalar = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // executeBtn
            // 
            executeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            executeBtn.Location = new Point(35, 65);
            executeBtn.Name = "executeBtn";
            executeBtn.Size = new Size(486, 49);
            executeBtn.TabIndex = 0;
            executeBtn.Text = "Выполнить";
            executeBtn.UseVisualStyleBackColor = true;
            executeBtn.Click += executeBtn_Click;
            // 
            // textOfSQL
            // 
            textOfSQL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textOfSQL.Location = new Point(35, 30);
            textOfSQL.Name = "textOfSQL";
            textOfSQL.Size = new Size(486, 29);
            textOfSQL.TabIndex = 1;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Segoe UI", 12F);
            clearBtn.Location = new Point(35, 120);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(486, 55);
            clearBtn.TabIndex = 3;
            clearBtn.Text = "Очистить";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(35, 181);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(486, 306);
            dataGridView.TabIndex = 4;
            // 
            // rbSelect
            // 
            rbSelect.AutoSize = true;
            rbSelect.Checked = true;
            rbSelect.Location = new Point(35, 5);
            rbSelect.Name = "rbSelect";
            rbSelect.Size = new Size(111, 19);
            rbSelect.TabIndex = 5;
            rbSelect.TabStop = true;
            rbSelect.Text = "Вывод таблицы";
            rbSelect.UseVisualStyleBackColor = true;
            // 
            // rbExecute
            // 
            rbExecute.AutoSize = true;
            rbExecute.Location = new Point(212, 5);
            rbExecute.Name = "rbExecute";
            rbExecute.Size = new Size(135, 19);
            rbExecute.TabIndex = 6;
            rbExecute.Text = "Вывод кол-во строк";
            rbExecute.UseVisualStyleBackColor = true;
            // 
            // rbScalar
            // 
            rbScalar.AutoSize = true;
            rbScalar.Location = new Point(427, 5);
            rbScalar.Name = "rbScalar";
            rbScalar.Size = new Size(96, 19);
            rbScalar.TabIndex = 7;
            rbScalar.Text = "Вывод числа";
            rbScalar.UseVisualStyleBackColor = true;
            // 
            // TestSQL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 499);
            Controls.Add(rbScalar);
            Controls.Add(rbExecute);
            Controls.Add(rbSelect);
            Controls.Add(dataGridView);
            Controls.Add(clearBtn);
            Controls.Add(textOfSQL);
            Controls.Add(executeBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TestSQL";
            Text = "TestSQL";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button executeBtn;
        private TextBox textOfSQL;
        private Button clearBtn;
        private DataGridView dataGridView;
        private RadioButton rbSelect;
        private RadioButton rbExecute;
        private RadioButton rbScalar;
    }
}
