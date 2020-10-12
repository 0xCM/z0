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

    [ApiHost(ApiNames.MemReader, true)]
    public unsafe struct MemReader
    {
        readonly byte* Source;

        MemReaderState State;

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static MemReader<T> create<T>(T* pSrc, int length)
            where T : unmanaged
                => new MemReader<T>(pSrc, length);

        [MethodImpl(Inline), Op]
        public static MemReader create(byte* pSrc, int length)
            => new MemReader(pSrc, length);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static MemReader<T> create<T>(in SegRef src)
            where T : unmanaged
                => create(src.Address.Pointer<T>(), (int)src.DataSize);

        [MethodImpl(Inline)]
        internal MemReader(byte* pSrc, int length)
        {
            State = new MemReaderState(length,0);
            Source = pSrc;
        }

        [MethodImpl(Inline), Op]
        void Advance()
            => State.Advance();

        [MethodImpl(Inline), Op]
        void Advance(uint count)
            => State.Advance(count);

        [MethodImpl(Inline), Op]
        public bool Read(ref byte dst)
        {
            read(Source, State.Position, ref dst);
            Advance();
            return State.HasNext;
        }

        [MethodImpl(Inline), Op]
        public int Read(int offset, int wantedCount, Span<byte> dst)
        {
            int count = Math.Min(wantedCount, State.Remaining);
            read(Source, offset, ref first(dst), count);
            Advance((uint)count);
            return count;
        }

        [MethodImpl(Inline), Op]
        public int ReadAll(Span<byte> dst)
            => Read(0, Length, dst);

        [MethodImpl(Inline), Op]
        public bool Seek(uint pos)
            => State.Seek(pos);

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