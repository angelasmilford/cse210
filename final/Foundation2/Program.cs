using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address[] addresses =  new Address[2];
        Customer[] customers =  new Customer[2];
        List<Product>[] productsLists = new List<Product>[2];
        Order[] orders = new Order[2];

        //ORDER 1 (USA)
        addresses[0] = new Address("PO Box 6306", "Apia", "AS", "USA");
        customers[0] =  new Customer("Angela Milford",addresses[0]);
        productsLists[0] = new List<Product>();
        productsLists[0].Add(new Product(" ","P0123",26.07f,4));
        productsLists[0].Add(new Product("PS4 Controller","P001",33.08f,1));
        orders[0] = new Order(customers[0],productsLists[0]);

        //ORDER 2 (NOT USA)
        addresses[1] = new Address("Pitonuu", "Apia", "Satupaitea", "Samoa");
        customers[1] =  new Customer("Suria Koneferenisi",addresses[1]);
        productsLists[1] = new List<Product>();
        productsLists[1].Add(new Product("The Holy Bible", "P0124",30.00f,1));
        productsLists[1].Add(new Product("Reading Glasses","A012",25.00f,1));
        productsLists[1].Add(new Product("Matte Red Lipstick","A025",52.13f,6));
        orders[1] = new Order(customers[1],productsLists[1]);

        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine($"\n-----CUSTOMER {i+1} ORDER-----");
            Console.WriteLine($"PACKING LABEL:\n{orders[i].GetPackingLabel()}"); 
            Console.WriteLine($"SHIPPING LABEL\n{orders[i].GetShippingLabel()}");
            Console.WriteLine($"TOTAL COST: ${orders[i].GetTotalCost()}");
        }
    }
}