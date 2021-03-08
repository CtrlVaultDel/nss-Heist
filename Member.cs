namespace Heist
{
    public class Member
    {
        public string Name { get; set; }
        public int Skill { get; set; }
        public int Courage { get; set; }

        public Member(string name, int skill, int courage)
        {
            Name = name;
            Skill = skill;
            Courage = courage;
        }
    }
}