using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DILifeSpans.MVC.ViewModels
{
    public class HomeViewModel
    {
        public Guid TransientOne, TransientTwo, ScopedOne, ScopedTwo, SingletonOne, SingletonTwo;
    }
}
