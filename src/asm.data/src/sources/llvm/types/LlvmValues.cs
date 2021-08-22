//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static LlvmTypes;

    [ApiHost]
    public readonly partial struct LlvmValues
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static bits<N,T> bits<N,T>(N n, T value)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new bits<N,T>(value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bits<T> bits<T>(uint n, T value)
            where T : unmanaged
                => new bits<T>(n, value);

        [MethodImpl(Inline)]
        public static ref ValueTypeInfo describe<T>(out ValueTypeInfo dst)
            where T : unmanaged, IValueType<T>
        {
            var t = default(T);
            dst.Name = t.Name;
            dst.Width = t.Width;
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ValueTypeInfo v128i64(out ValueTypeInfo dst)
        {
            var src = default(v128i64);
            dst.Name = src.Name;
            dst.Width = width(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        internal static StringAddress name(string src)
            => StringAddress.resource(src);

        [MethodImpl(Inline)]
        internal static ushort width<T>(T src = default)
            where T : unmanaged
                => (ushort)core.width<T>();
    }
}