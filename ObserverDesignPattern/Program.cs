using ObserverDesignPattern;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Haber sitesi oluşturuyoruz
        NewsSite newsSite = new NewsSite();

        // İzleyicileri (gözlemcileri) oluşturuyoruz
        IObserver subscriber1 = new Subscriber("John");
        IObserver subscriber2 = new Subscriber("Alice");
        IObserver subscriber3 = new Subscriber("Bob");

        // İzleyicileri haber sitesine kaydediyoruz
        newsSite.RegisterObserver(subscriber1);
        newsSite.RegisterObserver(subscriber2);
        newsSite.RegisterObserver(subscriber3);

        // Haber ekliyoruz, izleyicilere bildirim gidecek
        newsSite.AddNews("New product launched!");
    }
}
