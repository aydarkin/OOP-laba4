using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4
{
    public interface IObserver
    {
        void OnPropertyChanged(IObservable subject, string property = null, object[] args = null);
        List<IObservable> GetSubjects();
    }
}
