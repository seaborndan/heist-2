using System;

namespace heist_2
{
    public class Muscle : IRobber
    {
      public string Name {get; set;}
      public int SkillLevel {get; set;}
      
      public int PercentageCut {get; set;}

      public void PerformSkill(Bank b) {
        b.SecurityGuardScore = b.SecurityGuardScore - SkillLevel; 
        Console.WriteLine(Name + " is beating up security guards. Decreased security by " + SkillLevel + " points");
        if(b.SecurityGuardScore <= 0) {
          Console.WriteLine(Name + " has taken out all the guards");
        }
      }

      public void character(string nameInput, int skillInput, int percentInput) {
        Name = nameInput;
        SkillLevel = skillInput;
        PercentageCut = percentInput;
      }


    }
    
}