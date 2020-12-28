//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiHost]
    public readonly struct SeqSplitters
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