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

    partial class BitFields
    {            
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T deposit<T>(in FieldSegment seg, in T src, ref T dst)
            where T : unmanaged
                => ref gbits.copy(src, seg.StartPos, seg.Width, ref dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void deposit<T>(in BitFieldSpec spec, T src, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0; i<spec.FieldCount; i++)
                seek(dst,i) = extract(skip(spec.Segments,i), src);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T deposit<T>(in BitFieldSpec spec, ReadOnlySpan<T> src, ref T dst)
            where T : unmanaged
        {
            for(var i=0; i<spec.FieldCount; i++)
                deposit(skip(spec.Segments,i), skip(src,i),ref dst);                
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public void deposit<T>(in BitField<T> field, T src, Span<T> dst)
            where T : unmanaged
                => field.Deposit(src, dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref T deposit<T>(in BitField<T> field, in FieldSegment seg, in T src, ref T dst) 
            where T : unmanaged
                => ref field.Deposit(seg, src, ref dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref T deposit<T>(in BitField<T> field, ReadOnlySpan<T> src, ref T dst)
            where T : unmanaged
                => ref field.Deposit(src, ref dst);        

        [MethodImpl(Inline)]
        public static void deposit<E,W,T>(in BitFieldSpec<E,W> spec, T src, Span<T> dst)
            where E : unmanaged, Enum
            where W : unmanaged, Enum
            where T : unmanaged
        {
            for(var i=0; i<spec.Segments.Length; i++)
                seek(dst,i) = extract(skip(spec.Segments,i), src);
        }


        [MethodImpl(Inline)]
        public static void deposit<S,T>(in BitFieldSpec spec, in S src, Span<T> dst)
            where S : IScalarField<T>
            where T : unmanaged
        {
            for(var i=0; i<spec.FieldCount; i++)
                seek(dst,i) = extract<S,T>(skip(spec.Segments,i), src);
        }

        [MethodImpl(Inline)]
        public static ref T deposit<S,T>(in FieldSegment segment, in S src, ref T dst)
            where S : IScalarField<T>
            where T : unmanaged
                => ref gbits.copy(src.Scalar, segment.StartPos, segment.Width, ref dst);

        [MethodImpl(Inline)]
        public static ref S deposit<S,T>(in FieldSegment segment, in S src, ref S dst)
            where S : IScalarField<T>
            where T : unmanaged
        {
            var dstData = dst.Scalar;
            dst.Update(gbits.copy(src.Scalar, segment.StartPos, segment.Width, ref dstData));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref T deposit<S,T>(in BitFieldSpec spec, ReadOnlySpan<T> src, ref T data)
            where S : IScalarField<T>
            where T : unmanaged
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