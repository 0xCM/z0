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
        public static BitFieldModel model(string name, string[] names, byte[] widths)
        {
            Demands.insist(names.Length, widths.Length);
            var count = (byte)names.Length;
            var fieldWidths = span(widths);
            var fieldNames = asci.alloc(n16, count);
            var posbuffer = sys.alloc<byte>(count);
            var positions = span(posbuffer);

            byte width = 0;
            for(var i=0u; i<count; i++)
            {
                asci.encode(names[i], out fieldNames[i]);
                seek(positions,i) = width;
                width += skip(fieldWidths,i);
            }
            return new BitFieldModel(name, count, width, fieldNames, widths, posbuffer);
        }
    }
}