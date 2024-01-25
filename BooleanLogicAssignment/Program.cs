using System;

class CarInsuranceApprovalData
{
    public float age { get; set; } //this is the age variable from user
    public string hasDUI{ get; set; } 
    public float speedingTickets { get; set; } //this is # of speeding tix; 
                              
    public Boolean A => age > 16;  ///applicant; must be over age 15
    bool flag;
    public Boolean B => Boolean.TryParse(hasDUI, out flag);//this is the DUI question; anything >0 is rule-out
    public Boolean C => speedingTickets < 3; //anything over 3 is rule-out
};
namespace BooleanLogicAssignment
{
    class Program
    {
   
        static void Main(string[] args)
        {
            var applicant = new CarInsuranceApprovalData();
            Console.WriteLine("Basic Approval Program for Car Insurance");
            Console.WriteLine("Applicant: Please answer the following.");
            Console.WriteLine("What is your age?");
            applicant.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please indicate true or false.");
            applicant.hasDUI = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            applicant.speedingTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("We will compute your input and determine your eligibility for car insurance.");
            Console.WriteLine("Based on your input are you qualified for coverage?");
            Console.WriteLine(applicant.A && applicant.B && applicant.C);

            
        }
    }
}
