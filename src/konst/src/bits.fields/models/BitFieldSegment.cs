//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a byte-parametric field segment
    /// </summary>
    public readonly struct BitFieldSegment : IBitFieldSegment<uint>
    {
        /// <summary>
        /// Specifies the segment identifier
        /// </summary>
        readonly StringRef NameRef;

        /// <summary>
        /// The segment bit count
        /// </summary>
        /// <remarks>
        /// gmath.add(gmath.sub(startpos, endpos), one<T>())
        /// </remarks>
        public byte Width {get;}

        /// <summary>
        /// The inclusive left/right segment index boundaries
        /// </summary>
        public ConstPair<uint> Boundary {get;}

        [MethodImpl(Inline)]
        public static implicit operator BitFieldSegment<uint>(in BitFieldSegment src)
            => new BitFieldSegment<uint>(src.Name, src.Width, src.Boundary);

        [MethodImpl(Inline)]
        public BitFieldSegment(string name, byte width, in ConstPair<uint> boundary)
        {
            NameRef = name;
            Width = width;
            Boundary = boundary;
        }

        public string Name
        {
            [MethodImpl(Inline)]
            get => NameRef;
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
    }
}