using DesignPattern.ObserverDP.DAL;

namespace DesignPattern.ObserverDP.ObserverPattern
{

    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "Bilim dergimizin Mart Sayısı 1 Mart'ta evinize ulaştırılacaktır." +
                "Konular: Jüpiter Gezegeni ve Mars olacaktır.",
                Magazine= "Bilim Dergisi"
            });
            context.SaveChanges();
        }
    }
}
