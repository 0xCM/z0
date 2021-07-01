//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    partial struct Clr
    {
        [Op, Closures(Closure)]
        public static LiteralFields literals(Type type)
        {
            var fields = type.Fields().Literals();
            var count = (uint)fields.Length;
            var nameBuffer = alloc<string>(count);
            var valueBuffer = alloc<object>(count);
            ref var names = ref first(span(nameBuffer));
            ref var values = ref first(span(valueBuffer));
            var src = span(fields);
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(src,i);
                seek(names,i) = field.Name;
                seek(values, i) = field.GetRawConstantValue();
            }
            return new LiteralFields(fields, nameBuffer, valueBuffer);
        }

        [Op]
        public static Index<NumericLiteral> literals(Type src, Base2 b)
        {
            var fields = span(src.LiteralFields());
            var dst = list<NumericLiteral>();
            for(var i=0u; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var tc = Type.GetTypeCode(field.FieldType);
                var vRaw = field.GetRawConstantValue();
                dst.Add(NumericLiterals.literal(field.Name, vRaw, BitRender.format(vRaw, tc), b));
            }
            return dst.ToArray();
        }
    }
}