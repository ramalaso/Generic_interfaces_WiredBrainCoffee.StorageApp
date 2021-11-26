using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public static class RepositoryExtensions
    {
        public static void Addbatch<T>(this IWriteRepository<T> repository, T[] items)
        {
            foreach (T item in items)
            {
                repository.Add(item);
            }
            repository.Save();
        }
    }
}
