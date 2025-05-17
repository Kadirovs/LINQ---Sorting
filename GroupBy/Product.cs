public class Product
{
    public string Category { get; set; }
    public int Price { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is not Product other) return false;
        return Category == other.Category;
    }

    public override int GetHashCode()
    {
        return Category?.GetHashCode() ?? 0;
    }
}