using System;
using System.Collections.Generic;
using System.Text;

namespace Les01
{
    public abstract class Item
    {
        public string Name { get; private set; }
    
        public Item(string name)
        {
            Name = name;
        }

        public abstract void Use();
    }
}
