using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elena.Classes
{
    internal class Error
    {
        public static readonly string wrongLoginOrPassword = "Ошибка: Неверный логин или пароль ";
        public static readonly string postError = "Ошибка: Данная роль еще не реализована";
        public static readonly string emptyString = "Ошибка: Все поля должны быть заполнены";
        public static readonly string isExist = "Ошибка: Такой объект уже существует";
        public static readonly string notSelected = "Ошибка: Объект для удаления не выбран";
        public static readonly string insufficientFunds = "Ошибка: Недостаточно средст";
    }
}