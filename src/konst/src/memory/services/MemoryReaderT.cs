//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static memory;

    /// <summary>
    /// Defines a stream reader (of sorts) over a sequence of pointer-identified unmanaged values
    /// This ought to be fast, but if your looking for safe, many other choices would be better
    /// </summary>
    public unsafe struct MemoryReader<T>
        where T : unmanaged
    {
        readonly T* Source;

        MemoryReaderState State;

        [MethodImpl(Inline)]
        internal MemoryReader(T* pSrc, int length)
        {
            Source = pSrc;
            State = new MemoryReaderState(length, 0);
        }

        /// <summary>
        /// Deposits the next byte in a caller-supplied target and returns true if there are yet more bytes to read
        /// </summary>
        /// <param name="dst">The value of the next byte</param>
        [MethodImpl(Inline)]
        public bool Read(ref T dst)
        {
            read(Source, State.Position, ref dst);
            State.Advance();
            return State.HasNext;
        }

        /// <summary>
        /// Reads a specified number of elements if they exist or fewer if not and deposits the values in a caller-suppled target
        /// Returns the actual number of elements read
        /// </summary>
        /// <param name="offset">The offset at which to begin reading</param>
        /// <param name="wantedCount">The number of desired</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline)]
        public int Read(int offset, int wantedCount, Span<T> dst)
        {
            int count = zfunc.min(wantedCount, State.Remaining);
            read<T>(Source, offset, ref first(dst), count);
            State.Advance((uint)count);
            return count;
        }

        /// <summary>
        /// Reads a specified number of elements if they exist or fewer if not and deposits the values in a caller-suppled target
        /// Returns the actual number of elements read
        /// </summary>
        /// <param name="offset">The offset at which to begin reading</param>
        /// <param name="wantedCount">The number of desired</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline)]
        public int Read(int offset, int wantedCount, ref T dst)
        {
            int count = zfunc.min(wantedCount, State.Remaining);
            read<T>(Source, offset, ref dst, count);
            State.Advance((uint)count);
            return count;
        }

        [MethodImpl(Inline)]
        public int ReadAll(Span<T> dst)
            => Read(0, Length, dst);

        /// <summary>
        /// If source value pos is within the range [0,Length), assigns Current = pos;
        /// otherwise, assigns Current = -1 and returns true if the former and false if the latter
        /// </summary>
        /// <param name="pos">The desired reader position</param>
        [MethodImpl(Inline)]
        public bool Seek(uint pos)
            => State.Seek(pos);

        /// <summary>
        /// The current position of the stream
        /// </summary>
        public readonly int Position
        {
            [MethodImpl(Inline)]
            get => State.Position;
        }

        /// <summary>
        /// Specifies whether the reader can advance to and read the next cell
        /// </summary>
        public readonly bool HasNext
        {
            [MethodImpl(Inline)]
            get => State.HasNext;
        }

        /// <summary>
        /// Specifies the length of the data source
        /// </summary>
        public readonly int Length
        {
            [MethodImpl(Inline)]
            get => State.Length;
        }

        /// <summary>
        /// Specifies the number of elements that remain to be read
        /// </summary>
        public readonly int Remaining
        {
            [MethodImpl(Inline)]
            get => State.Remaining;
        }
    }
}