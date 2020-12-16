//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static memory;

    partial struct ClrQuery
    {
        [Op, Closures(Closure)]
        public static LiteralIndex<T> literalIndex<T>()
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
            return new LiteralIndex<T>(fields,nameBuffer,valueBuffer);
        }

        [Op]
        public static Span<FieldInfo> literals(in IndexedSeq<FieldInfo> src, Span<FieldInfo> dst)
        {
            var k = 0u;
            var view = src.Terms;
            var count = view.Length;
            for(var i=0u; i<count; i++)
                if(skip(view,i).IsLiteral)
                    seek(dst, k++) = skip(view,i);
            return slice(dst,k);
        }

        [Op]
        public static Span<FieldInfo> literals(Type src, Span<FieldInfo> dst)
            => literals(fields(src), dst);

        /// <summary>
        /// Collects the <typeparamref name='T'/> literals defined by a source <see cref='Type'/>
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="T">The primitive literal type</typeparam>
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
    }
}