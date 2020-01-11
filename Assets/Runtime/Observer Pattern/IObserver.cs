namespace Noodlepop.ObserverPattern
{
    public interface IObserver
    {
        void Update(IObservable observable);
    }
}