using System;

namespace C4_TemplateMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            Account account = new CurrentAccount();//SavingAccount
            if (account != null)
            {
                account.Handle("张无忌", "123456");
            }

            Console.ReadKey();
        }
    }
}
