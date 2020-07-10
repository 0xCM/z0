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
    using static z;

    partial struct LiteralFields
    {
        [Op]
        public static FieldRef[] stringrefs(params Type[] types)
        {
            var dst = list<FieldRef>();
            var src = span(types);
            for(var i=0u; i<types.Length; i++)
            {
                var type = skip(src,i);
                var fields = span(stringlits(type));                
                var count = fields.Length;
                
                var @base = address(type);
                var offset = MemoryAddress.Empty;                
                
                for(var j=0u; j<count; j++)
                {
                    var field = skip(fields, j);
                    var segment = from(@base, offset, field);
                    if(segment.IsNonEmpty)
                    {                        
                        append(dst, segment);                        
                        offset += segment.DataSize;
                    }

                }
            }
            return array(dst);
        }
    }
}