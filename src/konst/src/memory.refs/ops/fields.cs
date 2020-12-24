//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct MemRefs
    {
        [MethodImpl(Inline), Op]
        public static MemoryAddress location(Vector128<ulong> src)
            => vcell(src,0);

        [Op]
        public static FieldRef[] fields(params Type[] src)
        {
            var dst = list<FieldRef>();
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                var type = src[i];
                var fields = Literals.search(type);
                var @base = z.address(type);
                var offset = MemoryAddress.Empty;
                for(var j=0u; j<fields.Length; j++)
                {
                    var field = fields[j];
                    var segment = MemRefs.field(@base, offset, field);
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