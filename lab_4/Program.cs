using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class Program
    {
        static public string text = "ART";
        static public int p = 45989;
        static public long[] NumberEncrypt;

        static void Main(string[] args)
        {
            Console.WriteLine("=====================================================================================================================");
            Console.WriteLine("                                                Лабораторная работа №4");
            Console.WriteLine("                          Выполнил: Скребнев Леонид, Чернуцкая Екатерина, Кутузов Леонид");
            Console.WriteLine("=====================================================================================================================");
            A_Abonent.PrintLog($"ИСходное сообщение: {text}", true);

            //Этап 1
            A_Abonent.SetP(p);//Абонент А выбирает Р
            A_Abonent.EnterG();//Абонент А вводит G
            A_Abonent.EnterX();//Абонент A вводит Х
            A_Abonent.CalculateY();//Высчитываем Y
            A_Abonent.PrintOpenKeys();//Вывод открытых ключей
            A_Abonent.PrintPrivateKeys();//Вывод закрытых ключей
            A_Abonent.SendOpenKeys();//Отправляем абоненту B открытый ключ
                                     //Этап 2
            NumberEncrypt = ELGAmal.TextToNumberEncrypt(text);
            ELGAmal.PrintNumberEncrypt(NumberEncrypt, true);

            //Этап 3
            A_Abonent.SignatureGeneration();//Генерация ЭЦП

            //Этап 4
            B_Abonent.verificationOfDigitalSignature(A_Abonent.a, A_Abonent.b, NumberEncrypt);
            Console.WriteLine("=====================================================================================================================");
        }
    }
}
