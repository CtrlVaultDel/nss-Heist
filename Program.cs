using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize team & name
            Team team = new Team();
            string name = "Not blank";

            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine();

            int bankDifficulty = 100;

            while (name != "")
            {
                // Initialize local variables
                bool passedSkill = false;
                int skill = 0;
                bool passedCourage = false;
                decimal courage = 0.0m;

                // New Member
                Console.Write("Enter a team member's name: ");
                name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                Console.WriteLine();

                // Member's Skill
                while (!passedSkill)
                {
                    Console.Write($"Enter {name}'s skill level (number): ");
                    passedSkill = int.TryParse(Console.ReadLine(), out skill);
                }
                Console.WriteLine();

                // Member's Courage
                while (!passedCourage)
                {
                    Console.Write($"Enter {name}'s courage factor (0.0-2.0): ");
                    passedCourage = decimal.TryParse(Console.ReadLine(), out courage);
                    if (courage < 0m || courage > 2m)
                    {
                        passedCourage = false;
                    }
                }
                Console.WriteLine();

                Member teamMember = new Member(name, skill, courage);

                team.AddMember(teamMember);
                Console.WriteLine("To stop adding members, enter a blank name");
            }
            Console.WriteLine();
            Console.WriteLine($"There are {team.Members.Count} members on the team");

            int totalSkill = 0;

            foreach (Member member in team.Members)
            {
                totalSkill += member.Skill;
            }
            // Prepare random number for "luck"
            Random rnd = new Random();
            int luck = rnd.Next(-10, 11);

            bankDifficulty += luck;

            Console.WriteLine($"Team Skill Level: {totalSkill}");
            Console.WriteLine($"Bank Difficulty Level: {bankDifficulty}");
            Console.WriteLine();

            if (totalSkill >= bankDifficulty)
            {
                Console.WriteLine("The heist was successful!");
            }
            else
            {
                Console.WriteLine("The heist failed.");
            }
        }
    }
}
