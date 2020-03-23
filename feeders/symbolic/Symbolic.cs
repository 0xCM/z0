//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Symbolic)]

namespace Z0.Parts
{
    public sealed class Symbolic : Part<Symbolic> {  }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    public static class Symbolic
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline)]
        internal static Span<T> ToSpan<T>(this ReadOnlySpan<T> src)
            => src.ToArray();

        [MethodImpl(Inline)]
        internal static Span<T> Reverse<T>(this ReadOnlySpan<T> src) 
        {       
            var dst = src.ToSpan();
            dst.Reverse();
            return dst;
        }

        [MethodImpl(Inline)]
        internal static ReadOnlySpan<T> ReadOnly<T>(this Span<T> src) 
            => src;            
    }
}