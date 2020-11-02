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

    [ApiHost(ApiNames.SyntaxParsers, true)]
    public readonly partial struct SyntaxParsers
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref DelimitedSplitter<T> create<T>(T delimiter, out DelimitedSplitter<T> dst)
            where T : unmanaged
        {
            dst = new DelimitedSplitter<T>(delimiter);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static AdjacencyParser<T> adjacencies<T>(T left, T right)
            where T : unmanaged
                => new AdjacencyParser<T>(left, right);

        [Op, Closures(Closure)]
        public static uint run<T>(in AdjacencyParser<T> parser, ReadOnlySpan<T> src, Span<uint> dst)
            where T : unmanaged, IEquatable<T>
        {
            var terms = math.min(src.Length - 1, dst.Length);
            var matched = 0u;
            for(var i=0u; i<terms; i++)
            {
                ref readonly var s0 = ref skip(src, i);
                ref readonly var s1 = ref skip(src, i + 1);
                if(gmath.eq(s0, parser.A) & gmath.eq(s1, parser.B))
                    seek(dst, matched++) = i;
            }
            return matched;
        }

        [Op, Closures(Closure)]
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