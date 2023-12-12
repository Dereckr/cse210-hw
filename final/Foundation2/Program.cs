using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("soap","01",2.2,2);
        Product product2 = new Product("milk","04",1.25,2);
        Customer customer1= new Customer("Francisco");
        Address address1 = new Address("Street 3","Murillo", "La Paz","Bolivia");
        customer1._address=address1;

        Order order1 = new Order();
        order1._products.Add(product1);
        order1._products.Add(product2);
        order1._customer = customer1;
        order1.calculateTotal();
        order1.packingLabel();
        order1.GetShippingLabel();

        Product product1_2 = new Product("yenga","07",10.4,2);
        Product product2_2 = new Product("monopoly","08",20,1);
        Product product3_2 = new Product("uno","010",5,2);
        Customer customer2= new Customer("Erick");
        Address address2 = new Address("123 Main Street","Logan", "Utah","USA");
        customer2._address=address2;

        Order order2 = new Order();
        order2._products.Add(product1_2);
        order2._products.Add(product2_2);
        order2._products.Add(product3_2);
        order2._customer = customer2;
        order2.calculateTotal();
        order2.packingLabel();
        order2.GetShippingLabel();
        
    }
}