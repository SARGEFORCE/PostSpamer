using PostSpamer.library.EF;

namespace PostSpamer.library.Services.EF
{
    public class EFDataContextProvider
    {
        public string ConnectionString { get; set; } = "name=PostSpamerDB";
        public PostSpamerDB CreateContext() => new PostSpamerDB(ConnectionString);
    }
}
