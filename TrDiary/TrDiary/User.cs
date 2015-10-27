using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TrDiary
{
    class User : INotifyPropertyChanged
    {
        protected string _name;
        public String UserName
        {
            get { return _name; }

            set
            {
                _name = value;
                // Сообщаем всем, кто подписан на событие PropertyChanged, что поле изменилось Name
                RaisePropertyChanged("UserName");
            }
        }
        public DateTime Birthday { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public User()
        {
            UserName = "sklksd";
            Weight = 78;
            Height = 100;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        // Для удобства обернем событие в метод с единственным параметром - имя изменяемого свойства
        public void RaisePropertyChanged(string propertyName)
        {
            // Если кто-то на него подписан, то вызывем его
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
