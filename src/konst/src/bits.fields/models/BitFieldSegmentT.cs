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
    /// Defines a segment within a bitfield
    /// </summary>
    /// <typeparam name="T">The value type relative to which the segment is defined</typeparam>
    public readonly struct BitFieldSegment<T> : IBitFieldSegment<BitFieldSegment<T>,T>
        where T : unmanaged
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
        public readonly T Width;

        /// <summary>
        /// The inclusive left/right segment index boundaries
        /// </summary>
        public readonly ConstPair<T> Boundary;

        [MethodImpl(Inline)]
        public BitFieldSegment(string name, T width, in ConstPair<T> boundary)
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

        T IBitFieldSegment<T>.Width
        {
            [MethodImpl(Inline)]
            get => Width;
        }

        public T StartPos
        {
           [MethodImpl(Inline)]
           get => Boundary.Left;
        }

        public T EndPos
        {
            [MethodImpl(Inline)]
            get => Boundary.Right;
        }
    }
}