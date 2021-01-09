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
    using static memory;

    partial struct MemRefs
    {
        [MethodImpl(Inline), Op]
        public static MemoryAddress location(Vector128<ulong> src)
            => src.GetElement(0);

        [Op]
        public static FieldRef[] fields(params Type[] src)
        {
            var dst = root.list<FieldRef>();
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                var type = src[i];
                var fields = ClrLiterals.search(type);
                var @base = address(type);
                var offset = MemoryAddress.Empty;
                for(var j=0u; j<fields.Length; j++)
                {
                    var fi = fields[j];
                    var segment = field(@base, offset, fi);
                    if(segment.IsNonEmpty)
                    {
                        root.append(dst, segment);
                        offset += segment.DataSize;
                    }
                }
            }
            return dst.Array();
        }
    }
}