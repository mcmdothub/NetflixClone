namespace DotnetFlix.Objects.General
{
    public class SearchContainerWithId<T> : SearchContainer<T>
    {
        public int Id { get; set; }
    }
}