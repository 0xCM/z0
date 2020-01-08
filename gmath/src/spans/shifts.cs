//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class mathspan
    {
        [MethodImpl(Inline)]
        public static Span<T> sll<T>(ReadOnlySpan<T> src, byte shift, Span<T> dst)
            where T : unmanaged
        {            
            for(var i=0; i<src.Length; i++)
                dst[i] = gmath.sll(src[i], shift);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> srlv<T>(ReadOnlySpan<T> src, ReadOnlySpan<T> offsets, Span<T> dst)
            where T : unmanaged
        {
            var count = length(src,offsets);
            for(var i=0; i < count; i++)
                dst[i] = gmath.srl(src[i], convert<T,byte>(offsets[i]));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> sllv<T>(ReadOnlySpan<T> src, ReadOnlySpan<T> offsets, Span<T> dst)
            where T : unmanaged
        {
            var count = length(src,offsets);
            for(var i=0; i<count; i++)
                dst[i] = gmath.sll(src[i], convert<T,byte>(offsets[i]));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> srl<T>(ReadOnlySpan<T> src, byte shift, Span<T> dst)
            where T : unmanaged
        {            
            for(var i=0; i<src.Length; i++)
                dst[i] = gmath.srl(src[i], shift);
            return dst;
        }

    }
}