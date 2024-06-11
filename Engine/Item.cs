﻿namespace Engine
{
    public class Item
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string NamePlural { get; set; }

        public Item(int iD, string name, string namePlural)
        {
            ID = iD;
            Name = name;
            NamePlural = namePlural;
        }
    }
}
