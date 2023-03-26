using System;

namespace DataBaseManagement
{
    public class Cell
    {
        public int Id { get; set; }
        public virtual Column Column { get; set; }
        public string Value { get; set; }
    }
}
