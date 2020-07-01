//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.InteropServices.MemoryMarshal;
    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial struct As
    {
        [MethodImpl(Inline)]
        public static ref T cast<S,T>(in S src)
            => ref As<S,T>(ref edit(src));

        [MethodImpl(Inline)]        
        public static ReadOnlySpan<T> cast<S,T>(ReadOnlySpan<S> src)                
            where S : struct
            where T : struct
                => Cast<S,T>(src);

        [MethodImpl(Inline)]        
        public static Span<T> cast<S,T>(Span<S> src)                
            where S : struct
            where T : struct
                => Cast<S,T>(src); 

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cast<S,T>(ReadOnlySpan<S> src, out ReadOnlySpan<S> rem)
            where T : struct
            where S : struct
        {    
            var z = size<T>();
            var n = (uint)src.Length;
            var q = n/z;            
            var r = n%z;
            var dst = cast<S,T>(slice(src, 0, q));            
            rem = r != 0 ? slice(src,q) : EmptySpan<S>();
            return dst;
        }            

        [MethodImpl(Inline)]
        public static Span<T> cast<S,T>(Span<S> src, out Span<S> rem)
            where T : struct
            where S : struct
        {    
            var z = size<T>();
            var n = (uint)src.Length;
            var q = n/z;            
            var r = n%z;
            var dst = cast<S,T>(slice(src,0, q));            
            rem = r != 0 ? slice(src,q) : EmptySpan<S>();
            return dst;
        }            
    }
}