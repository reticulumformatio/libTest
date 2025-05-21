namespace libTest
{
    internal interface IBook
    {
        string Title { get; }
        string Author { get; }

        void Get();
        void Remove();
    }
}
