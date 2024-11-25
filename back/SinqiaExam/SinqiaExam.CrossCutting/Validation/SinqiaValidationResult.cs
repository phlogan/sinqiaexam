using System.Collections.Generic;
using System.Linq;

namespace SinqiaExam.CrossCutting.Validation
{
    public class SinqiaValidationResult
    {
        public SinqiaValidationResult()
        {
            ErrorList = new List<string>();
        }
        public bool IsValid { get => !ErrorList.Any(); }
        public List<string> ErrorList { get; set; }

        public void AddIf(bool condition, string errorMessage)
        {
            if (condition)
                ErrorList.Add(errorMessage);
        }
    }
}
