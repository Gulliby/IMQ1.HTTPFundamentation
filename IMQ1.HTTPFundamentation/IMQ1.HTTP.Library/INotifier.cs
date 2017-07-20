using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMQ1.HTTP.Library
{
    public interface INotifier
    {
        void Notify(string message);
    }
}
