//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct LiteralFields
    {
        [Op]
        public static FieldRef[] refs(params Type[] src)
        {
            var dst = list<FieldRef>();
            var input = span(src);
            var count = input.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var type = ref skip(input,i);
                var fields = span(search(type));
                var @base = address(type);
                var offset = MemoryAddress.Empty;
                for(var j=0u; j<fields.Length; j++)
                {
                    ref readonly var field = ref skip(fields,j);
                    var segment = from(@base, offset, field);
                    if(segment.IsNonEmpty)
                    {
                        z.append(dst,segment);
                        offset += segment.DataSize;
                    }
                }
            }
            return array(dst);
        }
    }
}