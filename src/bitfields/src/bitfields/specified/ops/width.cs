//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static Rules;
    using static TextRules;
    using static memory;

    partial struct BitfieldSpecs
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint width<T>(BitFieldPart<T> src)
            where T : unmanaged
                => bw32(src.LastIndex) - bw32(src.FirstIndex) + 1u;

        /// <summary>
        /// Computes the aggregate width of the segments that comprise the bitfield
        /// </summary>
        /// <param name="spec">The bitfield spec</param>
        [MethodImpl(Inline), Op]
        public static uint width(in BitfieldSegSpecs spec)
        {
            var total = 0u;
            var count = spec.FieldCount;
            var segments = spec.Segments;
            for(byte i=0; i<count; i++)
                total += skip(segments, i).Width;
            return total;
        }

        /// <summary>
        /// Computes the aggregate width of the segments that comprise the bitfield
        /// </summary>
        /// <param name="src">The bitfield spec</param>
        [MethodImpl(Inline), Op]
        public static uint width(in BitFieldModel src)
        {
            var total = 0u;
            var count = src.SegmentCount;
            var segments = src.Segments;
            for(byte i=0; i<count; i++)
                total += skip(segments, i).Width;
            return total;
        }

        /// <summary>
        /// Computes the aggregate width of the segments that comprise the bitfield
        /// </summary>
        /// <param name="src">The bitfield spec</param>
        [MethodImpl(Inline), Op]
        public static uint width<T>(in BitFieldModel<T> src)
            where T : unmanaged
        {
            var total = 0u;
            var count = src.SegmentCount;
            var segments = src.Segments;
            for(byte i=0; i<count; i++)
                total += skip(segments, i).Width;
            return total;
        }
    }
}