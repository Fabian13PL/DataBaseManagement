using System.Collections.Generic;

namespace DataBaseManagement
{
    public class Row
    {
        public int Id { get; set; }
        public virtual ICollection<Cell> Cells { get; set; }
    }
}
