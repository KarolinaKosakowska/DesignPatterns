using Decorator.FACADE;
using Decorator.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        //{
        /// Decorator
        //    PasswordWriter passwordWriter = new MyPasswordWriter();
        //    Console.WriteLine(passwordWriter.Save("123456"));
        //    PasswordWriter passwordDecorator = new ConcretePassword(passwordWriter);
        //    Console.WriteLine(passwordDecorator.Save("kkkk"));
        //    passwordDecorator = new BestPassword(passwordDecorator);
        //    Console.WriteLine(passwordDecorator.Save("bbbb"));
        //    Console.Read();


        ///Proxy
        //Console.WriteLine("Wprowadzony użytkownik: user, hasło: user");
        //ProxyPermisions proxyUser = new ProxyPermisions("user", "user");
        //Console.WriteLine($"Czy jest autoryzacja: {proxyUser.IsAuthenticated()}");

        //Console.WriteLine("Wprowadzony użytkownik: admin, hasło: admin");
        //ProxyPermisions proxyAdmin = new ProxyPermisions("admin", "admin");
        //Console.WriteLine($"Czy jest autoryzacja: {proxyAdmin.IsAuthenticated()}");

        //Console.Read();

        //{
        //    //Composite
        //    var Tree = new Composite();
        //    var branch = new Composite();
        //    branch.Add(new Leaf());
        //    branch.Add(new Leaf());
        //    branch.Add(new Leaf());
        //    var branch2 = new Composite();
        //    branch2.Add(new Leaf());
        //    branch2.Add(new Leaf());

        //    Tree.Add(branch);
        //    Tree.Add(branch2);

        //    Console.WriteLine(Tree.Show());
        //    Console.Read();
        //}
        {
            //PizzeriaKitchen pizzeriaKitchen = new PizzeriaKitchen();
            //Console.WriteLine(pizzeriaKitchen.GetPizzaDough());
            //Console.WriteLine(pizzeriaKitchen.Baking());
            //Console.WriteLine(pizzeriaKitchen.GetNoWegAddmixture());
            //Console.WriteLine(pizzeriaKitchen.GetNoWegAddmixture());

            WegPizza wegPizza = new WegPizza();
            Console.WriteLine(wegPizza.GetWegPizza());

            NoWegPizza noWegPizza = new NoWegPizza();
            Console.WriteLine(noWegPizza.GetNoWegPizza());


            Console.Read();



        }
    }
}
