//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using I = Dsl;

    public readonly struct imm
    {
        public static imm Service => default;

        [MethodImpl(Inline)]
        public I.imm8 imm8(byte value)
            => value;

        [MethodImpl(Inline)]
        public I.imm16 imm16(byte value)
            => value;

        [MethodImpl(Inline)]
        public I.imm16 imm16(ushort value)
            => value;

        [MethodImpl(Inline)]
        public I.imm32 imm32(byte value)
            => value;

        [MethodImpl(Inline)]
        public I.imm32 imm32(ushort value)
            => value;

        [MethodImpl(Inline)]
        public I.imm32 imm32(uint value)
            => value;

        [MethodImpl(Inline)]
        public I.imm64 imm64(byte value)
            => value;

        [MethodImpl(Inline)]
        public I.imm64 imm64(ushort value)
            => value;

        [MethodImpl(Inline)]
        public I.imm64 imm64(uint value)
            => value;

        [MethodImpl(Inline)]
        public I.imm64 imm64(ulong value)
            => value;
    }
}