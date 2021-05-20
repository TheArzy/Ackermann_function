using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1_5_5_Ackermann_function
{
    class Program
    {
        /// <summary>
        /// Ввод числа и проверка соответствия условиям
        /// </summary>
        /// <param name="paramMax">Максимальное значение для вводимого числа</param>
        /// <param name="paramMin">Минимальное значение для вводимого числа</param>
        /// <returns>Проверенное введенное число</returns>
        static long Input(long paramMax, long paramMin)
        {
            long input;
            while (true)
            {
                if (long.TryParse(ReadLine(), out input) && input <= paramMax && input >= paramMin) break;
                else Write($"Число должно быть целым от {paramMin} до {paramMax}, попробуйте еще раз: ");
            }
            return input;
        }

        /// <summary>
        /// Функция Аккермана
        /// </summary>
        /// <param name="mom">Параметр мом</param>
        /// <param name="nom">Параметр ном</param>
        /// <returns>Значение функции при заданных параметрах</returns>
        static long AckerFun(long mom, long nom)
        {
            if (mom == 0) return nom + 1;
            else if (mom > 0 & nom == 0) return AckerFun(mom - 1, 1);
            else if (mom > 0 & nom > 0) return AckerFun(mom - 1, AckerFun(mom, nom - 1));
            return 0;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("--------------------------------\n");
                WriteLine("Введите первый и второй параметры функции:");
                WriteLine(AckerFun(Input(long.MaxValue, long.MinValue), Input(long.MaxValue, long.MinValue)));
                WriteLine("\n--------------------------------\n");

                #region Повтор или выход

                WriteLine("Запустить заново? 1 - Повтор | 0 - Выход");
                Write("Выбор: ");
                if (Input(1, 0) == 0) break; // Завершение программы
                WriteLine();

                #endregion
            }
        }
    }
}
