using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz26Nomay
{
    public class User
    {
        public int age { get; set; }
        public string name { get; set; }
        public string clan { get; set; }
        public string patronymic { get; set; }

        public User(string name_, string clan_, string patronimic_, int age_) 
        {
            name = name_;
            clan = clan_;
            patronymic = patronimic_;
            age = age_;

        }
        public string Act() 
        {
            return $"{clan} {name} {patronymic} {age} Лет";
        }
        public void PrintFio()
        {
            Console.Write(this.Act());
        }
    }
}
