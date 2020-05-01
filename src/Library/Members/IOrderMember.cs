namespace Order
{
    public interface IOrderMember
    {
        string Name { get; set; }
        void Greet();
    }
}