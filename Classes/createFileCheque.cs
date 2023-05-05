using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Elena.Kringe5DataSetTableAdapters;

namespace Elena.Classes
{
    internal class createFileCheque
    {
        private chequeTableAdapter cheques = new chequeTableAdapter();
        private cheque_productsTableAdapter cheque_Products = new cheque_productsTableAdapter();
        private productsTableAdapter products = new productsTableAdapter();

        public createFileCheque(int ID)
        {
            var cheque = cheques.GetData().First(element => element.ID == ID);

            CommonOpenFileDialog dialog = new CommonOpenFileDialog { IsFolderPicker = true };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                var listProducts = cheque_Products.GetData().Where(element=> element.idCheque == cheque.ID);
                File.WriteAllText(Path.GetFullPath(dialog.FileName) + "\\Чек.txt", "\t   Магазин строй материалов bongo cat" + "\n");
                File.AppendAllText(Path.GetFullPath(dialog.FileName) + "\\Чек.txt", $"\t  Договор на покупку товаров №{cheque.ID}" + "\n");
                foreach (var element in listProducts)
                {
                    File.WriteAllText(Path.GetFullPath(dialog.FileName) + "\\Чек.txt", $"\n \t Товар номер № {element.idProducts}: Цена - {products.GetData().First(elem=>elem.ID == element.idProducts).price}");
                }
                File.AppendAllText(Path.GetFullPath(dialog.FileName) + "\\Чек.txt", $"Итого к оплате:  {cheque.priceAll}" + "\n");
                File.AppendAllText(Path.GetFullPath(dialog.FileName) + "\\Чек.txt", $"Внесено: {Math.Abs(cheque.priceAll - cheque.change)}" + "\n");
                File.AppendAllText(Path.GetFullPath(dialog.FileName) + "\\Чек.txt", $"Сдача: {cheque.change}" + "\n");
            }
            else
            {
                MessageBox.Show("Ошибка: Не удалось загрузить чек");
            }
        }
    }
}
