using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var advertManager = new AdvertManager(new EfAdvertDal());
            foreach (var advert in advertManager.GetAdvertDetails().Data)
            {
                Console.WriteLine(advert.AdvertName +"-"+advert.ProductName+"-"+advert.CategoryName);
            }

            //AdvertTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            var categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void AdvertTest()
        {
            AdvertManager productManager = new AdvertManager(new EfAdvertDal());

            foreach (var item in productManager.GetAll().Data)
            {
                Console.WriteLine(item.ProductName + " " + item.Description);
            }
        }
    }
}
