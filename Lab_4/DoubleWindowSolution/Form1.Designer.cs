namespace DoubleWindowSolution
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Objects = new System.Windows.Forms.ListBox();
            this.B_Clear = new System.Windows.Forms.Button();
            this.B_Delete = new System.Windows.Forms.Button();
            this.B_New = new System.Windows.Forms.Button();
            this.TB_ObjectContext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LB_Objects
            // 
            this.LB_Objects.FormattingEnabled = true;
            this.LB_Objects.ItemHeight = 16;
            this.LB_Objects.Location = new System.Drawing.Point(188, 15);
            this.LB_Objects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LB_Objects.Name = "LB_Objects";
            this.LB_Objects.Size = new System.Drawing.Size(389, 516);
            this.LB_Objects.TabIndex = 0;
            this.LB_Objects.SelectedIndexChanged += new System.EventHandler(this.LB_Objects_SelectedIndexChanged);
            // 
            // B_Clear
            // 
            this.B_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.B_Clear.Location = new System.Drawing.Point(16, 15);
            this.B_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B_Clear.Name = "B_Clear";
            this.B_Clear.Size = new System.Drawing.Size(164, 64);
            this.B_Clear.TabIndex = 1;
            this.B_Clear.Text = "Clear List";
            this.B_Clear.UseVisualStyleBackColor = true;
            this.B_Clear.Click += new System.EventHandler(this.B_Clear_Click);
            // 
            // B_Delete
            // 
            this.B_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.B_Delete.Location = new System.Drawing.Point(16, 86);
            this.B_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B_Delete.Name = "B_Delete";
            this.B_Delete.Size = new System.Drawing.Size(164, 62);
            this.B_Delete.TabIndex = 2;
            this.B_Delete.Text = "Delete";
            this.B_Delete.UseVisualStyleBackColor = true;
            this.B_Delete.Click += new System.EventHandler(this.B_Delete_Click);
            // 
            // B_New
            // 
            this.B_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.B_New.Location = new System.Drawing.Point(16, 155);
            this.B_New.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B_New.Name = "B_New";
            this.B_New.Size = new System.Drawing.Size(164, 64);
            this.B_New.TabIndex = 3;
            this.B_New.Text = "New";
            this.B_New.UseVisualStyleBackColor = true;
            this.B_New.Click += new System.EventHandler(this.B_New_Click);
            // 
            // TB_ObjectContext
            // 
            this.TB_ObjectContext.Cursor = System.Windows.Forms.Cursors.Default;
            this.TB_ObjectContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TB_ObjectContext.Location = new System.Drawing.Point(587, 15);
            this.TB_ObjectContext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_ObjectContext.Multiline = true;
            this.TB_ObjectContext.Name = "TB_ObjectContext";
            this.TB_ObjectContext.Size = new System.Drawing.Size(472, 523);
            this.TB_ObjectContext.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 554);
            this.Controls.Add(this.TB_ObjectContext);
            this.Controls.Add(this.B_New);
            this.Controls.Add(this.B_Delete);
            this.Controls.Add(this.B_Clear);
            this.Controls.Add(this.LB_Objects);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Objects;
        private System.Windows.Forms.Button B_Clear;
        private System.Windows.Forms.Button B_Delete;
        private System.Windows.Forms.Button B_New;
        private System.Windows.Forms.TextBox TB_ObjectContext;
    }
}

