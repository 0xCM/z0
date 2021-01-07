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

    partial struct MemRefs
    {
        [Op]
        public unsafe static FieldRef field(MemoryAddress @base, MemoryAddress offset, FieldInfo src)
        {
            var data = sys.constant(src);
            var type = src.FieldType;
            var datatype = ClrPrimitives.kind(type);
            if(data is string s)
            {
                var content = span(s);
                var size = s.Length*2;
                var seg = segment(pvoid(first(content)), size);
                return new FieldRef(src, seg);
            }
            else if(type.IsEnum)
            {
                var nk = type.GetEnumUnderlyingType().NumericKind();
                var size = nk.Width()/8;
                var seg = segment(@base + offset, size);
                return new FieldRef(src, seg);
            }
            else if(type.IsPrimalNumeric())
            {
                var nk = type.NumericKind();
                var size = nk.Width()/8;
                var seg = segment(@base + offset, size);
                return new FieldRef(src, seg);
            }
            else if(type.IsChar())
                return new FieldRef(src, segment(@base + offset, 2));
            else if(type.IsDecimal())
                return new FieldRef(src, segment(@base + offset, 16));
            return FieldRef.Empty;
        }
    }
}