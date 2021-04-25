//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    partial struct Clr
    {
        [Op, Closures(Closure)]
        public static LiteralFields literals(Type type)
        {
            var fields = type.Fields().Literals();
            var count = (uint)fields.Length;
            var nameBuffer = sys.alloc<string>(count);
            var valueBuffer = sys.alloc<object>(count);
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
    }
}