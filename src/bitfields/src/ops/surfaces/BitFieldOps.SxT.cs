//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static Memories;
    
    public readonly struct BitFieldOps<S,T> : IBitFieldOps<S,T>
        where S : IScalarField<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public T Extract(in FieldSegment segment, in S src)
            => gbits.slice(src.Scalar, segment.StartPos, segment.Width);

        [MethodImpl(Inline)]
        public T Extract(in FieldSegment segment, in S src, bool offset)            
            => offset ? gmath.sll(Extract(segment, src), segment.StartPos)  : Extract(segment,src);

        [MethodImpl(Inline)]
        public void Deposit(in BitFieldSpec spec, in S src, Span<T> dst)
        {
            for(var i=0; i<spec.FieldCount; i++)
                seek(dst,i) = Extract(skip(spec.Segments,i), src);
        }

        [MethodImpl(Inline)]
        public ref T Deposit(in FieldSegment segment, in S src, ref T dst)
            => ref gbits.copy(src.Scalar, segment.StartPos, segment.Width, ref dst);

        [MethodImpl(Inline)]
        public ref S Deposit(in FieldSegment segment, in S src, ref S dst)
        {
            var dstData = dst.Scalar;
            dst.Update(gbits.copy(src.Scalar, segment.StartPos, segment.Width, ref dstData));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public ref T Deposit(in BitFieldSpec spec, ReadOnlySpan<T> src, ref T data)
        {
            for(var i=0; i<spec.FieldCount; i++)
            {
                ref readonly var segment = ref skip(spec.Segments,i);
                gbits.copy(skip(src,i), segment.StartPos, segment.Width, ref data);
            }
            return ref data;
        }
    }    
}