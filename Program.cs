using System;
using System.Collections.Generic;
namespace heist_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker Joe = new Hacker();
            Joe.character("Joe", 20, 40);
            Hacker Josh = new Hacker();
            Josh.character("Josh", 30, 40);
            Muscle Eugene = new Muscle();
            Eugene.character("Eugene", 30, 20);
            LockSpecialist Larry = new LockSpecialist();
            Larry.character("Larry", 30, 40);
            LockSpecialist Lucius = new LockSpecialist();
            Lucius.character("Lucius", 40, 40);
            
            Random r = new Random();
            Bank TargetBank = new Bank()
            {
                CashOnHand = r.Next(50000, 1000000),
                AlarmScore = r.Next(100),
                VaultScore = r.Next(100),
                SecurityGuardScore = r.Next(100),
            };

            Console.WriteLine($"Cash on Hand: {TargetBank.CashOnHand}, Alarm Score: {TargetBank.AlarmScore}, Vault Score: {TargetBank.VaultScore}, Security Guard Score: {TargetBank.SecurityGuardScore}");

            List<IRobber> rolodex = new List<IRobber>() {
                Joe, Josh, Eugene, Larry, Lucius
            };

            Console.WriteLine("Number of operatives in rolodex: " + rolodex.Count);
            bool stillInputting = true;
            while (stillInputting)
            {
                Console.WriteLine("Enter team member's name:");
                string memberName = Console.ReadLine();
                if (memberName == "")
                {
                    stillInputting = false;
                    break;
                }

                Console.WriteLine("Pick one of three possible Specialities:");
                Console.WriteLine("1. Hacker");
                Console.WriteLine("2. Muscle");
                Console.WriteLine("3. Lock Specialist");
                string specialtySelect = Console.ReadLine();
                int specialtyNum = Int32.Parse(specialtySelect);


                Console.WriteLine("Enter team member's skill level:");
                string skillInput = Console.ReadLine();
                int SkillLevel = Int32.Parse(skillInput);

                Console.WriteLine("Enter team member's percentage cut:");
                string percentInput = Console.ReadLine();
                int percentCut = Int32.Parse(percentInput);


                if(specialtyNum == 1) {
                    Hacker dude = new Hacker();
                    dude.character(memberName, SkillLevel, percentCut);
                    rolodex.Add(dude);
                }
                else if(specialtyNum == 2) {
                    Muscle dude2 = new Muscle();
                     dude2.character(memberName, SkillLevel, percentCut);
                     rolodex.Add(dude2);
                }
                else {
                    LockSpecialist dude3 = new LockSpecialist();
                    dude3.character(memberName, SkillLevel, percentCut);
                    rolodex.Add(dude3);
                }
                foreach (IRobber robber in rolodex)
            {
                Console.WriteLine($"{robber.Name}");
            }

            }

            

            
        }
    }
}
