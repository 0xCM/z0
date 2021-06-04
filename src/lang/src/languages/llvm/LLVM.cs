//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Llvm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;
    using static ValueTypes;

    [ApiHost]
    public readonly partial struct LLVM
    {
        [MethodImpl(Inline), Op]
        internal static StringAddress name(string src)
            => StringAddress.resource(src);

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
        public static ValueTypeInfo describe(v128i64 src)
            => describe<v128i64>(out var _);

        [MethodImpl(Inline), Op]
        public static ref v1i64 v1i64(Span<byte> src)
            => ref first<v1i64>(src);

        [MethodImpl(Inline), Op]
        public static ref v2i64 v2i64(Span<byte> src)
            => ref first<v2i64>(src);

        [MethodImpl(Inline), Op]
        public static ref v4i64 v4i64(Span<byte> src)
            => ref first<v4i64>(src);

        [MethodImpl(Inline), Op]
        public static ref v8i64 v8i64(Span<byte> src)
            => ref first<v8i64>(src);

        [MethodImpl(Inline), Op]
        public static ref v16i64 v16i64(Span<byte> src)
            => ref first<v16i64>(src);

        [MethodImpl(Inline), Op]
        public static ref v32i64 v32i64(Span<byte> src)
            => ref first<v32i64>(src);

        [MethodImpl(Inline), Op]
        public static ref v64i64 v64i64(Span<byte> src)
            => ref first<v64i64>(src);

        [MethodImpl(Inline), Op]
        public static ref v128i64 v128i64(Span<byte> src)
            => ref first<v128i64>(src);

        [MethodImpl(Inline), Op]
        public static ref v256i64 v256i64(Span<byte> src)
            => ref first<v256i64>(src);
    }

}