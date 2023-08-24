using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductsByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductsByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var value= _context.Set<Product>().Find(query.Id);
            return new GetProductByIDQueryResult
            {
                Name = value.Name,
                Price = value.Price,
                Stock = value.Stock,
                ID = value.ProductID  
            };
        }
    }
}
