namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();

        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category{CategoryId = 1, Name = "Telefon"});
            _categories.Add(new Category{CategoryId = 2, Name = "Bilgisayar"});

            _products.Add(new Product{ProductId = 1, Name = "İphone 11", Price = 25000, IsActive = true, Image = "11.jpg", CategoryId = 1});

             _products.Add(new Product{ProductId = 2, Name = "İphone 12 Pro Max", Price = 40000, IsActive = false, Image = "12 ProMax.jpg", CategoryId = 1});

             _products.Add(new Product{ProductId = 3, Name = "İphone 13 Pro Max", Price = 50000, IsActive = false, Image = "13 ProMax.jpg", CategoryId = 1});

             _products.Add(new Product{ProductId = 4, Name = "İphone 15", Price = 60000, IsActive = true, Image = "15.jpg", CategoryId = 1});

             _products.Add(new Product{ProductId = 5, Name = "Macbook Air", Price = 80000, IsActive = true, Image = "Air.jpg", CategoryId = 2});

             _products.Add(new Product{ProductId = 6, Name = "Macbook Pro", Price = 90000, IsActive = true, Image = "Pro.jpg", CategoryId = 2});
        }

        public static List<Product> Products
        {
            get{
                return _products;
            }
        }

        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }

        public static void EditProduct(Product updateProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updateProduct.ProductId);

            if(entity != null)
            {
                if(string.IsNullOrEmpty(updateProduct.Name))
                {
                    entity.Name = updateProduct.Name;
                }
                
                entity.Price = updateProduct.Price;
                entity.Image = updateProduct.Image;
                entity.CategoryId = updateProduct.CategoryId;
                entity.IsActive = updateProduct.IsActive;
            }
        }

         public static void EditIsActive(Product updateProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updateProduct.ProductId);

            if(entity != null)
            {
                if(string.IsNullOrEmpty(updateProduct.Name))
                {
                    entity.IsActive = updateProduct.IsActive;
                }
            }
        }

        public static void DeleteProduct(Product deletedproduct)
        {
             var entity = _products.FirstOrDefault(p => p.ProductId == deletedproduct.ProductId);

             if(entity != null)
             {
                _products.Remove(entity);
             }

        }

        public static List<Category> Categories
        {
            get{
                return _categories;
            }
        }
    }
}