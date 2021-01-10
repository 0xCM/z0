//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    partial struct ApiQuery
    {
        // [Op]
        // public static KeyedValues<PartId,Type>[] enums(ISystemApiCatalog src)
        // {
        //     var x = from part in src.Parts
        //             let enums = part.Owner.Enums()
        //             orderby part.Id
        //             select Lookups.keyed(part.Id, enums);
        //     return x;
        // }

        // [Op]
        // public static KeyedValues<PartId,Type>[] enums(ISystemApiCatalog src, PartId[] parts)
        // {
        //     var selection = src.Parts.Where(p => parts.Contains(p.Id));
        //     var x = from part in  selection
        //             let enums = part.Owner.Enums()
        //             orderby part.Id
        //             select Lookups.keyed(part.Id, enums);
        //     return x;
        // }
    }
}