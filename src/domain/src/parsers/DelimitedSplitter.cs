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

    public struct DelimitedSplitter<T>
        where T : unmanaged
    {
        public readonly T Delimiter;

        internal bool Collecting;

        internal uint CellPos;

        internal uint SegPos;

        internal uint I0;

        internal uint I1;

        internal uint LastPos;

        internal uint InputCount;

        [MethodImpl(Inline)]
        public DelimitedSplitter(T delimiter)
        {
            Delimiter = delimiter;
            Collecting = true;
            CellPos = 0;
            SegPos = 0;
            I0 = 0;
            I1 = 0;
            LastPos = 0;
            InputCount = 0;
        }

        [MethodImpl(Inline)]
        public uint NextSeg()
            => ++SegPos;

        [MethodImpl(Inline)]
        public uint NextPoint()
            => ++I1;

        [MethodImpl(Inline)]
        public uint NextCell()
            => ++CellPos;

        [MethodImpl(Inline)]
        public readonly BufferSegment<T> MarkSegment()
            => new BufferSegment<T>(I0, I1);

        [MethodImpl(Inline)]
        public readonly bool OnLastPos()
            => CellPos == LastPos;

        [MethodImpl(Inline)]
        public readonly bool IsDelimiter(T candidate)
            => candidate.Equals(Delimiter);

        [MethodImpl(Inline)]
        public readonly bool Unfinished()
            => CellPos < InputCount;
    }
}