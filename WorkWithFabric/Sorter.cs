using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithFabric
{
    public class Sorter
    {
        private SortFactory factory;

        public Sorter(SortFactory factory)
        {
            this.factory = factory;
        }

        public void Sort(int[] arr)
        {
            SortingAlgorithm algorithm = factory.CreateAlgorithm();
            algorithm.Sort(arr);
        }
    }

}
