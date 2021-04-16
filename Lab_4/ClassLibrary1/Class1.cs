using System;

namespace ClassLib_1
{
    public class CPU
    {
        public static string[] GetParams()
        {
            string[] output = new string[10];

            output[0] = "Frequency";
            output[1] = "Physycal cores";
            output[2] = "Logical cores";
            output[3] = "Manufacturer";
            output[4] = "Socket";
            output[5] = "L1Chache";
            output[6] = "L2Chache";
            output[7] = "L3Chache";
            output[8] = "Price";
            output[9] = "Name";

            return output;
        }
        public struct s_CPU_Desc
        {
            public double Freq;//Frequency in GHz
            public int Phy_Cores;
            public int Log_Cores;
            public string Manufacturer;
            public string Socket;
            public double L1Chache;//in MB
            public double L2Chache;//in MB
            public double L3Chache;//in MB
            public double Price; //добавилось поле структуры Price, хранящее в себе цену процессора
            public string Name;
        }
        public s_CPU_Desc __DESC;
        public s_CPU_Desc description
        {
            get
            {
                return __DESC;
            }
            private set
            {
                this.__DESC = value;
            }
        }
        public CPU(s_CPU_Desc deviceDesc)
        {
            this.description = deviceDesc;
        }

        /*
         *  Были убраны методы для вводы параметров, за ненадобностью. 
         *  Они были необходимы для консольного приложения, но являются неприменимыми к оконному приложению.
         *  Вместо них внизу добавлены методы SET, для присваивания значений полям структуры
         */

        public override string ToString()
        {
            string output = string.Empty;

            output += "CPU Name         - " + Convert.ToString(description.Name) + "\r\n";
            output += "CPU Frequency    - " + Convert.ToString(description.Freq) + "\r\n";
            output += "CPU Phy_Cores    - " + Convert.ToString(description.Phy_Cores) + "\r\n";
            output += "CPU Log_Cores    - " + Convert.ToString(description.Log_Cores) + "\r\n";
            output += "CPU Manufacturer - " + Convert.ToString(description.Manufacturer) + "\r\n";
            output += "CPU Socket       - " + Convert.ToString(description.Socket) + "\r\n";
            output += "CPU L1Chache     - " + Convert.ToString(description.L1Chache) + "\r\n";
            output += "CPU L2Chache     - " + Convert.ToString(description.L2Chache) + "\r\n";
            output += "CPU L3Chache     - " + Convert.ToString(description.L3Chache) + "\r\n";
            output += "CPU Price        - " + Convert.ToString(description.Price) + "\r\n";
            output += "CPU Operations per second - " + Convert.ToString(OperationCountPerSecond()) + "\r\n";
            output += "CPU price per operation   - " + Convert.ToString(PricePerOperation()) + "\r\n";

            return output;
        }

        /*
         *  Было добавлено 2 метода для расчётов:
         *      OperationCountPerSecond() - кол-во операций в секунду
         *      PricePerOperation() - цена за одну операцию
         */

        public double OperationCountPerSecond()
        {
            return description.Freq * description.Log_Cores;
        }
        public double PricePerOperation()
        {
            return description.Price / OperationCountPerSecond();
        }
        public void SetCpuDesc(ref s_CPU_Desc desc)
        {
            this.description = desc;
        }
        public void SetCpuDescFreq(double frequency)
        {
            __DESC.Freq = frequency;
        }
        public void SetCpuDescPhycores(int phyCoresCount)
        {
            __DESC.Phy_Cores = phyCoresCount;
        }
        public void SetCpuDescLogcores(int logCoresCount)
        {
            __DESC.Phy_Cores = logCoresCount;
        }
        public void SetCpuDescManufacturer(string manufacturer)
        {
            __DESC.Manufacturer = manufacturer;
        }
        public void SetCpuDescSocket(string socket)
        {
            __DESC.Socket = socket;
        }
        public void SetCpuDescL1Chache(double L1Chache)
        {
            __DESC.L1Chache = L1Chache;
        }
        public void SetCpuDescL2Chache(double L2Chache)
        {
            __DESC.L2Chache = L2Chache;
        }
        public void SetCpuDescL3Chache(double L3Chache)
        {
            __DESC.L3Chache = L3Chache;
        }
        public void SetCpuDescPrice(double price)
        {
            __DESC.Price = price;
        }

    }
}
