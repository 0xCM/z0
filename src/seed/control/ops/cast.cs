//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;

    partial class Control
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T cast<T>(object src)
            => (T)src;

        [MethodImpl(Inline)]
        public static T[] cast<T>(object[] src)
        {
            var dst = Control.alloc<T>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst[i] = cast<T>(src[i]);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src)
            where T : struct
                => MemoryMarshal.Cast<byte,T>(src);

        [MethodImpl(Inline)]        
        public static ReadOnlySpan<T> cast<S,T>(ReadOnlySpan<S> src)                
            where S : struct
            where T : struct
                => MemoryMarshal.Cast<S,T>(src);

        [MethodImpl(Inline)]        
        public static Span<T> cast<S,T>(Span<S> src)                
            where S : struct
            where T : struct
                => MemoryMarshal.Cast<S,T>(src);
    }
}