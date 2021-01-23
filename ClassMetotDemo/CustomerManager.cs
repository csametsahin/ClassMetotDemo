using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void customeAdd(Customer customer)
        {
            Console.WriteLine(customer.name + " Eklendi");
        }

        public void customeDelete(Customer customer)
        {
            Console.WriteLine(customer.name + " Silindi");
        }

        public void printCustomer(Customer[] customer)
        {
            foreach (Customer c in customer)
            {
                Console.WriteLine(c.name + " Kişisinin Balance'si : " + c.balance);
            }
        }



    }
}
