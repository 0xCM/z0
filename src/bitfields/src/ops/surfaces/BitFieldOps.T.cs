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

    public readonly struct BitFieldOps<T> : IBitFieldOps<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public T Extract(in FieldSegment seg, T src)
            => gbits.slice(src, seg.StartPos, seg.Width);

        [MethodImpl(Inline)]
        public ref T Deposit(in FieldSegment seg, in T src, ref T dst)
            => ref gbits.bitcopy(src, seg.StartPos, seg.Width, ref dst);

        [MethodImpl(Inline)]
        public T Extract(in FieldSegment seg, T src, bool offset)
            => offset ? gmath.sll(Extract(seg, src), seg.StartPos) : Extract(seg,src);

        [MethodImpl(Inline)]
        public void Deposit(in BitFieldSpec spec, T src, Span<T> dst)
        {
            for(var i=0; i<spec.FieldCount; i++)
                seek(dst,i) = Extract(skip(spec.Segments,i), src);
        }

        [MethodImpl(Inline)]
        public void Deposit<E,W>(in BitFieldSpec<E,W> spec, T src, Span<T> dst)
            where E : unmanaged, Enum
            where W : unmanaged, Enum
        {
            for(var i=0; i<spec.Segments.Length; i++)
                seek(dst,i) = Extract(skip(spec.Segments,i), src);
        }

        [MethodImpl(Inline)]
        public ref T Deposit(in BitFieldSpec spec, ReadOnlySpan<T> src, ref T dst)
        {
            for(var i=0; i<spec.FieldCount; i++)
                Deposit(skip(spec.Segments,i), skip(src,i),ref dst);                
            return ref dst;
        }
    }
}