//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    partial struct Refs
    {
        [Op]
        public static FieldRef[] fields(params Type[] src)
        {
            var dst = list<FieldRef>();
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                var type = src[i];
                var fields = Literals.search(type);
                var @base = address(type);
                var offset = MemoryAddress.Empty;
                for(var j=0u; j<fields.Length; j++)
                {
                    var field = fields[j];
                    var segment = Refs.field(@base, offset, field);
                    if(segment.IsNonEmpty)
                    {
                        z.append(dst,segment);
                        offset += segment.DataSize;
                    }
                }
            }
            return dst.Array();
        }
    }
}