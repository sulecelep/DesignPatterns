using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values= _context.Products.Select(x=>new GetProductQueryResult
            {
                ID= x.ProductID,
                Name=x.Name,
                Price=x.Price,
                Stock=x.Stock
            }).ToList();
            return values;
        }
    }
}
