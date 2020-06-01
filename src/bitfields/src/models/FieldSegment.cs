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

    /// <summary>
    /// Defines a byte-parametric field segment
    /// </summary>
    public readonly struct FieldSegment : INumericSegment<byte>
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
        public static implicit operator FieldSegment<byte>(FieldSegment src)
            => new FieldSegment<byte>(src.Name, src.StartPos, src.EndPos, src.Width);

        [MethodImpl(Inline)]
        internal FieldSegment(string name, byte startpos, byte endpos, byte width)
        {
            this.Name = name;
            this.StartPos = startpos;
            this.EndPos = endpos;
            this.Width = width;
        }

        public string Format()
            => SegmentFormatter.create<byte>().Format(this);

        public override string ToString()
            => Format();
    }
}