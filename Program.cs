using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_answerTheQestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userZodiacSign;
            string userPlaceOfWork;
            int userAge;

            Console.Write("Здравствуйте!\nКак вас зовут?: ");
            userName = Console.ReadLine();
            Console.Write("А сколько вам лет?: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Какой у вас знак зодиака?: ");
            userZodiacSign = Console.ReadLine();
            Console.Write("Где вы работаете?: ");
            userPlaceOfWork = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Вас зовут {userName}, вам {userAge} год, вы {userZodiacSign}" +
                              $" и работаете в(на) {userPlaceOfWork}е.\n");
        }
    }
}

