using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    public interface Addition
    {
        int Add(int Number1, int Number2);
    }
    public interface Subtraction
    {
        int Subtract(int Number1, int Number2);
    }
    public class PartialCalculator : Addition
    {
        public int Multiplication(int Number1, int Number2)
        {
            return Number1 * Number2;
        }
        public virtual int Division(int Number1, int Number2)
        {
            return Number1 / Number2;
        }

        public virtual int Add(int Number1, int Number2)
        {
            return Number1 + Number2;
        }

    }
    public class MultipleInheritance : PartialCalculator, Subtraction
    {

        public override int Add(int Number1, int Number2)
        {
            return Number1 + Number2;
        }
        public override int Division(int Number1, int Number2)
        {
            try
            {
                return Number1 / Number2;
            }
            catch
            {
                throw;
            }
        }

        public int Subtract(int Number1, int Number2)
        {
            return Number1 - Number2;
        }
    }
}
