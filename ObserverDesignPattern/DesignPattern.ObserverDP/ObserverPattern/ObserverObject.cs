using DesignPattern.ObserverDP.DAL;

namespace DesignPattern.ObserverDP.ObserverPattern
{
    public class ObserverObject
    {
        //Gözlemleme listemiz 
        private readonly List<IObserver> _observers;
        
        public ObserverObject()
        {
            _observers = new List<IObserver>();
        }

        

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObserver(AppUser appUser) 
        {
            //her bir kullanıcı için tetiklenecek metotların sıralamasını belirleyen metot
            _observers.ForEach(x =>
            {
                x.CreateNewUser(appUser);
            });
        }
    }
}
