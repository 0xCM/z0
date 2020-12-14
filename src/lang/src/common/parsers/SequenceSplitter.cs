//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Partitions T-cell sequences predicated on a supplied delimiter
    /// </summary>
    public struct SeqSplitter<T>
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
        public SeqSplitter(T delimiter)
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
        public readonly ClosedInterval<uint> MarkSegment()
            => new ClosedInterval<uint>(I0, I1);

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

    public readonly struct SeqSplitter
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static SeqSplitter<T> create<T>(T delimiter)
            where T : unmanaged
                => new SeqSplitter<T>(delimiter);

        [Op, Closures(UnsignedInts)]
        public static ref BufferSegments<T> run<T>(SeqSplitter<T> parser, Span<T> src, out BufferSegments<T> dst)
            where T : unmanaged
        {
            dst = new BufferSegments<T>(src, byte.MaxValue);
            parser.InputCount = (uint)src.Length;
            parser.LastPos = parser.InputCount - 1;

            var segment = default(ClosedInterval<uint>);
            while(parser.Unfinished())
            {
                ref readonly var cell = ref skip(src, parser.CellPos);

                if(parser.OnLastPos())
                {
                    if(parser.Collecting)
                        dst.Range(parser.SegPos, parser.I0, parser.I1);
                }
                else if(parser.IsDelimiter(cell))
                {
                    if(parser.Collecting)
                    {
                        dst.Range(parser.SegPos, parser.I0, parser.I1 - 1);
                        parser.NextSeg();
                    }

                    parser.I0 = parser.CellPos + 1;
                    parser.I1 = parser.I0;
                    parser.Collecting = true;
                    segment = parser.MarkSegment();
                }
                else if(parser.Collecting)
                    parser.NextPoint();

                parser.NextCell();
            }

            dst.Dispensed = parser.SegPos + 1;
            return ref dst;
        }
    }
}