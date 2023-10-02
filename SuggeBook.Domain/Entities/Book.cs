using SuggeBook.Domain.ValueObjects;

namespace SuggeBook.Domain.Entities
{
    public class Book: AggregateRoot
    {
        public string Title { get; init; }
        public IEnumerable<Guid> Authors { get; init; }
        public Guid? SagaId { get; init; }
        public IEnumerable<Category> Categories { get; init; }

        public Book(string title, IEnumerable<Guid> athorsIds,
            Guid? id = null,
            IEnumerable<Category>? categories = null,
            Guid? sagaID = null)
        {
            Title = title;
            Authors = athorsIds;
            Id = id ?? Guid.NewGuid();
            SagaId = sagaID;
            Categories = categories ?? Enumerable.Empty<Category>();
        }

    }
}
