using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithFabric
{
    public abstract class SortFactory
    {
        public abstract SortingAlgorithm CreateAlgorithm();
    }

}
