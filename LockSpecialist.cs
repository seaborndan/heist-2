using System;

namespace heist_2
{
    public class LockSpecialist : IRobber
    {
      public string Name {get; set;}
      public int SkillLevel {get; set;}
      
      public int PercentageCut {get; set;}

      public void PerformSkill(Bank b) {
        b.VaultScore = b.VaultScore - SkillLevel; 
        Console.WriteLine(Name + " is opening the vault. Decreased security by " + SkillLevel + " points");
        if(b.VaultScore <= 0) {
          Console.WriteLine(Name + " has unlocked the vault");
        }
      }


      public void character(string nameInput, int skillInput, int percentInput) {
        Name = nameInput;
        SkillLevel = skillInput;
        PercentageCut = percentInput;
      }

    }
    
}