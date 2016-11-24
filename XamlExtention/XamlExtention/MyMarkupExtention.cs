using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace XamlExtention
{
    class MyMarkupExtention : IMarkupExtension
    {
        public string Extra { get; set; }
        public int Extratal { get; set; }
        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return  "jeg er en " + Extra +" dyr";
        }
    }
}
