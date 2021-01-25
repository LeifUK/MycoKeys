﻿using System;
using PetaPoco.NetCore;

namespace MycoKeys.Library.DBObject
{
    [TableName(Database.TableNames.Attribute)]
    public class Attribute : IObject
    {
        public Int64 id { get; set; }
        public Int64 key_id { get; set; }
        public string description { get; set; }
    }
}
