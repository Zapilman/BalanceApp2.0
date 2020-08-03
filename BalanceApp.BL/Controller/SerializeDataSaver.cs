using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BalanceApp.BL.Controller
{
    public class SerializeDataSaver : IDataSaver
    {
       

        public void Save(string filename, object item)
        {
            var formatter = new BinaryFormatter();
            using (var file = new FileStream(filename, FileMode.Create))
            {
                formatter.Serialize(file, item);
            }
        }

        public T Load<T>(string filename)
        {
            var formatter = new BinaryFormatter();
            using (var file = new FileStream(filename, FileMode.OpenOrCreate))
            {
                if (file.Length > 0 && formatter.Deserialize(file) is T items)
                {
                    return items;
                }
                else
                {
                    return default;
                }
            }
        }
    }
}