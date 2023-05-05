using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elena.Classes
{
    // Наследование интерфейса для копирование элемента (создание еще одной ссылки на объект)
    internal class productModel : ICloneable
    {
        public int ID { get; set; }
        public string title { get; set; }
        public int idTypeProducts { get; set; }
        public int price { get; set; }
        public int count { get; set; }

        // функция возвращающая скопированный объект
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
