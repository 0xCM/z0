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
    using static AsmDocParts;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static LineLabel label(W8 w, ulong offset)
            => new LineLabel((byte)offset);

        [MethodImpl(Inline), Op]
        public static LineLabel label(W16 w, ulong offset)
            => new LineLabel((ushort)offset);

        [MethodImpl(Inline), Op]
        public static LineLabel label(W32 w, ulong offset)
            => new LineLabel((uint)offset);

        [MethodImpl(Inline), Op]
        public static LineLabel label(W64 w, ulong offset)
            => new LineLabel(offset);

        [Op]
        public static string label(in LineLabel src, out string dst)
            => dst = src.Width switch{
                DataWidth.W8 => ScalarCast.uint8(src.Offset).FormatAsmHex() + CharText.Space,
                DataWidth.W16 => ScalarCast.uint16(src.Offset).FormatAsmHex() + CharText.Space,
                DataWidth.W32 => ScalarCast.uint32(src.Offset).FormatAsmHex() + CharText.Space,
                DataWidth.W64 => src.Offset.FormatAsmHex() + CharText.Space,
                _ => EmptyString
            };

    }
}