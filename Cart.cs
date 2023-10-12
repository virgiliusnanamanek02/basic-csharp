public class Cart
{
    private List<int> data = new List<int>();

    public List<int> AddItem(int value)
    {
        data.Add(value);
        return data;
    }

    public bool RemoveItem(int index)
    {
        if (index >= 0 && index < data.Count)
        {
            data.RemoveAt(index);
            return true; // Item dihapus
        }
        else
        {
            return false; // Indeks tidak valid
        }
    }

    public int Size()
    {
        return this.data.Count;
    }

    public void DisplayCart()
    {
        for (int i = 0; i < this.data.Count; i++)
        {
            Console.WriteLine(this.data[i]);
        }
    }
}

