//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct As
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T cast<T>(object src)
            => (T)src;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void cast<T>(ReadOnlySpan<object> src, Span<T> dst)
        {
            for(var i=0u; i<src.Length; i++)
                seek(dst, i) = cast<T>(skip(src,i));            
        }

        [MethodImpl(Inline)]
        public static T[] cast<T>(object[] src)
        {
            var dst = sys.alloc<T>(src.Length);
            cast<T>(src,dst);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<byte> src)
            where T : struct
                => Cast<byte,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src)
            where T : struct
                => Cast<byte,T>(src);
    }
}