using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    // Define a custom attribute to indicate voting eligibility
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class VotingEligibilityAttribute : Attribute
    {
        public int MinimumVotingAge { get; }

        public VotingEligibilityAttribute(int minimumAge)
        {
            MinimumVotingAge = minimumAge;
        }
    }

    // Apply the custom attribute to the Person class
    [VotingEligibilityAttribute(18)]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create a person object
            Person person1 = new Person("Alice", 25);
            Person person2 = new Person("Bob", 17);

            // Check if each person is eligible to vote based on the attribute
            if (IsEligibleToVote(person1))
            {
                Console.WriteLine($"{person1.Name} is eligible to vote.");
            }
            else
            {
                Console.WriteLine($"{person1.Name} is not eligible to vote.");
            }

            if (IsEligibleToVote(person2))
            {
                Console.WriteLine($"{person2.Name} is eligible to vote.");
            }
            else
            {
                Console.WriteLine($"{person2.Name} is not eligible to vote.");
            }
        }
        static bool IsEligibleToVote(Person person)
        {
            // Retrieve the VotingEligibilityAttribute from the person's type
            var attribute = (VotingEligibilityAttribute)Attribute.GetCustomAttribute(person.GetType(), typeof(VotingEligibilityAttribute));

            // If attribute is null (should not happen in this example), default to false
            if (attribute == null)
            {
                return false;
            }

            // Check if the person's age meets the minimum voting age specified in the attribute
            return person.Age >= attribute.MinimumVotingAge;
        }
    }
}
