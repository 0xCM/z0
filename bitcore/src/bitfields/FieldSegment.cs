//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;


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
        /// The 0-based, monotonically increasing segment identifier
        /// </summary>
        public T Index {get;}

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
        internal FieldSegment(string name, T index,  T first, T last, T width)
        {
            this.Index = index;
            this.Name = name;
            this.StartPos = first;
            this.EndPos = last;
            this.Width = width;
        }

        public string Format()
            => FieldSegments.formatter<T>().Format(this);

        public override string ToString()
            => Format();
    }    

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
        /// An alternate segment identifier
        /// </summary>
        public byte Index {get;}

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
            => new FieldSegment<byte>(src.Name, src.Index, src.StartPos, src.EndPos, src.Width);

        [MethodImpl(Inline)]
        internal FieldSegment(string name, byte index, byte startpos, byte endpos, byte width)
        {
            this.Name = name;
            this.Index = index;
            this.StartPos = startpos;
            this.EndPos = endpos;
            this.Width = width;
        }

        public string Format()
            => FieldSegments.formatter<byte>().Format(this);

        public override string ToString()
            =>  Format();
    }
}