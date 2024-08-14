using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EshProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportResult reportResult = new ReportResult();

            ValidLogin validLogin = new ValidLogin();
            validLogin.RunTest();

        }
    }
}
