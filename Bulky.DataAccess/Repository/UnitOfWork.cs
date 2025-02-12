using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;

namespace BulkyBook.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public ICategoryRepository Category { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public IProductRepository Product { get; private set; }
        public IShoppingCartRepository ShoppingCart { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }
        public IOrderDetailRepository OrderDetail { get; private set; }
        public IOrderHeaderRepository OrderHeader { get; private set; }

        public UnitOfWork(ApplicationDbContext db,
                          ICategoryRepository categoryRepo,
                          ICompanyRepository companyRepo,
                          IProductRepository productRepo,
                          IShoppingCartRepository shoppingCartRepo,
                          IApplicationUserRepository applicationUserRepo,
                          IOrderDetailRepository orderDetailRepo,
                          IOrderHeaderRepository orderHeaderRepo)
        {
            _db = db;
            Category = categoryRepo;
            Company = companyRepo;
            Product = productRepo;
            ShoppingCart = shoppingCartRepo;
            ApplicationUser = applicationUserRepo;
            OrderDetail = orderDetailRepo;
            OrderHeader = orderHeaderRepo;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
