using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.CQRSPattern.Handlers;
using DesignPattern.CQRS.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly GetProductsByIDQueryHandler _getProductsByIDQueryHandler;
        private readonly RemoveProductCommandHandler _removeProductCommandHandler;
        private readonly GetProductUpdateByIDQueryHandler _getProductUpdateByIDQueryHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;

        public DefaultController(GetProductQueryHandler getProductQueryHandler, CreateProductCommandHandler createProductCommandHandler, GetProductsByIDQueryHandler getProductsByIDQueryHandler, RemoveProductCommandHandler removeProductCommandHandler, GetProductUpdateByIDQueryHandler getProductUpdateByIDQueryHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
            _getProductsByIDQueryHandler = getProductsByIDQueryHandler;
            _removeProductCommandHandler = removeProductCommandHandler;
            _getProductUpdateByIDQueryHandler = getProductUpdateByIDQueryHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult GetProduct(int id)
        {
            var values = _getProductsByIDQueryHandler.Handle(new GetProductByIDQuery(id));
            return View(values);
        }
        public IActionResult DeleteProduct(int id)
        {
            _removeProductCommandHandler.Handle(new RemoveProductCommand(id));  
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = _getProductUpdateByIDQueryHandler.Handle(new GetProductUpdateByIDQuery(id));

            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
            _updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
