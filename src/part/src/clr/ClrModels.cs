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

    [ApiHost]
    public readonly struct ClrModels
    {
        const NumericKind Closure = UnsignedInts;

        const BindingFlags BF = ReflectionFlags.BF_All;

        [MethodImpl(Inline), Op]
        public static Index<Type> interfaces(Type src)
            => src.GetInterfaces();

        [MethodImpl(Inline), Op]
        public static ClrTypeLookup lookup(Type[] src)
            => new ClrTypeLookup(src);

        [MethodImpl(Inline), Op]
        public static ClrStructAdapter @struct(Type src)
            => new ClrStructAdapter(src);

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

        /// <summary>
        /// Returns a <see cref='ClrFieldAdapter'/> readonly span of the fields defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrFieldAdapter> fields(Type src)
            => adapt(src.GetFields(BF));

        /// <summary>
        /// Returns a <see cref='ClrFieldAdapter'/> readonly span of the fields defined by a parametrically-identified source type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [Op, Closures(Closure)]
        public static ReadOnlySpan<ClrFieldAdapter> fields<T>()
            => adapt(typeof(T).GetFields(BF));


        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrTypeAdapter> adapt(Type[] src)
            => adapt<Type,ClrTypeAdapter>(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrModuleAdapter> adapt(R.Module[] src)
            => adapt<Module,ClrModuleAdapter>(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrMethodAdapter> adapt(R.MethodInfo[] src)
            => adapt<MethodInfo,ClrMethodAdapter>(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrFieldAdapter> adapt(R.FieldInfo[] src)
            => adapt<FieldInfo,ClrFieldAdapter>(src);

        [MethodImpl(Inline), Op]
        internal static ReadOnlySpan<V> adapt<S,V>(S[] src)
            => recover<S,V>(@readonly(src));
    }
}