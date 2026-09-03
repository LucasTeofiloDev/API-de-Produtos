using ApiDeProdutos.Model;

namespace ApiDeProdutos.Services.Interfaces
{
    public interface IProductServices
    {

        public Product CadastrarProduto(Product product);
        public List<Product> BuscarTodos();
        public Product BuscarPorId(int id);
        public Product AtualizarProduto(Product product);
        public void ExcluirProduto(int id);


    }
}
