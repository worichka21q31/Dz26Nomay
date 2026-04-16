using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dz26Nomay
{
    public class PC
    {
        public string model { get; set; }
        public int clockFrequency { get; set; }
        public int ram { get; set; }
        public int hardDiskCapacity { get; set; }
        public PC(string model_, int clockFrequency_, int ram_, int hardDiskCapacity_) 
        {
            model = model_;
            clockFrequency = clockFrequency_;
            ram = ram_;
            hardDiskCapacity = hardDiskCapacity_;
        }
        public virtual string info()
        {
            return $"Модель: {model} Частота: {clockFrequency} Озу: {ram} Памяти: {hardDiskCapacity}";
        }   
        public void printInfo()
        {
            Console.WriteLine(this.info());
        }
    }
}
