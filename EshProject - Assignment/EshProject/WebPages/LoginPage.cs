using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EshProject
{
    public class LoginPage : BaseEsh
    {
        public IWebElement EmailField => Driver.FindElement(By.CssSelector("input[class*='MuiInputBase-input MuiOutlinedInput-input css-1pog434']"));
        public IWebElement PasswordField => Driver.FindElement(By.CssSelector("input[class*='MuiInputBase-input MuiOutlinedInput-input MuiInputBase-inputAdornedEnd css-16sx77j']"));

        public IWebElement LoginButton => Driver.FindElement(By.CssSelector("button[type='submit']"));

        public bool CheckIfLoginSuccess() 
        {
            /** here we check if the login succeeded we can check it by url or element that exist in the page 
             that the site redirect to after login success  if it fail it need return false**/
            return true;
        }
    }
}
