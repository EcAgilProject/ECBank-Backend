using ECBank.Models;
using System.Text.RegularExpressions;

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
        bool validLengthAndType = regex.IsMatch(application.SocialSecurityNumber);


        int century = int.Parse( application.SocialSecurityNumber.Substring(0, 2));
        bool validCentury = century == 19 || century == 20;

        return (validLengthAndType&&validCentury);
        
    }
    public bool IsValidEmail(LoanApplication application)
    {
        string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(application.Email);
    }
    }
