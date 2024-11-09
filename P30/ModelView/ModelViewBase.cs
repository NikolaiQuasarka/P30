using P30.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P30.ModelView
{
    internal abstract class ModelViewBase<T> : INotifyPropertyChanged where T : ModelBase
    {
        public ModelViewBase()
        {
            this.LoadData();
        }
        public BindingList<T> Entities { get; set; } = new BindingList<T>();
        private void ExecuteWithContext(Action<StudyProcessContext> fun)
        {
            using(var db = new StudyProcessContext())
            {
                fun(db);
            }
        }
        public void LoadData()
        {
            ExecuteWithContext(context =>
            {
                Entities = new BindingList<T>(context.Set<T>().ToList());
            });
        }
        public void Add()
        {
            ExecuteWithContext(context =>
            {
                T entity = CreateNewEntity();
                var entityDB = context.Set<T>();
                entityDB.Add(entity);
                context.SaveChanges();
                Entities.Add(entity);
            });
        }
        public void Remove()
        {
            if(SelectedEntity != null)
            {
                ExecuteWithContext(context =>
                {
                    var entityDB = context.Set<T>();
                    entityDB.Remove(SelectedEntity);
                    context.SaveChanges();
                    Entities.Remove(SelectedEntity);
                });
            }
        }
        public void Update()
        {

        }

        protected abstract T CreateNewEntity();
        public T? SelectedEntity {  get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
