namespace DoubleWindowSolution
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LB_Params = new System.Windows.Forms.ListBox();
            this.TB_ParamContext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(12, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(12, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LB_Params
            // 
            this.LB_Params.FormattingEnabled = true;
            this.LB_Params.ItemHeight = 16;
            this.LB_Params.Location = new System.Drawing.Point(240, 15);
            this.LB_Params.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LB_Params.Name = "LB_Params";
            this.LB_Params.Size = new System.Drawing.Size(237, 292);
            this.LB_Params.TabIndex = 2;
            this.LB_Params.SelectedIndexChanged += new System.EventHandler(this.LB_Params_SelectedIndexChanged);
            // 
            // TB_ParamContext
            // 
            this.TB_ParamContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TB_ParamContext.Location = new System.Drawing.Point(487, 15);
            this.TB_ParamContext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_ParamContext.Multiline = true;
            this.TB_ParamContext.Name = "TB_ParamContext";
            this.TB_ParamContext.Size = new System.Drawing.Size(315, 292);
            this.TB_ParamContext.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 320);
            this.Controls.Add(this.TB_ParamContext);
            this.Controls.Add(this.LB_Params);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox LB_Params;
        private System.Windows.Forms.TextBox TB_ParamContext;
    }
}