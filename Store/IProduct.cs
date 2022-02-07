using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExercise
{
    interface IProduct
    {
        Product GetProduct(string name);
        double CalculateTotal();
    }
}
