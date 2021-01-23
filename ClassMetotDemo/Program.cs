using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer();
            Customer c3 = new Customer();
            Customer c4 = new Customer();
            CustomerManager manage = new CustomerManager();

            c1.ID = 0;
            c2.ID = 1;
            c3.ID = 2;
            c4.ID = 3;
            c1.name = "Ahmet";
            c1.surname = "Sonuç";
            c1.balance = 10000;
            c2.name = "Samet";
            c2.surname = "Şahin";
            c2.balance = 100;
            c3.name = "Kader";
            c3.surname = "Atas";
            c3.balance = 222;
            c4.name = "Rıza";
            c4.surname = "baba";
            c4.balance = 100000;


            Customer[] cArray = new Customer[] { c1, c2, c3, c4 };

            manage.customeAdd(c1);
            manage.customeAdd(c2);
            manage.customeAdd(c3);
            manage.customeAdd(c4);


            manage.customeDelete(c1);
            manage.customeDelete(c2);
            manage.customeDelete(c3);
            manage.customeDelete(c4);

            manage.printCustomer(cArray);






        }
    }
}
