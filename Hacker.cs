using System;

namespace heist_2
{
    public class Hacker : IRobber
    {
      public string Name {get; set;}
      public int SkillLevel {get; set;}
      
      public int PercentageCut {get; set;}

      public void PerformSkill(Bank b) {
        b.AlarmScore = b.AlarmScore - SkillLevel; 
        Console.WriteLine(Name + " is hacking the alarm system. Decreased security by " + SkillLevel + " points");
        if(b.AlarmScore <= 0) {
          Console.WriteLine(Name + " has disabled the alarm system");
        }
      }

      public void character(string nameInput, int skillInput, int percentInput) {
        Name = nameInput;
        SkillLevel = skillInput;
        PercentageCut = percentInput;
      }

    }
    
}