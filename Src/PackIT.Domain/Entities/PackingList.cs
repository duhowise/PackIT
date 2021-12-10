namespace PackIT.Domain
{
    public class PackingList
    {
        public Guid Id { get; private set; }
        public string Name { get;private set; }
        public string Localisation { get;private set; }
    }
}