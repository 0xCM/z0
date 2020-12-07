//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    unsafe struct MemoryReaderState
    {
        public readonly int Length;

        public int Position;

        [MethodImpl(Inline)]
        internal MemoryReaderState(int length, int position)
        {
            Length = length;
            Position = position;
        }

        /// <summary>
        /// Advances the stream to the next position, if any
        /// </summary>
        [MethodImpl(Inline)]
        public void Advance()
            => ++ Position;

        /// <summary>
        /// Advances the stream a specified number if elements, if possible
        /// </summary>
        /// <param name="count">The number of elements to advance</param>
        [MethodImpl(Inline)]
        public void Advance(uint count)
            => Position += (int)count;

        /// <summary>
        /// If source value pos is within the range [0,Length), assigns Current = pos;
        /// otherwise, assigns Current = -1 and returns true if the former and false if the latter
        /// </summary>
        /// <param name="pos">The desired reader position</param>
        [MethodImpl(Inline)]
        public bool Seek(uint pos)
        {
            if(pos >= Length)
                Position = -1;
            else
                Position = (int)pos;
            return Position >= 0;
        }

        /// <summary>
        /// Specifies whether the reader can advance to and read the next cell
        /// </summary>
        public bool HasNext
        {
            [MethodImpl(Inline)]
            get => Position < (Length - 1);
        }

        public readonly int Remaining
        {
            [MethodImpl(Inline)]
            get => Length - Position;
        }
    }
}