using System;
using System.Collections.Generic;

namespace DataStructures.BL.Map
{
    /// <summary>
    /// Класс с вариантами Map.
    /// </summary>
    public class MapRun
    {
        Random rnd = new Random();

        /// <summary>
        /// Демонстрация работы базового Dictionary.
        /// </summary>
        public void BasicDictionary()
        {
            var basicDict = new Dictionary<string, int>(5);

            Console.WriteLine($"BasicDictionary - count: {basicDict.Count}");
            var guid = Guid.NewGuid().ToString();

            basicDict.Add(Guid.NewGuid().ToString(), rnd.Next(0, 100));
            basicDict.Add(guid, rnd.Next(0, 100));
            basicDict.Add(Guid.NewGuid().ToString(), rnd.Next(0, 100));
            basicDict.Add(Guid.NewGuid().ToString(), rnd.Next(0, 100));
            basicDict.Add(Guid.NewGuid().ToString(), rnd.Next(0, 100));

            Console.WriteLine($"BasicDictionary - count: {basicDict.Count}");

            basicDict.Remove(guid);

            Console.WriteLine($"BasicDictionary - count after delete: {basicDict.Count}");

            foreach (var item in basicDict)
            {
                Console.WriteLine($"BasicDictionary - Key: {item.Key}, Value: {item.Value}");
            }
        }

        /// <summary>
        /// Демонстрация работы базового EasyMap.
        /// </summary>
        public void EasyMap()
        {
            var easyMap = new EasyMap<string, int>();

            Console.WriteLine($"EasyMap - count: {easyMap.Count}");
            var guid = Guid.NewGuid().ToString();

            easyMap.Add(new ItemMap<string, int>(Guid.NewGuid().ToString(), rnd.Next(0, 100)));
            easyMap.Add(new ItemMap<string, int>(Guid.NewGuid().ToString(), rnd.Next(0, 100)));
            easyMap.Add(new ItemMap<string, int>(guid, rnd.Next(0, 100)));
            easyMap.Add(new ItemMap<string, int>(Guid.NewGuid().ToString(), rnd.Next(0, 100)));
            easyMap.Add(new ItemMap<string, int>(Guid.NewGuid().ToString(), rnd.Next(0, 100)));

            Console.WriteLine($"EasyMap - count: {easyMap.Count}");

            easyMap.Remove(guid);

            Console.WriteLine($"BasicDictionary - count after delete: {easyMap.Count}");

            int i = 1;
            foreach (var item in easyMap)
            {
                Console.WriteLine($"EasyMap #{i} - Key: {item}");
                i++;
            }
        }

        /// <summary>
        /// Демонстрация работы базового Dictionary.
        /// </summary>
        public void ImplementedDictionary()
        {
            var dict = new ImplementedDictionary<int, string>();

            var rnd1 = rnd.Next(10, 20);
            var rnd2 = rnd.Next(40, 50);

            dict.Add(new ItemMap<int, string>(rnd.Next(0, 10), Guid.NewGuid().ToString()));
            dict.Add(new ItemMap<int, string>(rnd1, Guid.NewGuid().ToString()));
            dict.Add(new ItemMap<int, string>(rnd.Next(20, 30), Guid.NewGuid().ToString()));
            dict.Add(new ItemMap<int, string>(rnd2, Guid.NewGuid().ToString()));
            dict.Add(new ItemMap<int, string>(rnd.Next(50, 60), Guid.NewGuid().ToString()));

            dict.Remove(rnd1);
            dict.Remove(rnd2);

            int i = 1;
            foreach (var item in dict)
            {
                Console.WriteLine($"ImplementedDictionary #{i} - Key: {item}");
                i++;
            }
        }
    }
}
