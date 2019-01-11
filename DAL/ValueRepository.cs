namespace AspDotNetCoreDi.DAL
{
    public class ValueRepository : IValueRepository
    {
        public string[] Get()
        {
            return new[] { "A", "B" };
        }
    }
}