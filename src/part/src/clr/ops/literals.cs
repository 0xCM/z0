//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    partial struct ClrPrimitives
    {
        [Op, Closures(Closure)]
        public static LiteralIndex<T> literals<T>()
            where T : unmanaged
        {
            var fields = typeof(T).Fields().Literals();
            var count = (uint)fields.Length;
            var nameBuffer = sys.alloc<string>(count);
            var valueBuffer = sys.alloc<T>(count);
            ref var names = ref first(span(nameBuffer));
            ref var values = ref first(span(valueBuffer));
            var src = span(fields);
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(src,i);
                seek(names,i) = field.Name;
                seek(values, i) = (T)field.GetRawConstantValue();
            }
            return new LiteralIndex<T>(fields, nameBuffer, valueBuffer);
        }
    }
}