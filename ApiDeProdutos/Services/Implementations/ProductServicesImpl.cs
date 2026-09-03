using ApiDeProdutos.Model;
using ApiDeProdutos.Services.Interfaces;
using ApiDeProdutos.Model.Context;

namespace ApiDeProdutos.Services.Implementations
{
    public class ProductServicesImpl : IProductServices
    {

        private MSSQLContext _context;

        public ProductServicesImpl(MSSQLContext context)
        {
            _context = context;
        }

        public Product CadastrarProduto(Product product)
        {
             _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public List<Product> BuscarTodos()
        {
            return _context.Products.ToList();
        }

        public Product BuscarPorId(int id)
        {
            return _context.Products.Find(id);
            
        }

        public Product AtualizarProduto(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return product;
        }

        public void ExcluirProduto(int id)
        {
           var excluirProduto =  _context.Products.Find(id);
            if (excluirProduto == null) throw new Exception("Não existe esse produto");
           
            _context.Products.Remove(excluirProduto);
            _context.SaveChanges();
        }
    }
}
