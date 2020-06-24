//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using D = Dsl;

    partial class asm
    {
        [MethodImpl(Inline), Op]
        public D.imm8 imm8(byte value)
            => value;

        [MethodImpl(Inline), Op]
        public D.imm16 imm16(byte value)
            => value;

        [MethodImpl(Inline), Op]
        public D.imm16 imm16(ushort value)
            => value;

        [MethodImpl(Inline), Op]
        public D.imm32 imm32(byte value)
            => value;

        [MethodImpl(Inline), Op]
        public D.imm32 imm32(ushort value)
            => value;

        [MethodImpl(Inline), Op]
        public D.imm32 imm32(uint value)
            => value;

        [MethodImpl(Inline), Op]
        public D.imm64 imm64(byte value)
            => value;

        [MethodImpl(Inline), Op]
        public D.imm64 imm64(ushort value)
            => value;

        [MethodImpl(Inline), Op]
        public D.imm64 imm64(uint value)
            => value;

        [MethodImpl(Inline), Op]
        public D.imm64 imm64(ulong value)
            => value;

    }
}