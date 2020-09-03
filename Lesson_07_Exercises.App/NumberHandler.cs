using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07_Exercises.App
{
    public class NumberHandler : INumberHandler
    {
        public IEnumerable<int> GetEvenNumbers(IEnumerable<int> numbers)
        {
            var result = numbers.Where(n => n % 2 == 0);
            return result;
        }

        public IEnumerable<int> GetNumbersDivisibleByAllDivisors(IEnumerable<int> numbers, IEnumerable<int> divisors)
        {
            var result = numbers.Where(number => divisors.All(divisor => number % divisor == 0));            
            return result;
        }

        public IEnumerable<int> GetNumbersDivisibleByAtLeastOneDivisor(IEnumerable<int> numbers, IEnumerable<int> divisors)
        {
            var result = numbers.Where(number => divisors.Any(divisor => number % divisor == 0));
            return result;
        }

        public IEnumerable<int> GetNumbersNotDivisibleByAnyDivisor(IEnumerable<int> numbers, IEnumerable<int> divisors)
        {
            var result = numbers.Where(number => divisors.All(divisor => number % divisor != 0));
            return result;
        }

        public IEnumerable<int> GetOddNumbers(IEnumerable<int> numbers)
        {
            var result = numbers.Where(n => n % 2 != 0);
            return result;
        }

        public IEnumerable<int> GetPrimeNumbers(IEnumerable<int> numbers)
        {
            throw new NotImplementedException();
        }
    }
}
