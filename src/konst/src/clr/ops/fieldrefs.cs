//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    partial struct Clr
    {
        [Op]
        public unsafe static FieldRef fieldref(MemoryAddress @base, MemoryAddress offset, FieldInfo src)
        {
            var data = sys.constant(src);
            var type = src.FieldType;
            var datatype = ClrPrimitives.kind(type);
            if(data is string s)
            {
                var content = span(s);
                var size = s.Length*2;
                var seg = memseg(pvoid(first(content)), size);
                return new FieldRef(src, seg);
            }
            else if(type.IsEnum)
            {
                var nk = type.GetEnumUnderlyingType().NumericKind();
                var size = nk.Width()/8;
                var seg = memseg(@base + offset, size);
                return new FieldRef(src, seg);
            }
            else if(type.IsPrimalNumeric())
            {
                var nk = type.NumericKind();
                var size = nk.Width()/8;
                var seg = memseg(@base + offset, size);
                return new FieldRef(src, seg);
            }
            else if(type.IsChar())
                return new FieldRef(src, memseg(@base + offset, 2));
            else if(type.IsDecimal())
                return new FieldRef(src, memseg(@base + offset, 16));
            return FieldRef.Empty;
        }

        [Op]
        public static FieldRef[] fieldrefs(params Type[] src)
        {
            var dst = root.list<FieldRef>();
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                var type = src[i];
                var fields = ClrLiterals.search(type);
                var @base = address(type);
                var offset = MemoryAddress.Zero;
                for(var j=0u; j<fields.Length; j++)
                {
                    var fi = fields[j];
                    var segment = fieldref(@base, offset, fi);
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