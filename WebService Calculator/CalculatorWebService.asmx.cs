using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService_Calculator
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://localhost:3591/CalculatorWebService/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        [WebMethod]
        public int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        [WebMethod]
        public int Div(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0) return 0;
            return firstNumber / secondNumber;
        }

        [WebMethod]
        public int Mult(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
