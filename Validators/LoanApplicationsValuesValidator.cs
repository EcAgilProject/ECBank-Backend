using ECBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ECBank.Validators;

 public class LoanApplicationsValuesValidator
    {
    public bool IsAmountInRange(LoanApplication application)
    {
        int minAmount = 10000;
        int maxAmount = 600000;


        if (application == null)
        {
            throw new ArgumentNullException(nameof(application));
        }
        if (application.Amount > maxAmount || application.Amount<minAmount) 
        {
            return false;
        }
        return true;
    }
    public bool IspaybackPeriodInRange(LoanApplication application) {
        int minPaybackPeriod = 1;
        int maxPaybackPeriod = 12;

        if (application == null)
        {
            throw new ArgumentNullException(nameof(application));
        }

        if (application.PayBackPeriod < minPaybackPeriod
            || application.PayBackPeriod > maxPaybackPeriod
            ) {
            return false;
        }
        return true;
    }
    public bool IsValidSocialSecurityNumber(LoanApplication application) {
        
        string pattern = @"^\d{8}-\d{4}$";
        Regex regex = new Regex(pattern);

        return regex.IsMatch(application.SocialSecurityNumber);

    }
    public bool IsValidEmail(LoanApplication application)
    {
        string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(application.Email);
    }
    }
