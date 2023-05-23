using ECBank.Constants;
using ECBank.Models;
using ECBank.Processor;
using ECBank.Validators;

namespace ECBank;

class Program
{
     static void Main(string[] args)
    {

      LoanApplication loanApplication = new LoanApplication()
      {
          ResidenceType = ResidenceType.RightOfResidence,
          EmploymentType = EmploymentType.PartTime,
          SocialSecurityNumber ="21210101-1234"
      };

      LoanApplicationsProcessor processor = new LoanApplicationsProcessor();

      LoanStatus loanStatus = processor.GetLoanStatus(loanApplication);
      int amount = processor.GetLoanAmount(loanApplication);

      LoanApplicationsValuesValidator validator = new LoanApplicationsValuesValidator();

      bool validSSN = validator.IsValidSocialSecurityNumber(loanApplication);

      Console.WriteLine(validSSN.ToString());
      Console.WriteLine(loanStatus.ToString());
      Console.WriteLine(amount.ToString());
      Console.ReadKey(true);
    }
}