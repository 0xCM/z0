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

    partial struct MemRefs
    {
        [Op]
        public unsafe static FieldRef field(MemoryAddress @base, MemoryAddress offset, FieldInfo src)
        {
            var data = Literals.value(src);
            var type = src.FieldType;

            var datatype = ClrPrimitives.kind(type);
            if(data is string s)
            {
                var content = z.span(s);
                var size = s.Length*2;
                var segment = memref(pvoid(first(content)), size);
                return new FieldRef(src, segment);
            }
            else if(type.IsEnum)
            {
                var nk = type.GetEnumUnderlyingType().NumericKind();
                var size = nk.Width()/8;
                var segment = memref(@base + offset, size);
                return new FieldRef(src, segment);
            }
            else if(type.IsPrimalNumeric())
            {
                var nk = type.NumericKind();
                var size = nk.Width()/8;
                var segment = memref(@base + offset, size);
                return new FieldRef(src, segment);
            }
            else if(type.IsChar())
                return new FieldRef(src, memref(@base + offset, 2));
            else if(type.IsDecimal())
                return new FieldRef(src, memref(@base + offset, 16));
            return FieldRef.Empty;
        }
    }
}