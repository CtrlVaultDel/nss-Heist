using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize local variables
            string name;
            bool passedSkill = false;
            int skill = 0;
            bool passedCourage = false;
            int courage = 0;

            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine();

            // New Member
            Console.Write("Enter a team member's name: ");
            name = Console.ReadLine();
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

            Console.WriteLine($"Member Name: {teamMember.Name}");
            Console.WriteLine($"Skill: {teamMember.Skill}");
            Console.WriteLine($"Courage: {teamMember.Courage}");
        }
    }
}
