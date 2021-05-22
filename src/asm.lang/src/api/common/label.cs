//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static bool rel32dx(BinaryCode src, out int dx)
        {
            var opcode = src.First;
            if(opcode == 0xe8)
            {
                dx = i32(slice(src.View, 1));
                return true;
            }
            dx = default;
            return false;
        }

        [MethodImpl(Inline), Op]
        public static AsmOffsetLabel label(W8 w, ulong offset)
            => new AsmOffsetLabel((byte)offset);

        [MethodImpl(Inline), Op]
        public static AsmOffsetLabel label(W16 w, ulong offset)
            => new AsmOffsetLabel((ushort)offset);

        [MethodImpl(Inline), Op]
        public static AsmOffsetLabel label(W32 w, ulong offset)
            => new AsmOffsetLabel((uint)offset);

        [MethodImpl(Inline), Op]
        public static AsmOffsetLabel label(W64 w, ulong offset)
            => new AsmOffsetLabel(offset);
    }
}