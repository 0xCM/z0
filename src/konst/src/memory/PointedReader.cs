//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public unsafe struct PointedReader
    {
        readonly byte* Source;

        PointedReaderState State;

        [MethodImpl(Inline)]
        public static PointedReader<T> create<T>(T* pSrc, int length)
            where T : unmanaged
                => new PointedReader<T>(pSrc, length);

        [MethodImpl(Inline)]
        public static PointedReader create(byte* pSrc, int length)
            => new PointedReader(pSrc, length);

        [MethodImpl(Inline)]
        public static PointedReader<T> create<T>(SegRef src)
            where T : unmanaged
                => create(src.Address.Pointer<T>(), (int)src.DataSize);

        [MethodImpl(Inline)]
        internal PointedReader(byte* pSrc, int length)
        {
            State = new PointedReaderState(length,0);
            Source = pSrc;
        }

        [MethodImpl(Inline)]
        void Advance()
            => State.Advance();

        [MethodImpl(Inline)]
        void Advance(uint count)
            => State.Advance(count);

        [MethodImpl(Inline)]
        public bool Read(ref byte dst)
        {
            read(Source, State.Position, ref dst);
            Advance();
            return State.HasNext;
        }

        [MethodImpl(Inline)]
        public int Read(int offset, int wantedCount, Span<byte> dst)
        {
            int count = Math.Min(wantedCount, State.Remaining);
            read(Source, offset, ref first(dst), count);
            Advance((uint)count);
            return count;
        }

        [MethodImpl(Inline)]
        public int ReadAll(Span<byte> dst)
            => Read(0, Length, dst);

        [MethodImpl(Inline)]
        public bool Seek(uint pos)
            => State.Seek(pos);

        public readonly int Position
        {
            [MethodImpl(Inline)]
            get => State.Position;
        }

        /// <summary>
        /// Spefifies whether the reader can advance to and read the next cell
        /// </summary>
        public readonly bool HasNext
        {
            [MethodImpl(Inline)]
            get => State.HasNext;
        }

        /// <summary>
        /// Spefifies the length of the data soruce
        /// </summary>
        public readonly int Length
        {
            [MethodImpl(Inline)]
            get => State.Length;
        }

        /// <summary>
        /// Spefifies the number of elements that remain to be read
        /// </summary>
        public readonly int Remaining
        {
            [MethodImpl(Inline)]
            get => State.Remaining;
        }
    }
}