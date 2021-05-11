//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost(ApiNames.MemoryReader, true)]
    public unsafe struct MemoryReader
    {
        readonly byte* Source;

        MemoryReaderState<byte> State;

        [MethodImpl(Inline)]
        internal MemoryReader(byte* pSrc, int length)
        {
            State = new MemoryReaderState<byte>(length,0);
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
            memory.read(Source, State.Position, ref dst);
            Advance();
            return State.HasNext;
        }

        [MethodImpl(Inline), Op]
        public int Read(int offset, int requested, Span<byte> dst)
        {
            int count = root.min(requested, State.Remaining);
            memory.read(Source, offset, ref first(dst), count);
            Advance((uint)count);
            return count;
        }

        [MethodImpl(Inline), Op]
        public int Read(int offset, int requested, ref byte dst)
        {
            int count = root.min(requested, State.Remaining);
            memory.read(Source, offset, ref dst, count);
            Advance((uint)count);
            return count;
        }

        [MethodImpl(Inline), Op]
        public int ReadAll(Span<byte> dst)
            => Read(0, CellCount, dst);

        [MethodImpl(Inline), Op]
        public int ReadAll(ref byte dst)
            => Read(0, CellCount, ref dst);

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
        public readonly int CellCount
        {
            [MethodImpl(Inline)]
            get => State.CellCount;
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