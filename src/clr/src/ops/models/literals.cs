//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using R = System.Reflection;

    using static Root;
    using static core;

    partial struct ClrModels
    {
        public static ClrFieldValues<T> literals<T>(Type src)
        {
            var fields = src.LiteralFields(typeof(T));
            var count = fields.Length;
            if(count == 0)
                return ClrFieldValues<T>.Empty;
            var buffer = alloc<ClrFieldValue<T>>(count);
            literals<T>(fields, buffer);
            return buffer;
        }

        [Op, Closures(Closure)]
        public static void literals<T>(ReadOnlySpan<FieldInfo> fields, Span<ClrFieldValue<T>> dst)
        {
            var count = fields.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var value = @as<object,T>(field.GetRawConstantValue());
                seek(dst,i) = new ClrFieldValue<T>(field, value);
            }
        }

        [Op]
        public static Span<ClrFieldAdapter> literals(ReadOnlySpan<ClrFieldAdapter> src, Span<ClrFieldAdapter> dst)
        {
            var k = 0u;
            var count = src.Length;
            for(var i=0u; i<count; i++)
                if(skip(src,i).IsLiteral)
                    seek(dst, k++) = skip(src,i);
            return slice(dst,k);
        }

        [Op]
        public static Span<ClrFieldAdapter> literals(Type src, Span<ClrFieldAdapter> dst)
            => literals(fields(src), dst);
    }
}