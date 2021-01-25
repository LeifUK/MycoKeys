﻿using System;
using System.Collections.Generic;

namespace MycoKeys.Library.Database
{
    public interface IAttributeTable : ITable<DBObject.Attribute>
    {
        IEnumerable<DBObject.Attribute> GetEnumeratorForKey(Int64 key_id);
    }
}
