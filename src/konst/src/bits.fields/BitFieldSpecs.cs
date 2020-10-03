//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.BitFieldSpecs)]
    public readonly struct BitFieldSpecs
    {
        /// <summary>
        /// Computes the aggregate width of the segments that comprise the bitfield
        /// </summary>
        /// <param name="spec">The bitfield spec</param>
        [MethodImpl(Inline), Op]
        public static uint width(in BitFieldSpec spec)
        {
            var total = 0u;
            var count = spec.FieldCount;
            var segments = spec.Segments;
            for(byte i=0; i<count; i++)
                total += skip(segments,i).Width;
            return total;
        }

        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<BitFieldSegment> src)
        {
            const string sep = ", ";
            var formatted = text.build();
            var count = src.Length;
            var last = count - 1;
            formatted.Append(Chars.LBracket);
            for(var i=0; i<count; i++)
            {
                ref readonly var seg = ref skip(src,i);
                formatted.Append(format(seg));
                if(i != last)
                    formatted.Append(sep);
            }

            formatted.Append(Chars.RBracket);
            return formatted.ToString();
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string format(in BitFieldSegment src)
                => string.Format(SegRenderPattern, src.Name, src.StartPos, src.EndPos);


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string format<T>(in BitFieldSegment<T> src)
            where T : unmanaged
                => string.Format(SegRenderPattern, src.Name, src.StartPos, src.EndPos);

        const string SegRenderPattern = "{0}[{1},{2}]";

    }
}