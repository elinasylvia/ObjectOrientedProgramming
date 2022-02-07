using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExercise
{
    interface ICustomer
    {
       
       Customer GetCustomer(string name);

       
       double GetBonus();
        
    }
}
