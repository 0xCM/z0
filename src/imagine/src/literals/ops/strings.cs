//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static core;

    partial struct LiteralFields
    {
        [Op]
        public static string[] strings(Type src)
        {
            var fields = stringlits(src);
            var @base = address(src);
            var count = fields.Length;
            var offset = MemoryAddress.Empty;  
            var buffer = sys.alloc<string>(count);  
            var dst = span(buffer);

            for(var j=0u; j<count; j++)
            {
                ref readonly var field = ref fields[j];
                var content = @string(field) ?? EmptyString;
                seek(dst,j) = content;
                if(!text.empty(content))
                    offset += from(@base, offset, field).DataSize;
            }
            return buffer;
        }
    }
}