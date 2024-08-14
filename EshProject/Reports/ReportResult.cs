using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EshProject
{
    public class ReportResult
    {
        public void LogResultToFile(OperationResult result)
        {
            string filePath = "testResults.log";
            string logMessage = $"Test executed at {result.RunTime}: Test Result = {(result.Message)}";

            try
            {
                File.AppendAllText(filePath, logMessage + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error logging to file: {ex.Message}");
            }
        }
    }
}
