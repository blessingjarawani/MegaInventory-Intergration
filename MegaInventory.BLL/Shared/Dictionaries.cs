using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Shared
{
    public static class Dictionaries
    {
        public enum Operation
        {
            Insert = 1,
            Update = 2,
            InsertOrUpdateNonEmptyFields = 3,
            InsertOrUpdate = 4
        }
    }
}
