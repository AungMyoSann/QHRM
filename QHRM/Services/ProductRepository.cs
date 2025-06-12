using QHRM.Models;
using Dapper;
namespace QHRM.Services
{
    public class ProductRepository: IProductRepository
    {
        private readonly DapperContext _context;

        public ProductRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var query = "SELECT * FROM Product";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<Product>(query);
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var query = "SELECT * FROM Product WHERE Id = @Id";
            using var connection = _context.CreateConnection();
            return await connection.QuerySingleOrDefaultAsync<Product>(query, new { Id = id });
        }

        public async Task AddAsync(Product product)
        {
            DateTime datetime = DateTime.Now;
            product.CreateDate = datetime;

            var query = "INSERT INTO Product (Id, Name,Description,Price,CreateDate) VALUES (@Id, @Name,@Description,@Price,@CreateDate)";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, product);
        }

        public async Task UpdateAsync(Product product)
        {
            var query = "UPDATE Product SET Name = @Name, Description = @Description,Price = @Price WHERE Id = @Id";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, product);
        }

        public async Task DeleteAsync(int id)
        {
            var query = "DELETE FROM Product WHERE Id = @Id";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new { Id = id });
        }
    }
}
