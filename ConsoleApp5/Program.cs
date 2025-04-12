using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            //4
            /*Console.WriteLine("Введіть логічний вираз (наприклад, 3>2, 7<3):");
            string expression = Console.ReadLine();

            try
            {
                bool result = EvaluateExpression(expression);
                Console.WriteLine($"Результат виразу '{expression}' : {result}");
            }
           
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Помилка в виразі: {ex.Message}");
                Console.WriteLine("Перевірте правильність введення чисел та операторів.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Невідома помилка: {ex.Message}");
            }
        }

        static bool EvaluateExpression(string expression)
        {
            expression = expression.Replace(" ", "");

            int? lOperand = null;
            int? rOperand = null;
            string opSymbol = null;
            int opIndex = -1;

           
            string[] operators = { ">=", "<=", "==", "!=", ">", "<" };
            foreach (string op in operators)
            {
                int index = expression.IndexOf(op);
                if (index != -1)
                {
                    opSymbol = op;
                    opIndex = index;
                    break;
                }
            }

            if (opSymbol == null || opIndex == -1)
            {
                throw new FormatException("Не знайдено коректного оператора.");
            }

            // Отримання операндів
            string lPart = expression.Substring(0, opIndex);
            string rPart = expression.Substring(opIndex + opSymbol.Length);

            if (!int.TryParse(lPart, out int lNum))
            {
                throw new FormatException($"Неправильний формат лівого операнда: '{lPart}'.");
            }
            lOperand = lNum;

            if (!int.TryParse(rPart, out int rNum))
            {
                throw new FormatException($"Неправильний формат правого операнда: '{rPart}'.");
            }
            rOperand = rNum;

            // Виконання операції
            switch (opSymbol)
            {
                case ">":
                    return lOperand > rOperand;
                case "<":
                    return lOperand < rOperand;
                case ">=":
                    return lOperand >= rOperand;
                case "<=":
                    return lOperand <= rOperand;
                case "==":
                    return lOperand == rOperand;
                case "!=":
                    return lOperand != rOperand;
                default:
                    throw new ArgumentException($"Невідомий оператор: '{opSymbol}'.");
                        */



            //2
            /* Dictionary<string, int> wordToDigit = new Dictionary<string, int>()
             {
                 {"zero", 0},
                 {"one", 1},
                 {"two", 2},
                 {"three", 3},
                 {"four", 4},
                 {"five", 5},
                 {"six", 6},
                 {"seven", 7},
                 {"eight", 8},
                 {"nine", 9}
             };

             Console.WriteLine("Введіть цифру від нуля до дев'яти словами:");
             string inputWord = Console.ReadLine().ToLower();

             if (wordToDigit.ContainsKey(inputWord))
             {
                 int digit = wordToDigit[inputWord];
                 Console.WriteLine($"Ви ввели цифру: {digit}");
             }
             else
             {
                 Console.WriteLine("Некоректне введення. Будь ласка, введіть цифру від нуля до дев'яти словами.");
             }*/


            //}
            
        }
        
    }
}

