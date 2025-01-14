﻿using System;
using System.Collections.Generic;

namespace MycoKeys.Library.Database
{
    public interface ISpeciesAttributeSizeTable : ITable<DBObject.SpeciesAttributeSize>
    {
        IEnumerable<DBObject.SpeciesAttributeSize> GetEnumeratorForKey(Int64 key_id);
        IEnumerable<DBObject.SpeciesAttributeSize> GetEnumeratorForSpecies(Int64 species_id);
        void DeleteByKey(Int64 key_id);
        void DeleteBySpecies(Int64 species_id);
    }
}
