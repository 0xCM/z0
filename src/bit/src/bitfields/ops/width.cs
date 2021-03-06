//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct BitfieldSpecs
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint width<T>(BitfieldSection<T> src)
            where T : unmanaged
                => bw32(src.LastIndex) - bw32(src.FirstIndex) + 1u;

        [MethodImpl(Inline), Op]
        public static byte width(in BitfieldSeg src)
            => (byte)(src.Max - src.Min + 1);

        [MethodImpl(Inline), Op]
        public static byte width<K>(in BitfieldSeg<K> src)
            where K : unmanaged
                => (byte)(src.Max - src.Min + 1);

        /// <summary>
        /// Computes the aggregate width of the segments that comprise the bitfield
        /// </summary>
        /// <param name="src">The bitfield spec</param>
        [MethodImpl(Inline), Op]
        public static uint width(in BitfieldModel src)
        {
            var total = 0u;
            var count = src.SectionCount;
            var segments = src.Sections;
            for(byte i=0; i<count; i++)
                total += skip(segments, i).Width;
            return total;
        }

        [MethodImpl(Inline), Op]
        public static uint width(ReadOnlySpan<BitfieldSeg> src)
        {
            var count = src.Length;
            var w = 0u;
            for(var i=0; i<count; i++)
                w += width(skip(src,i));
            return w;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint width<K>(ReadOnlySpan<BitfieldSeg<K>> src)
            where K : unmanaged
        {
            var count = src.Length;
            var w = 0u;
            for(var i=0; i<count; i++)
                w += width(skip(src,i));
            return w;
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
            var count = src.SectionCount;
            var segments = src.Sections;
            for(byte i=0; i<count; i++)
                total += skip(segments, i).Width;
            return total;
        }
    }
}