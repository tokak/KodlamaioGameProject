
using KodlamaioGameProject.Abstract;
using KodlamaioGameProject.Adapters;
using KodlamaioGameProject.Concrete;
using KodlamaioGameProject.Entities;
using System;

namespace KodlamaioGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Mernis kimlik doğrulaması ile üye ekleme,Satiş ve kampanya ekleme,silme ve güncelle işlemleri gösteren mini uygulama.
             */

            Gamer gamer = new Gamer() { Id=1, FirstName="Murat", LastName="Tokak", BirthDay=new DateTime(1997,05,25), NationalityId="26941565132"};                      
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            //Mernis kimlik doğrulama ile oyuncu ekleme
            gamerManager.Add(gamer);
            gamerManager.Delete(gamer);

            Console.WriteLine("-------------------------");

            //Kampanyalı ve kampanyasız ürün girişi 
            Game game = new Game() {  Name="Call Of Duty", Price=150};
            Campaign campaign = new Campaign() {  Name= "Season discount" , DiscountRate=10};
            ISalesService salesService = new SalesManager();
            salesService.Add(game,campaign);
            salesService.Add(game);
            salesService.Delete(1);







        }
    }
}