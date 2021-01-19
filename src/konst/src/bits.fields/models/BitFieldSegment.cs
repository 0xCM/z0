//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a byte-parametric field segment
    /// </summary>
    public readonly struct BitFieldSegment : IBitFieldSegment<uint>
    {
        /// <summary>
        /// The segment bit count
        /// </summary>
        /// <remarks>
        /// gmath.add(gmath.sub(startpos, endpos), one<T>())
        /// </remarks>
        public uint Width {get;}

        /// <summary>
        /// The inclusive left/right segment index boundaries
        /// </summary>
        public ConstPair<uint> Boundary {get;}

        [MethodImpl(Inline)]
        public BitFieldSegment(byte width, in ConstPair<uint> boundary)
        {
            Width = width;
            Boundary = boundary;
        }

        public uint StartPos
        {
           [MethodImpl(Inline)]
           get => Boundary.Left;
        }

        public uint EndPos
        {
            [MethodImpl(Inline)]
            get => Boundary.Right;
        }

        [MethodImpl(Inline)]
        public static implicit operator BitFieldSegment<uint>(in BitFieldSegment src)
            => new BitFieldSegment<uint>(src.Width, src.Boundary);
    }
}