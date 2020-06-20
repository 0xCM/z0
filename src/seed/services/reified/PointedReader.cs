//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    [ApiHost]
    public unsafe struct PointedReader  
    {
        [MethodImpl(Inline)]
        public static PointedReader<T> Create<T>(T* pSrc, int length)
            where T : unmanaged
                => new PointedReader<T>(pSrc, length);

        [MethodImpl(Inline), Op]
        public static PointedReader Create(byte* pSrc, int length)
            => new PointedReader(pSrc, length);

        readonly byte* Source;

        PointedReaderState State;
        
        [MethodImpl(Inline)]
        PointedReader(byte* pSrc, int length)
        {
            this.State = PointedReaderState.Create(length,0);
            this.Source = pSrc;
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
            read(Source, offset, ref head(dst), count);            
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