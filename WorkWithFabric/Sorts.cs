using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithFabric
{
    public class SelectionSortFactory : SortFactory
    {
        public override SortingAlgorithm CreateAlgorithm()
        {
            return new SelectionSort();
        }
    }

    public class InsertionSortFactory : SortFactory
    {
        public override SortingAlgorithm CreateAlgorithm()
        {
            return new InsertionSort();
        }
    }

    public class MergeSortFactory : SortFactory
    {
        public override SortingAlgorithm CreateAlgorithm()
        {
            return new MergeSort();
        }
    }

}
