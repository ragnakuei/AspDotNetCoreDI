using AspDotNetCoreDi.DAL;

namespace AspDotNetCoreDi.BL
{
    public class ValueService : IValueService
    {
        private readonly IValueRepository _repository;

        public ValueService(IValueRepository repository)
        {
            _repository = repository;
        }

        public string[] Get()
        {
            var result = _repository.Get();
            return result;
        }
    }
}