using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_3
{
    internal class Qp:Car
    {
        private List<string> cars=new List<string>();
        private List  <string > cars2 = new List<string>();
        private int p;
        private ListBox listbox;
        public Qp(ListBox listbox)
        {
            this.listbox = listbox;
        }
        public int P
        {
            get { return p; }
            set
            {
                if (value>1800&&value<2020)
                {
                    p = value;
                    Sc = true;
                }
                else
                {
                    MessageBox.Show("Значение должно быть в диапозоне от 1800 г. до 2020 г.", "Ошибка");
                    Sc = false;
                }
            }
        }
        public double Qpr()
        {
            return q() * 1.15 * p;
        }
        public void Remove(string Id)
        {
            int countId=cars.Count;
            cars.RemoveAll(cars=>cars.Contains($"Номер машины {Id}"));
             int countaf=cars.Count;
            if (countaf < countId)
            {
                MessageBox.Show($"Номер машины {Id} удален","");
                return;
            }
            else
            {
                MessageBox.Show("Номер машины не найден");
                return;
            }
        }
        public void Remove2(string Id)
        {
            int countId = cars2.Count;
            cars.RemoveAll(cars2 => cars2.Contains($"Номер машины {Id}"));
            int countaf = cars2.Count;
            if (countaf < countId)
            {
                MessageBox.Show($"Номер машины {Id} удален", "");
                return;
            }
            else
            {
                MessageBox.Show("Номер машины не найден");
                return;
            }
        }
        public void AddList2()
        {
            cars2.Add($"Номер машины {Id}, Качестов(Qp)={Qpr()}");
        }
        public void Add()
        {
            cars.Add($"Номер машины {Id}, Пробег {Mileage}, Расход на км {Expenditure}, Р={P}, Q={q()}, Qp={Qpr()}");
        }   
        public void GetList()
        {
            foreach(var car in cars)
            {
                listbox.Items.Add(car);
            }
        }
        public void GetList2()
        {
            foreach (var car in cars2)
            {
                listbox.Items.Add(car);
            }
        }
    }
}
