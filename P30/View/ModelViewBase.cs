using P30.Model;
using P30.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P30.View
{
    internal abstract class ModelViewBase<T>:INotifyPropertyChanged where T: ModelBase
    {
        public BindingList<T> Items { get; set; }
        private void  ExecuteWithContext(Action)
        {

        }
        public void Add(T item)
        {
           
        }
        public void Remove(T item) 
        {
        
        }
        public void Update(T item)
        {

        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
