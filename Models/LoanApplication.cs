using ECBank.Constants;


namespace ECBank.Models;

public class LoanApplication
    {
    public int Amount { get; set; }
    public int PayBackPeriod { get; set; }
    public string SocialSecurityNumber { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public MaritalStatusType MaritalStatusType { get; set; }
    public int Children { get; set; }
    public ResidenceType ResidenceType { get; set; }
    public decimal ResidenceCost { get; set; }
    public EmploymentType EmploymentType { get; set; }
    public  int Salary { get; set; }
    public DateTime EmployedSince { get; set; }
    public string EmployerName { get; set; }
}
