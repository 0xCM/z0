//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct AsmBytes
    {
        [Op]
        public static string format(AsmHexCode src)
            => src.Data.FormatHexData(src.Size);

        [MethodImpl(Inline), Op]
        public static AsmHexCode hexcode(ReadOnlySpan<byte> src)
        {
            var cell = Cells.alloc(w128);
            var count = (byte)root.min(src.Length, 15);
            var dst = bytes(cell);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i);
            Cells.cell8(cell, 15) = count;
            return new AsmHexCode(cell);
        }

        [Op]
        public static AsmHexCode hexcode(string src)
        {
            var dst = AsmHexCode.Empty;
            hexcode(src, out dst);
            return dst;
        }

        [Op]
        public static bool hexcode(string src, out AsmHexCode dst)
        {
            if(HexByteParser.parse(src, out var data))
            {
                dst = data;
                return true;
            }
            else
            {
                dst = AsmHexCode.Empty;
                return false;
            }
        }
    }
}