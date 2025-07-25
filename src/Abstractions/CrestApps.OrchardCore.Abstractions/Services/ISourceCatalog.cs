namespace CrestApps.OrchardCore.Services;

public interface ISourceCatalog<T> : ICatalog<T>
    where T : ISourceAwareModel
{
    /// <summary>
    /// Asynchronously retrieves all entries associated with the specified source.
    /// </summary>
    /// <param name="source">The source of the entries. Must not be <c>null</c> or empty.</param>
    /// <returns>
    /// A <see cref="ValueTask{IEnumerable{T}}"/> representing the asynchronous operation.
    /// The result is a collection of entries associated with the given source.
    /// </returns>
    ValueTask<IEnumerable<T>> GetAsync(string source);
}
