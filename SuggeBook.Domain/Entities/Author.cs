namespace SuggeBook.Domain.Entities
{
    public class Author: AggregateRoot
    {
        public string Name { get; init; }

        public Author(string name, Guid? id = null)
        {
            Name = name;
            Id = id ?? Guid.NewGuid();
        }
    }
}
