using HashTableCollisionChaining;

HashTable<int, string> hashTable = new HashTable<int, string>(5);

hashTable.Insert(1, "One");
hashTable.Insert(6, "Six"); 
hashTable.Insert(11, "Eleven");

hashTable.Display();