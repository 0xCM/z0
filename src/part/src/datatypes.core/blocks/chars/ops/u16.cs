//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct CharBlocks
    {
        [MethodImpl(Inline), Op]
        public static ref ushort u16(in CharBlock2 src)
            => ref memory.u16(src);

        [MethodImpl(Inline), Op]
        public static ref ushort u16(in CharBlock3 src)
            => ref memory.u16(src);

        [MethodImpl(Inline), Op]
        public static ref ushort u16(in CharBlock4 src)
            => ref memory.u16(src);

        [MethodImpl(Inline), Op]
        public static ref ushort u16(in CharBlock5 src)
            => ref memory.u16(src);

        [MethodImpl(Inline), Op]
        public static ref ushort u16(in CharBlock6 src)
            => ref memory.u16(src);

        [MethodImpl(Inline), Op]
        public static ref ushort u16(in CharBlock7 src)
            => ref memory.u16(src);

        [MethodImpl(Inline), Op]
        public static ref ushort u16(in CharBlock8 src)
            => ref memory.u16(src);

        [MethodImpl(Inline), Op]
        public static ref ushort u16(in CharBlock9 src)
            => ref memory.u16(src);

        [MethodImpl(Inline), Op]
        public static ref ushort u16(in CharBlock10 src)
            => ref memory.u16(src);

        [MethodImpl(Inline), Op]
        public static ref ushort u16(in CharBlock11 src)
            => ref memory.u16(src);

        [MethodImpl(Inline), Op]
        public static ref ushort u16(in CharBlock12 src)
            => ref memory.u16(src);

        [MethodImpl(Inline), Op]
        public static ref ushort u16(in CharBlock13 src)
            => ref memory.u16(src);

        [MethodImpl(Inline), Op]
        public static ref ushort u16(in CharBlock14 src)
            => ref memory.u16(src);

        [MethodImpl(Inline), Op]
        public static ref ushort u16(in CharBlock15 src)
            => ref memory.u16(src);

        [MethodImpl(Inline), Op]
        public static ref ushort u16(in CharBlock16 src)
            => ref memory.u16(src);

        [MethodImpl(Inline), Op]
        public static ref ushort u16(in CharBlock32 src)
             => ref memory.u16(src);
   }
}