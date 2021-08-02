//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOperands;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmAddress address(RegOp @base, RegOp index, MemoryScale scale, Disp disp = default)
            => AsmAddressing.address(@base,index,scale,disp);

        [MethodImpl(Inline), Op]
        public static AsmAddress address(r8 @base, r8 index, MemoryScale scale, Disp8 disp = default)
            => AsmAddressing.address(@base,index,scale,disp);

        [MethodImpl(Inline), Op]
        public static AsmAddress address(r16 @base, r16 index, MemoryScale scale, Disp16 disp = default)
            => AsmAddressing.address(@base,index,scale,disp);

        [MethodImpl(Inline), Op]
        public static AsmAddress address(r32 @base, r32 index, MemoryScale scale, Disp32 disp = default)
            => AsmAddressing.address(@base,index,scale,disp);

        [MethodImpl(Inline), Op]
        public static AsmAddress address(r64 @base, r64 index, MemoryScale scale, Disp32 disp = default)
            => AsmAddressing.address(@base,index,scale,disp);
    }
}