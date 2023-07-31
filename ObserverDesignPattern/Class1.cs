using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{


    // Gözlemci (Observer) arayüzü
    public interface IObserver
    {
        void Update(string news);
    }

    // Somut Gözlemci (Concrete Observer) sınıfı
    public class Subscriber : IObserver
    {
        private string name;

        public Subscriber(string name)
        {
            this.name = name;
        }

        public void Update(string news)
        {
            Console.WriteLine($"{name} received news: {news}");
        }
    }

    // Konu (Subject) soyut sınıfı
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(string news);
    }

    // Somut Konu (Concrete Subject) sınıfı
    public class NewsSite : ISubject
    {
        private List<IObserver> observers;
        private string latestNews;

        public NewsSite()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(string news)
        {
            latestNews = news;
            foreach (var observer in observers)
            {
                observer.Update(latestNews);
            }
        }

        public void AddNews(string news)
        {
            NotifyObservers(news);
        }
    }
}
