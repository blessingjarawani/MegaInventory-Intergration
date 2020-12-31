using System;
using System.Collections.Generic;
using System.Text;

namespace MegaInventory.BLL.Shared
{
    public class Dictionaries
    {
        public enum ApiAction
        {
            Insert = 1,
            Update = 2,
            InsertOrUpdateNonEmptyFields = 3,
            InsertOrUpdate = 4
        }
    }
}
