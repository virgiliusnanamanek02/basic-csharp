internal class Program
{
    static int addTwoNumbers(int a, int b)
    {
        return a + b;
    }
    private static void Main(string[] args)
    {
        Cart cart = new Cart();

        cart.AddItem(1);
        cart.AddItem(2);
        cart.AddItem(3);


        cart.DisplayCart();

        cart.RemoveItem(1);

        cart.DisplayCart();
    }
}
