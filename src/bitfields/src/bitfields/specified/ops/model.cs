//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct BitFieldSpecs
    {
        [Op]
        public static BitFieldModel model(Name name, ReadOnlySpan<string> names, ReadOnlySpan<byte> widths)
        {
            var count = (uint)names.Length;
            var fieldWidths = span(widths);
            var posbuffer = alloc<uint>(count);
            var positions = span(posbuffer);
            var sBuffer = alloc<BitFieldPart>(count);
            var segments = span(sBuffer);
            uint totalWidth = 0;
            for(var i=0u; i<count; i++)
            {
                ref readonly var w = ref skip(widths,i);
                ref readonly var segname = ref skip(names,i);
                seek(positions,i) = totalWidth;
                seek(segments,i) = part(segname, (byte)totalWidth, (byte)(totalWidth + w));
                totalWidth += skip(fieldWidths, i);
            }
            return new BitFieldModel(name, count, totalWidth, sBuffer);
        }
    }
}