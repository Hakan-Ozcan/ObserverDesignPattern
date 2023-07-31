using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
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
