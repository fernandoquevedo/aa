using System;
using Raven.Client.Documents;

namespace irad
{
    public class DocumentStoreHolder
    {
        private static Lazy<IDocumentStore> _store = new Lazy<IDocumentStore>(CreateStore);

        public static IDocumentStore Store => _store.Value;

        private static IDocumentStore CreateStore()
        {
            var store = new DocumentStore()
            {
                Urls = new[] {"http://localhost:8080"},
                Database = "radio"
            }.Initialize();

            return store;
        }
    }
}