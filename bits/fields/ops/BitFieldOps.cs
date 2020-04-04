//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;    

    public static class BitFieldOps
    {
        public static BitFieldOps<T> Create<T>()
            where T : unmanaged
                => default(BitFieldOps<T>);

        public static BitFieldOps<S,T> Create<S,T>()
            where S : IScalarField<T>
            where T : unmanaged
                => default(BitFieldOps<S,T>);
    }
    
    public readonly struct BitFieldOps<T> : IBitFieldOps<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public T Read(in FieldSegment segment, T src)
            => gbits.bitslice(src, segment.StartPos, segment.Width);

        [MethodImpl(Inline)]
        public ref T Write(in FieldSegment segment, in T src, ref T dst)
            => ref gbits.bitcopy(src, segment.StartPos, segment.Width, ref dst);

        [MethodImpl(Inline)]
        public T Read(in FieldSegment segment, T src, bool offset)
            => offset ? gmath.sll(Read(segment, src), segment.StartPos) : Read(segment,src);

        [MethodImpl(Inline)]
        public void Read(in BitFieldSpec spec, T src, Span<T> dst)
        {
            for(var i=0; i<spec.FieldCount; i++)
                seek(dst,i) = Read(skip(spec.Segments,i), src);
        }

        [MethodImpl(Inline)]
        public void Read<E,W>(in BitFieldSpec<E,W> spec, T src, Span<T> dst)
            where E : unmanaged, Enum
            where W : unmanaged, Enum
        {
            for(var i=0; i<spec.Segments.Length; i++)
                seek(dst,i) = Read(skip(spec.Segments,i), src);
        }

        [MethodImpl(Inline)]
        public ref T Write(in BitFieldSpec spec, ReadOnlySpan<T> src, ref T dst)
        {
            for(var i=0; i<spec.FieldCount; i++)
                Write(skip(spec.Segments,i), skip(src,i),ref dst);                
            return ref dst;
        }
    }

    public readonly struct BitFieldOps<S,T> : IBitFieldOps<S,T>
        where S : IScalarField<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public T Read(in FieldSegment segment, in S src)
            => gbits.bitslice(src.Scalar, segment.StartPos, segment.Width);

        [MethodImpl(Inline)]
        public T Read(in FieldSegment segment, in S src, bool offset)            
            => offset ? gmath.sll(Read(segment, src), segment.StartPos)  : Read(segment,src);

        [MethodImpl(Inline)]
        public void Read(in BitFieldSpec spec, in S src, Span<T> dst)
        {
            for(var i=0; i<spec.FieldCount; i++)
                seek(dst,i) = Read(skip(spec.Segments,i), src);
        }

        [MethodImpl(Inline)]
        public ref T Write(in FieldSegment segment, in S src, ref T dst)
            => ref gbits.bitcopy(src.Scalar, segment.StartPos, segment.Width, ref dst);

        [MethodImpl(Inline)]
        public ref S Write(in FieldSegment segment, in S src, ref S dst)
        {
            var dstData = dst.Scalar;
            dst.Scalar = gbits.bitcopy(src.Scalar, segment.StartPos, segment.Width, ref dstData);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public ref T Write(in BitFieldSpec spec, ReadOnlySpan<T> src, ref T data)
        {
            for(var i=0; i<spec.FieldCount; i++)
            {
                ref readonly var segment = ref skip(spec.Segments,i);
                gbits.bitcopy(skip(src,i), segment.StartPos, segment.Width, ref data);
            }
            return ref data;
        }
    }    
}