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
        /// A unique name that identifies the segment
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The first index of the segment, relative to the source field
        /// </summary>
        public byte StartPos {get;}

        /// <summary>
        /// The last index of the segment, relative to the source field
        /// </summary>
        public byte EndPos {get;}

        /// <summary>
        /// The number of bits in the segment
        /// </summary>
        public byte Width {get;}

        [MethodImpl(Inline)]
        public static implicit operator BitFieldSegment<byte>(BitFieldSegment src)
            => new BitFieldSegment<byte>(src.Name, src.StartPos, src.EndPos, src.Width);

        [MethodImpl(Inline)]
        internal BitFieldSegment(string name, byte startpos, byte endpos, byte width)
        {
            this.Name = name;
            this.StartPos = startpos;
            this.EndPos = endpos;
            this.Width = width;
        }

        public string Format()
            => BitFieldSegmentFormatter.create<byte>().Format(this);

        public override string ToString()
            => Format();
    }
}