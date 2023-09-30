using DesignPattern.ObserverDP.DAL;

namespace DesignPattern.ObserverDP.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode="DERGIMART",
                DiscountAmount=35,
                DiscountCodeStatus=true
            });
            context.SaveChanges();
        }
    }
}
