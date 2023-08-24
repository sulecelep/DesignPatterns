using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand command)
        {
            var value = _context.Products.Find(command.ProductID);
            value.Name = command.Name; 
            value.Description = command.Description; 
            value.Price = command.Price;
            value.Stock = command.Stock;
            value.ProductID = command.ProductID;
            value.Status = true;
            _context.SaveChanges();
            
        }
    }
}
