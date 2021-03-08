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

            while (name != "")
            {
                // Initialize local variables
                bool passedSkill = false;
                int skill = 0;
                bool passedCourage = false;
                int courage = 0;

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
                    Console.Write($"Enter {name}'s courage factor (number): ");
                    passedCourage = int.TryParse(Console.ReadLine(), out courage);
                }
                Console.WriteLine();

                Member teamMember = new Member(name, skill, courage);

                team.AddMember(teamMember);
                Console.WriteLine("To stop adding members, enter a blank name");
            }
            Console.WriteLine();
            Console.WriteLine($"There are {team.Members.Count} members on the team");
            foreach (Member member in team.Members)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Member Name: {member.Name}");
                Console.WriteLine($"Member Skill: {member.Skill}");
                Console.WriteLine($"Member Courage: {member.Courage}");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine();
            }
        }
    }
}
