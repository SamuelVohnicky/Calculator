using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    class Pocty : INotifyPropertyChanged
    {
        private string display;
        public string Display
        {
            get
            {
                return display;
            }
            set
            {
                display = value;
                OnPropertyChanged("Display");
            }
        }

        private string vysledek;
        public string Vysledek
        {
            get
            {
                return vysledek;
            }
            set
            {
                vysledek = value;
                OnPropertyChanged("Vysledek");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int numA = 0;
        private int numB = 0;
        private string func;

        public void Sign()
        {
            if (Convert.ToInt32(Vysledek) >= 0) { Vysledek.Remove(0); }
            else { Vysledek.Insert(0,"-"); }
        }

        public void Reset()
        {
            Vysledek = "";
            Display = "";
        }

        public void AddNumber(Object obj)
        {
            Display = Display + obj ;
        }

        public void Result()
        {
            numB = Convert.ToInt32(Display);
            if(func == "+") { Vysledek = (Convert.ToInt32(Vysledek) + numB).ToString(); }
            else if (func == "-") { Vysledek = (Convert.ToInt32(Vysledek) - numB).ToString(); }
            else if (func == "*") { Vysledek = (Convert.ToInt32(Vysledek) * numB).ToString(); }
            else if (func == "/") { Vysledek = (Convert.ToInt32(Vysledek) / numB).ToString(); }
            Display = Vysledek;
        }

        public void Plus()
        {
            func = "+";
            numA = Convert.ToInt32(Display);
            Vysledek = numA.ToString();
            Reset();
        }
        public void Minus()
        {
            func = "-";
            numA = Convert.ToInt32(Display);
            Vysledek = numA.ToString();
            Reset();
        }
        public void Multiply()
        {
            func = "*";
            numA = Convert.ToInt32(Display);
            Vysledek = numA.ToString();
            Reset();
        }
        public void Divide()
        {
            func = "/";
            numA = Convert.ToInt32(Display);
            Vysledek = numA.ToString();
            Reset();
        }
    }
}
