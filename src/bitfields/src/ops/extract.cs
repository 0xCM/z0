//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    partial class BitFields
    {            
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public T extract<T>(in BitField<T> field, in FieldSegment seg, T src)
            where T : unmanaged
                => field.Extract(seg, src);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public T extract<T>(in BitField<T> field,in FieldSegment seg, T src, bool offset)
            where T : unmanaged
                => field.Extract(seg, src, offset);

        /// <summary>
        /// Extracts a primal bitfield segment
        /// </summary>
        /// <param name="src">The source field</param>
        /// <param name="i0">The index of the first bit</param>
        /// <param name="i1">The index of the last bit</param>
        /// <typeparam name="F">The primal field type</typeparam>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(Inline)]
        public static T extract<F,T>(F src, byte i0, byte i1)
            where F : IBitField<T>
            where T : unmanaged 
                => gbits.extract(src.FieldData,i0,i1);

        [MethodImpl(Inline)]
        public static T extract<F,I,T>(F f, I i0, I i1)
            where T : unmanaged 
            where F : IBitField<T>
            where I : unmanaged, Enum
                => extract<F,T>(f, Enums.e8u(i0), Enums.e8u(i1));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T extract<T>(in FieldSegment seg, T src)
            where T : unmanaged
            => gbits.slice(src, seg.StartPos, seg.Width);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T extract<T>(in FieldSegment seg, T src, bool offset)
            where T : unmanaged
            => offset ? gmath.sll(extract(seg, src), seg.StartPos) : extract(seg,src);


        [MethodImpl(Inline)]
        public static T extract<S,T>(in FieldSegment segment, in S src)
            where S : IScalarField<T>
            where T : unmanaged
                => gbits.slice(src.Scalar, segment.StartPos, segment.Width);

        [MethodImpl(Inline)]
        public static T extract<S,T>(in FieldSegment segment, in S src, bool offset)            
            where S : IScalarField<T>
            where T : unmanaged
                => offset
                 ? gmath.sll(extract<S,T>(segment, src), segment.StartPos)  
                 : extract<S,T>(segment,src);
    }
}