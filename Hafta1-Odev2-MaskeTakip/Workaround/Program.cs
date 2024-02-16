using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tc No bilgisi MERNİS'ten kontrol edilerek, kişiye maske verilip verilemeyeceği kontrolü yapılıyor... \n");

            Person person= new Person();
            person.FirstName = "Gönül";
            person.LastName = "Kaba";
            person.DateOfBirthYear = 1999;
            person.NationalIdentity = 123;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);
        }
    }
}

