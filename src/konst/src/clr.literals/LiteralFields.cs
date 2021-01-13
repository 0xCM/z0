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
    using static z;

    using api = ClrLiterals;

    [ApiHost(ApiNames.LiteralFields, true)]
    public readonly struct LiteralFields
    {
        [MethodImpl(Inline), Op]
        public static string @string(FieldInfo f)
            => sys.constant<string>(f);

        [MethodImpl(Inline), Op]
        public static FieldInfo[] fields(Type src)
            => src.LiteralFields();

        [MethodImpl(Inline), Op]
        public static FieldInfo[] strings(Type src)
        {
            var fields = src.DeclaredFields();
            return api.search(src).Where(f => f.IsStringLiteral());
        }

        [Op]
        public static void strings(Type host, FieldInfo[] src, Span<string> dst)
        {
            var @base = address(host);
            var count = src.Length;
            var offset = MemoryAddress.Empty;

            for(var j=0u; j<count; j++)
            {
                ref readonly var f = ref src[j];
                var content = @string(f) ?? EmptyString;
                seek(dst,j) = content;
                if(!text.blank(content))
                    offset += Clr.fieldref(@base, offset, f).DataSize;
            }
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static LiteralFieldValues<F> values<F>()
            where F : unmanaged
        {
            var specs = typeof(F).LiteralFields();
            var values = specs.Map(f => (F)f.GetRawConstantValue());
            return new LiteralFieldValues<F>(specs, values);
        }

        /// <summary>
        /// Collects unmanaged fields defined by a type
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Paired<FieldInfo,T>[] values<T>(Type src)
            where T : unmanaged
                => api.search<T>(src).Select(f => paired(f, sys.constant<T>(f)));


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public Paired<FieldInfo,T>[] values<T>(Type[] types)
            where T : unmanaged
        {
            var literals = list<Paired<FieldInfo,T>>();
            for(var i=0u; i<types.Length; i++)
            {
                var values = values<T>(types[i]).ToSpan();
                for(var j=0u; j<values.Length; j++)
                    literals.Add(skip(values,j));
            }
            return sys.array(literals);
        }

        public readonly FieldInfo[] Data;

        [MethodImpl(Inline)]
        public static implicit operator LiteralFields(FieldInfo[] src)
            => new LiteralFields(src);

        [MethodImpl(Inline)]
        public LiteralFields(FieldInfo[] src)
            => Data = src;

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ReadOnlySpan<FieldInfo> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<FieldInfo> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref FieldInfo this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}