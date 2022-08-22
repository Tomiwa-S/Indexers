using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new() { Id = 0, name = "Harry Potter" };
            Item item2 = new() { name = "Trevor", Id = 1 };
            ItemIndexer indexer = new();
            indexer[0] = item;
            indexer[1] = item2;
            ItemIndexer indexer2 = new();
            indexer2["Berry"] = new Item() { Id = 3, name = "Berry" };
            Console.WriteLine(indexer[0].Id + " " + indexer[1].name);
            Console.WriteLine(indexer[1].Id + " " + indexer[1].name);
            Console.WriteLine(indexer[7].Id+" "+ indexer[7].name);
            Console.WriteLine("indexer[\"Berry\"]: "+ indexer2["Berry"].Id +"---"+ indexer2["Berry"].name);
            Console.WriteLine(indexer2["Jammie"].Id +"---" + indexer2["Jammie"].name);
        }
    }
}
