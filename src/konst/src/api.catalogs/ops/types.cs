//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct ApiQuery
    {
        public static KeyedValues<PartId,Type>[] types(ClrTypeKind kind, ApiParts src)
        {
            switch(kind)
            {
                case ClrTypeKind.Enum:
                    return enums(src);
                default:
                    return default;
            }


            static KeyedValues<PartId,Type>[] enums(ApiParts src)
            {
                var x = from part in  src.Storage
                        let enums = part.Owner.Enums()
                            orderby part.Id
                            select KeyedValues.@from(part.Id, enums);
                return x;
            }
        }
    }
}