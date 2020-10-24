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

    [ApiHost(ApiNames.UnmanagedParsers, true)]
    public readonly partial struct UnmanagedParsers
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref DelimitedSplitter<T> create<T>(T delimiter, out DelimitedSplitter<T> dst)
            where T : unmanaged
        {
            dst = new DelimitedSplitter<T>(delimiter);
            return ref dst;
        }

        [Op, Closures(UnsignedInts)]
        public static ref BufferSegments<T> run<T>(DelimitedSplitter<T> parser, Span<T> src, out BufferSegments<T> dst)
            where T : unmanaged
        {
            dst = new BufferSegments<T>(src, byte.MaxValue);
            parser.InputCount = (uint)src.Length;
            parser.LastPos = parser.InputCount - 1;

            var segment = default(BufferSegment<T>);
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

            dst.SegCount = parser.SegPos + 1;
            return ref dst;
        }
    }
}