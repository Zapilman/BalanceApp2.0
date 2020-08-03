using System;
using System.Collections.Generic;
using System.Text;

namespace BalanceApp.BL.Controller
{
    public interface IDataSaver
    {
        void Save(string filename, object item);

        T Load<T>(string filename);

    }
}
