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
    public readonly struct BitFieldSegment : IBitFieldSegment<byte>
    {
        /// <summary>
        /// Specifies the segment identifier
        /// </summary>
        public readonly StringRef Id;

        /// <summary>
        /// The segment bit count
        /// </summary>
        /// <remarks>
        /// gmath.add(gmath.sub(startpos, endpos), one<T>())
        /// </remarks>
        public readonly byte Width;

        /// <summary>
        /// The inclusive left/right segment index boundaries
        /// </summary>
        public readonly ConstPair<byte> Boundary;
        
        [MethodImpl(Inline)]
        public static implicit operator BitFieldSegment<byte>(in BitFieldSegment src)
            => BitFields.segment<byte>(src.Name, src.Width, src.Boundary);

        [MethodImpl(Inline)]
        public BitFieldSegment(in StringRef id, byte width, in ConstPair<byte> boundary)
        {
            Id = id;
            Width = width;
            Boundary = boundary;
        }

        public string Name 
        {
            [MethodImpl(Inline)]
            get => Id;
        }

        public byte StartPos 
        {
           [MethodImpl(Inline)]
           get => Boundary.Left;
        }

        public byte EndPos 
        {
            [MethodImpl(Inline)]
            get => Boundary.Right;
        }

        byte IBitFieldSegment<byte>.Width  
        {
            [MethodImpl(Inline)]
            get => Width;
        }
    }
}