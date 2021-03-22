﻿using System;
using System.Collections.Generic;

namespace MycoKeyMaker.Library.Database
{
    public interface ILiteratureTable : ITable<DBObject.Literature>
    {
        IEnumerable<DBObject.Literature> GetEnumeratorForKey(Int64 key_id);
        void DeleteByKey(Int64 key_id);
    }
}