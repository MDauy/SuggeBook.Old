using SuggeBook.Domain.Exceptions;
using ValueOf;

namespace SuggeBook.Domain.ValueObjects
{
    public class Category : ValueOf<string, Category>
    {
        private const string Thriller = "Thriller";

        private readonly List<string> _allowedCategories = new()
            {
            Thriller
            };

        protected override void Validate()
        {
            if (!_allowedCategories.Contains(Value))
            {
                throw new ValidationException<Category>();
            }
        }
    }
}
