//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    readonly struct NumericBitOps<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public T read(in FieldSegment segment, T src)
            => gbits.bitslice(src, segment.StartPos, segment.Width);

        [MethodImpl(Inline)]
        public ref T write(in FieldSegment segment, in T src, ref T dst)
                => ref gbits.bitcopy(src, segment.StartPos, segment.Width, ref dst);

        [MethodImpl(Inline)]
        public T read(in FieldSegment segment, T src, bool offset)
                => offset ? gmath.sll(read(segment, src), segment.StartPos)  : read(segment,src);

        [MethodImpl(Inline)]
        public void read(in BitFieldSpec spec, T src, Span<T> dst)
        {
            for(var i=0; i<spec.FieldCount; i++)
                seek(dst,i) = read(skip(spec.Segments,i), src);
        }

        [MethodImpl(Inline)]
        public void read<I,W>(in BitFieldSpec<I,W> spec, T src, Span<T> dst)
            where I : unmanaged, Enum
            where W : unmanaged, Enum
        {
            for(var i=0; i<spec.Segments.Length; i++)
                seek(dst,i) = read(skip(spec.Segments,i), src);
        }

        [MethodImpl(Inline)]
        public ref T write(in BitFieldSpec spec, ReadOnlySpan<T> src, ref T dst)
        {
            for(var i=0; i<spec.FieldCount; i++)
                write(skip(spec.Segments,i), skip(src,i),ref dst);                
            return ref dst;
        }
    }

    readonly struct NumericBitOps<S,T>
        where S : INumericBits<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public T read(in FieldSegment segment, in S src)
            => gbits.bitslice(src.Data, segment.StartPos, segment.Width);

        [MethodImpl(Inline)]
        public T read(in FieldSegment segment, in S src, bool offset)            
            => offset ? gmath.sll(read(segment, src), segment.StartPos)  : read(segment,src);

        [MethodImpl(Inline)]
        public void read(in BitFieldSpec spec, in S src, Span<T> dst)
        {
            for(var i=0; i<spec.FieldCount; i++)
                seek(dst,i) = read(skip(spec.Segments,i), src);
        }

        [MethodImpl(Inline)]
        public ref T write(in FieldSegment segment, in S src, ref T dst)
            => ref gbits.bitcopy(src.Data, segment.StartPos, segment.Width, ref dst);

        [MethodImpl(Inline)]
        public ref S write(in FieldSegment segment, in S src, ref S dst)
        {
            var dstData = dst.Data;
            dst.Data = gbits.bitcopy(src.Data, segment.StartPos, segment.Width, ref dstData);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public ref T write(in BitFieldSpec spec, ReadOnlySpan<T> src, ref T data)
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