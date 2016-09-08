using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDanMatsy
{
    public class Service1 : IService1
    {
        public string Soma(int a, int b)
        {
            return "A: (" + a.ToString() + ") + B(" + b.ToString() + ") = " + (a + b).ToString();
        }
    }
}
