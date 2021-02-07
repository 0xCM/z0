//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    readonly partial struct BitFields
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T extract<T>(in BitFieldSegment seg, T src)
            where T : unmanaged
                => gbits.bitslice(src, (byte)seg.StartPos, (byte)seg.Width);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T offset<T>(in BitFieldSegment seg, T src)
            where T : unmanaged
                => gmath.sll(extract(seg, src), (byte)seg.StartPos);

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
                => gbits.segment(src.Content,i0,i1);

        [MethodImpl(Inline)]
        public static T extract<F,I,T>(F f, I i0, I i1)
            where T : unmanaged
            where F : IBitField<T>
            where I : unmanaged, Enum
                => extract<F,T>(f, EnumValue.e8u(i0), EnumValue.e8u(i1));

        [MethodImpl(Inline)]
        public static T extract<S,T>(in BitFieldSegment segment, in S src)
            where S : IScalarBitField<T>
            where T : unmanaged
                => gbits.bitslice(src.Scalar, (byte)segment.StartPos, (byte)segment.Width);

        [MethodImpl(Inline)]
        public static T extract<S,T>(in BitFieldSegment segment, in S src, bool offset)
            where S : IScalarBitField<T>
            where T : unmanaged
                => offset ? gmath.sll(extract<S,T>(segment, src), (byte)segment.StartPos) : extract<S,T>(segment,src);
    }
}