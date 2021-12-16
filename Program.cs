#define DEBUG_ACCOUNT
using System;
// подключаем атрибуты
using System.Runtime.InteropServices;
// подключаем атрибут Conditional
using System.Diagnostics;
namespace Lesson_18_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Упражнение 14.1");
            BankAccount acc1 = new BankAccount(type: BankAccount.TypeOfAccount.Current, balance: 77000);
            acc1.DumpToScreen();

            // в Debug увидим Current 77000$
            // в Release увидим Current 77000$
            Console.ReadKey();

            // без #define DEBUG_ACCOUNT мы:
            // в Debug увидим Current 77000$
            // в Release ничего не увидим
            // в Release метод DumpToScreen() не вызовется

            Console.WriteLine("Упражнение 14.2");
            System.Reflection.MemberInfo attrInfo;
            // присваиваем объекту типа MemberInfo тип Rational_numbers, используя оператор typeof:
            attrInfo = typeof(Rational_numbers);
            // для получения значения атрибутов, используем метод GetCustomAttributes
            object[] attrs = attrInfo.GetCustomAttributes(false);
            DeveloperInfoAttribute developerAttr;
            developerAttr = (DeveloperInfoAttribute)attrs[0];
            Console.WriteLine("Developer: {0}\tDate: {1}", developerAttr.Developer, developerAttr.Date);
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 14.1");
            System.Reflection.MemberInfo attr1Info;
            // присваиваем объекту типа MemberInfo тип Rational_numbers, используя оператор typeof:
            attr1Info = typeof(Building);
            // для получения значения атрибутов, используем метод GetCustomAttributes
            object[] attrs1 = attr1Info.GetCustomAttributes(false);
            BuildingInfoAttribute developerAttr1;
            developerAttr1 = (BuildingInfoAttribute)attrs1[0];
            Console.WriteLine("Developer: {0}\tOrganization: {1}", developerAttr1.Developer, developerAttr1.Organization);
            Console.ReadKey();
        }
    }
}
