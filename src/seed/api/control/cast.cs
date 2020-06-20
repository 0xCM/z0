//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        [MethodImpl(Inline)]
        public static T cast<T>(object src)
            => (T)src;

        [MethodImpl(Inline)]
        public static ref T cast<S,T>(in S src)
            => ref Imagine.cast<S,T>(src);
            
        [MethodImpl(Inline)]
        public static T[] cast<T>(object[] src)
        {
            var dst = Root.alloc<T>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst[i] = cast<T>(src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> cast<T>(Span<byte> src)
            where T : struct
                => Imagine.cast<T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src)
            where T : struct
                => Imagine.cast<T>(src);

        [MethodImpl(Inline)]        
        public static ReadOnlySpan<T> cast<S,T>(ReadOnlySpan<S> src)                
            where S : struct
            where T : struct
                => Imagine.cast<S,T>(src);

        [MethodImpl(Inline)]        
        public static Span<T> cast<S,T>(Span<S> src)                
            where S : struct
            where T : struct
                => Imagine.cast<S,T>(src);
    }
}