using System;
using System.Collections.Generic;
using System.Text;

namespace BalanceApp.BL.Controller
{
    public abstract class ControllerBase
    {
        protected IDataSaver manager = new SerializeDataSaver();

        protected void Save<T>(List<T> item) where T : class
        {
            manager.Save(item);
        }

        protected List<T> Load<T>() where T : class
        {
            return manager.Load<T>();
        }
    }

    



}
