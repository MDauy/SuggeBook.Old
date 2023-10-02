namespace SuggeBook.Domain.Entities
{
    public class Saga: AggregateRoot
    {
        public string Title { get; init; }

        public Saga(string title, Guid? id = null)
        {
            Title = title;
            Id = id ?? Guid.NewGuid();
        }
    }
}
