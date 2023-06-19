using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_3
{
    public class Car
    {
        private int id;
        private double mileage;
        private double expenditure;
        private bool sc = true;

        public Car( int ids,double mileages, double expenditures)
        {
            id = ids;
            mileage = mileages;
            expenditure = expenditures;
        }
        public Car()
        {

        }
        public bool Sc
        {
            get { return sc; }
            set { sc = value; }
        }
        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                {
                    id = value;
                    sc = true;
                }
                else
                {
                    MessageBox.Show("Значение не может быть отрицательным", "Ошибка");
                    sc = false;
                }
            }
        }
        public double Mileage
        {
            get { return mileage; }
            set 
            {
                if (value > 0)
                {
                    mileage = value;
                    sc = true;
                }
                else
                {
                    MessageBox.Show("Значение не может быть отрицательным","Ошибка");
                    sc = false;
                }
            }
        }
        public double Expenditure
        {
            get { return expenditure; }
            set
            {
                if (value > 0)
                {
                    expenditure = value;
                    sc = true;
                }
                else
                {
                    MessageBox.Show("Значение не может быть отрицательным", "Ошибка");
                    sc = false;
                }
            }
        }
        public double q()
        {
            return mileage/expenditure;
        }
    }
}
