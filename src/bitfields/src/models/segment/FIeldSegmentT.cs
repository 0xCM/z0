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
    /// Defines a field segment, i.e. a congiguous run of bits that, together with other segments,
    /// comprise a partition over a value of parametric type
    /// </summary>
    /// <typeparam name="T">The value type relative to which the segment is defined</typeparam>
    public readonly struct FieldSegment<T> : IFieldSegment<T>
        where T : unmanaged
    {
        /// <summary>
        /// A unique name that can be used as an alternate segment identifier
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The first index of the segment, relative to the source field
        /// </summary>
        public T StartPos {get;}

        /// <summary>
        /// The last index of the segment, relative to the source field
        /// </summary>
        public T EndPos {get;}

        /// <summary>
        /// The number of bits in the segment
        /// </summary>
        /// <remarks>
        /// gmath.add(gmath.sub(startpos, endpos), one<T>())
        /// </remarks>
        public T Width {get;}

        [MethodImpl(Inline)]
        internal FieldSegment(string name, T first, T last, T width)
        {
            this.Name = name;
            this.StartPos = first;
            this.EndPos = last;
            this.Width = width;
        }

        public string Format()
            => SegmentFormatter.create<T>().Format(this);

        public override string ToString()
            => Format();
    }    
}