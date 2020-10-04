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

    partial class BitFields
    {
        [Op]
        public static BitFieldModel model(string name, ReadOnlySpan<string> names, ReadOnlySpan<byte> widths)
        {
            Demands.insist(names.Length, widths.Length);
            var count = (uint)names.Length;
            var fieldWidths = span(widths);
            var posbuffer = alloc<uint>(count);
            var positions = span(posbuffer);
            var sBuffer = alloc<BitFieldSegment>(count);
            var segments = span(sBuffer);
            uint totalWidth = 0;
            for(var i=0u; i<count; i++)
            {
                ref readonly var w = ref skip(widths,i);
                ref readonly var n = ref skip(names,i);
                seek(positions,i) = totalWidth;
                seek(segments,i) = new BitFieldSegment(n, w, (totalWidth, totalWidth + w));
                totalWidth += skip(fieldWidths, i);
            }
            return new BitFieldModel(name, count, totalWidth, sBuffer);
        }
    }
}