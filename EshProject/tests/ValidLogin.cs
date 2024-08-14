namespace EshProject
{
    public class ValidLogin : LoginPage
    {
        OperationResult result;

        public void RunTest()
        {
            result = new OperationResult();
            InsertUrl(Url);

            EmailField.SendKeys("john_doe@company.con");
            PasswordField.SendKeys("123456)");
            LoginButton.Click();

            result.Success = CheckIfLoginSuccess();
            result.RunTime = System.DateTime.Now;

            SetResult();
            reportResult.LogResultToFile(result);
        }

        private void SetResult()
        {
            if (CheckIfLoginSuccess() == true)
            {
                result.Message = "test passed";
            }
            else
            {
                result.Message = "test failed";
            }
        }
    }
}
