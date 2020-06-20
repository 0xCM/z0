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
        public static D.mov<imm8,r8> mov(imm8 src, r8 dst)
            => mov_g(src,dst);

        [MethodImpl(Inline), Op]
        public static D.mov<imm16,r16> mov(imm16 src, r16 dst)
            => mov_g(src,dst);

        [MethodImpl(Inline), Op]
        public static D.mov<imm32,r32> mov(imm32 src, r32 dst)
            => mov_g(src,dst);

        [MethodImpl(Inline), Op]
        public static D.mov<imm64,r64> mov(imm64 src, r64 dst)
            => mov_g(src,dst);

        [MethodImpl(Inline)]
        static mov<S,T> mov_g<S,T>(S src, T dst)
            where S : IOperand
            where T : IOperand
                => new mov<S,T>(src,dst);
    }
}