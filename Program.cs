﻿using ECBank.Constans;
using ECBank.Models;
using ECBank.Proseccor;

namespace ECBank;

class Program
{
     static void Main(string[] args)
    {



      LoanApplication loanApplication = new LoanApplication()
      {
          ResidenceType = ResidenceType.Tenancy,
          EmploymentType = EmploymentType.Student,

      };

      LoanApplicationsProcessor loanApplicationsProseccor1 = new LoanApplicationsProcessor();

      LoanStatus loanStatus = loanApplicationsProseccor1.GetLoanStatus(loanApplication);

      Console.WriteLine(loanStatus.ToString());
      Console.ReadKey(true);
    }
}