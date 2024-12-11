namespace InventoryHub
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create repositories for Product and Customer
            var productRepo = new Repository<Product>();
            var customerRepo = new Repository<Customer>();

            // Add products and customers
            productRepo.Add(new Product(1, "Laptop", 1000));
            productRepo.Add(new DiscountedProduct(2, "Smartphone", 500, 10)); // LSP in action
            customerRepo.Add(new Customer(1, "John Doe", "john@example.com"));

            // Retrieve and display products and customers
            var product = productRepo.Get(1);
            var discountedProduct = productRepo.Get(2); // LSP in action, treated as Product
            var customer = customerRepo.Get(1);

            Console.WriteLine($"Product: {product.Name}, Discounted Product: {discountedProduct.Name}, Customer: {customer.Name}");
            Console.ReadKey();
        }
    }

}
