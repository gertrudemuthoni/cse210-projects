using System;

class Program
{
    static void Main(string[] args)
    {
        //Instantiate a new address;
        Address address = new Address("123 Main St", "Springfield", "IL", "USA");
        //Instantiate a new customer;
        Customer customer = new Customer("John Doe", address);
        //Instantiate a new product;
        Product product = new Product("Laptop", "P123", 999.99f, 1);
        Product product2 = new Product("Mouse", "P124", 49.99f, 2);
        Product product3 = new Product("Keyboard", "P125", 79.99f, 1);

        List<Product> products = [];
        products.Add(product);
        products.Add(product2);
        products.Add(product3);

        //Instantiate a new order;
        Order order1 = new Order(customer, products);

        //Display the total price of the order
        float totalPrice = order1.GetTotalPrice();
        Console.WriteLine($"Total Price: ${totalPrice}");

        //Display the packing label
        string packingLabel = order1.GetPackingLabel();
        Console.WriteLine(packingLabel);

        //Display the shipping label
        string shippingLabel = order1.GetShippingLabel();
        Console.WriteLine(shippingLabel);

        //Display the shipping cost
        int shippingCost = order1.GetShippingCost();
        Console.WriteLine($"Shipping Cost: ${shippingCost}");
        Console.WriteLine("---------------------------------\n");

        //Instantiate a new address;
        Address address2 = new Address("123 Main St", "Nairobi", "NBO", "KENYA");

        //Instantiate a new customer;
        Customer customer2 = new Customer("Nancy Drew", address2);
        //Instantiate a new product;
        Product product4 = new Product("Curtains", "P123", 123.00f, 4);
        Product product5 = new Product("Desks", "P124", 98.99f, 6);
        Product product6 = new Product("Mirror", "P125", 39.89f, 2);

        List<Product> secondproducts = [];
        secondproducts.Add(product4);
        secondproducts.Add(product5);
        secondproducts.Add(product6);

        //Instantiate a new order;
        Order order2 = new Order(customer2, secondproducts);

        //Display the total price of the order
        float totalPrice2 = order2.GetTotalPrice();
        Console.WriteLine($"Total Price: ${totalPrice2}");

        //Display the packing label
        string packingLabel2 = order2.GetPackingLabel();
        Console.WriteLine(packingLabel2);

        //Display the shipping label
        string shippingLabel2 = order2.GetShippingLabel();
        Console.WriteLine(shippingLabel2);

        //Display the shipping cost
        int shippingCost2 = order2.GetShippingCost();
        Console.WriteLine($"Shipping Cost: ${shippingCost2}");

    }
}