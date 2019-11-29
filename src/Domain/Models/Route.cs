using System;

namespace Models
{
    public class Route
    {
        public Route(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }


    }
}
