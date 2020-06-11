//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static mov;

    using D = Dsl;

    partial class asm
    {
        [MethodImpl(Inline), Op]
        public static D.mov<imm8,r8> mov(imm8 src, r8 dst)
            => define(src,dst);

        [MethodImpl(Inline), Op]
        public static D.mov<imm16,r16> mov(imm16 src, r16 dst)
            => define(src,dst);

        [MethodImpl(Inline), Op]
        public static D.mov<imm32,r32> mov(imm32 src, r32 dst)
            => define(src,dst);

        [MethodImpl(Inline), Op]
        public static D.mov<imm64,r64> mov(imm64 src, r64 dst)
            => define(src,dst);
    }
}