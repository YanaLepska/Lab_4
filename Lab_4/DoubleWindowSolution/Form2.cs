using ClassLib_1;
using System;
using System.Windows.Forms;

namespace DoubleWindowSolution
{
    public partial class Form2 : Form
    {
        int SelectedIndex = -1;
        CPU.s_CPU_Desc bufferCpuDesc;
        public Form2()
        {
            InitializeComponent();
            CustomBuffer.BufferObject = null;
            foreach(string str in CPU.GetParams())
            {
                LB_Params.Items.Add(str);
            }
        }

        private void LB_Params_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LB_Params.SelectedIndex != -1)
            {
                if(TB_ParamContext.Text != string.Empty)
                {
                    switch (SelectedIndex)
                    {
                        case 0:
                            bufferCpuDesc.Freq = Convert.ToDouble(TB_ParamContext.Text.Replace('.', ','));
                            break;
                        case 1:
                            bufferCpuDesc.Phy_Cores = Convert.ToInt32(TB_ParamContext.Text);
                            break;
                        case 2:
                            bufferCpuDesc.Log_Cores = Convert.ToInt32(TB_ParamContext.Text);
                            break;
                        case 3:
                            bufferCpuDesc.Manufacturer = TB_ParamContext.Text;
                            break;
                        case 4:
                            bufferCpuDesc.Socket = TB_ParamContext.Text;
                            break;
                        case 5:
                            bufferCpuDesc.L1Chache = Convert.ToDouble(TB_ParamContext.Text.Replace('.', ','));
                            break;
                        case 6:
                            bufferCpuDesc.L2Chache = Convert.ToDouble(TB_ParamContext.Text.Replace('.', ','));
                            break;
                        case 7:
                            bufferCpuDesc.L3Chache = Convert.ToDouble(TB_ParamContext.Text.Replace('.', ','));
                            break;
                        case 8:
                            bufferCpuDesc.Price = Convert.ToDouble(TB_ParamContext.Text.Replace('.', ','));
                            break;
                        case 9:
                            bufferCpuDesc.Name = TB_ParamContext.Text;
                            break;
                    }
                    SelectedIndex = LB_Params.SelectedIndex;
                    TB_ParamContext.Text = string.Empty;
                }
                switch (SelectedIndex)
                {
                    case 0:
                        TB_ParamContext.Text = Convert.ToString(bufferCpuDesc.Freq);
                        break;
                    case 1:
                        TB_ParamContext.Text = Convert.ToString(bufferCpuDesc.Phy_Cores);
                        break;
                    case 2:
                        TB_ParamContext.Text = Convert.ToString(bufferCpuDesc.Log_Cores);
                        break;
                    case 3:
                        TB_ParamContext.Text = Convert.ToString(bufferCpuDesc.Manufacturer);
                        break;
                    case 4:
                        TB_ParamContext.Text = Convert.ToString(bufferCpuDesc.Socket);
                        break;
                    case 5:
                        TB_ParamContext.Text = Convert.ToString(bufferCpuDesc.L1Chache);
                        break;
                    case 6:
                        TB_ParamContext.Text = Convert.ToString(bufferCpuDesc.L2Chache);
                        break;
                    case 7:
                        TB_ParamContext.Text = Convert.ToString(bufferCpuDesc.L3Chache);
                        break;
                    case 8:
                        TB_ParamContext.Text = Convert.ToString(bufferCpuDesc.Price);
                        break;
                    case 9:
                        TB_ParamContext.Text = Convert.ToString(bufferCpuDesc.Name);
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LB_Params_SelectedIndexChanged(null,null);
            CustomBuffer.BufferObject = new CPU(this.bufferCpuDesc);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
