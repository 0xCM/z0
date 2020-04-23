//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed; 

    using K = Kinds;

    partial class MSvcHosts
    {
        [Closures(Integers)]
        public readonly struct Srl<T> : IUnaryImm8Op<T>, ISpanShiftImm8<T>
            where T : unmanaged        
        {
            [MethodImpl(Inline)]
            public T Invoke(T a, byte offset) 
                => gmath.srl(a, offset);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, byte count, Span<T> dst)
                => gspan.srl(src,count,dst);
        }

        [Closures(Integers)]
        public readonly struct Srlv<T> : IVarSpanShift<T>
            where T : unmanaged        
        {
            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, ReadOnlySpan<byte> counts, Span<T> dst)
                => gspan.srlv(src,counts,dst);
        }
    }
}