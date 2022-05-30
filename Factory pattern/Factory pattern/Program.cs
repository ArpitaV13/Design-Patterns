using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class MembershipFactory

    {
        static void Main(string[] args)
        {
            Membershipfactory obj = new ConcreteMembership();
            Console.WriteLine("Which membership ?");
            string type = Console.ReadLine();
            Igym instance = obj.GetGymMembershiptype(type);
            Console.WriteLine(instance.getCharges());
            Console.ReadLine();
        }
    }
    public interface Igym
    {
        int getCharges();
    }
    public class Monthly : Igym
    {
        public int getCharges()
        {
            return 2000;
        }
    }
    public class Yearly : Igym
    {
        public int getCharges()
        {
            return 8000;
        }
    }
    public abstract class Membershipfactory
    {
        public abstract Igym GetGymMembershiptype(string type);
    }
    public class ConcreteMembership : Membershipfactory
    {
        public override Igym GetGymMembershiptype(string type)
        {
            switch (type)
            {
                case "Monthly":
                    return new Monthly();
                case "Yearly":
                    return new Yearly();
                default:
                    throw new ApplicationException(string.Format("membership'{0}' not available"));
            }

        }
    }

}
