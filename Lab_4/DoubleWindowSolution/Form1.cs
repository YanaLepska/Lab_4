using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoubleWindowSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B_New_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            if(CustomBuffer.BufferObject != null)
                LB_Objects.Items.Add(CustomBuffer.BufferObject);
        }

        private void B_Delete_Click(object sender, EventArgs e)
        {
            if(LB_Objects.SelectedItem != null)
            {
                LB_Objects.Items.Remove(LB_Objects.SelectedItem);
            }
        }

        private void B_Clear_Click(object sender, EventArgs e)
        {
            LB_Objects.Items.Clear();
        }

        private void LB_Objects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_Objects.SelectedIndex != -1)
            {
                TB_ObjectContext.Text = LB_Objects.SelectedItem.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
