using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz26Nomay
{
    public class SmartBook : PC
    {
        public double massa { get; set; }
        public SmartBook(string model_, int clockFrequency_, int ram_, int hardDiskCapacity_, double massa_) 
            :base(model_,  clockFrequency_, ram_, hardDiskCapacity_)
        {
            massa = massa_;
        }
        public override string info()
        {
            return $"Модель: {model} Частота: {clockFrequency} Озу: {ram} Памяти: {hardDiskCapacity} Вес: {massa}";
        }
    }
}
