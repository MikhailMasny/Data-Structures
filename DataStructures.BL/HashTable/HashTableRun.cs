using System;
using System.Collections;

namespace DataStructures.BL.HashTable
{
    /// <summary>
    /// Класс с вариантами HashTable.
    /// </summary>
    public class HashTableRun
    {
        Random rnd = new Random();

        /// <summary>
        /// Демонстрация работы базового HashTable.
        /// </summary>
        public void BasicHashTable()
        {
            Hashtable ht = new Hashtable();
            

            Console.WriteLine($"BasicHashTable - count: {ht.Count}");

            ht.Add(Guid.NewGuid().ToString(), rnd.Next(0,100));
            ht.Add(Guid.NewGuid().ToString(), rnd.Next(0, 100));
            ht.Add(Guid.NewGuid().ToString(), rnd.Next(0, 100));

            Console.WriteLine($"BasicHashTable - count: {ht.Count}");

            ICollection keys = ht.Keys;

            foreach (string s in keys)
            {
                Console.WriteLine($"BasicHashTable - Key: {s}, Value: {ht[s]}");
            }
        }

        /// <summary>
        /// Демонстрация работы "плохой" HashTable.
        /// </summary>
        public void BadHashTable()
        {
            var badHashTable = new BadHashTable<int>(10);

            badHashTable.Add(1);
            badHashTable.Add(2);
            badHashTable.Add(3);
            badHashTable.Add(4);

            Console.WriteLine($"BadHashTable - search 3 in ht, result: {badHashTable.Search(3)}");
            Console.WriteLine($"BadHashTable - search 11 in ht, result: {badHashTable.Search(11)}");
        }

        /// <summary>
        /// Демонстрация работы реализованной HashTable.
        /// </summary>
        public void ReleaseHashTabel()
        {
            var hashTable = new HashTable<int, string>(10);

            hashTable.Add(1, "One");
            hashTable.Add(2, "Two");
            hashTable.Add(5, "Five");
            hashTable.Add(9, "Nine");

            Console.WriteLine($"ReleaseHashTable - search 7, (Seven) in ht, result: {hashTable.Search(7, "Seven")}");
            Console.WriteLine($"ReleaseHashTable - search 5, (Five) in ht, result: {hashTable.Search(5, "Five")}");
        }

        /// <summary>
        /// Демонстрация работы "супер" HashTable.
        /// </summary>
        public void SuperHashTable()
        {
            var superHashTable = new SuperHashTable<HelpHashTable>(10);

            var hhtOne = new HelpHashTable() { FieldOne = Guid.NewGuid().ToString(), FieldTwo = rnd.Next(0, 100) };

            superHashTable.Add(new HelpHashTable() { FieldOne = Guid.NewGuid().ToString(), FieldTwo = rnd.Next(0, 100) });
            superHashTable.Add(new HelpHashTable() { FieldOne = Guid.NewGuid().ToString(), FieldTwo = rnd.Next(0, 100) });
            superHashTable.Add(new HelpHashTable() { FieldOne = Guid.NewGuid().ToString(), FieldTwo = rnd.Next(0, 100) });

            superHashTable.Add(hhtOne);

            Console.WriteLine($"SuperHashTable - search result: {superHashTable.Search(new HelpHashTable() { FieldOne = Guid.NewGuid().ToString(), FieldTwo = rnd.Next(0, 100) })}");
            Console.WriteLine($"SuperHashTable - search result: {superHashTable.Search(hhtOne)}");
        }
    }
}
