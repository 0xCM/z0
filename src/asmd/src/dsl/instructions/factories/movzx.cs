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
        public static D.movzx<imm8,r8> movzx(imm8 src, r8 dst)
            => movzx_g(src,dst);

        [MethodImpl(Inline), Op]
        public static D.movzx<imm16,r16> movzx(imm16 src, r16 dst)
            => movzx_g(src,dst);

        [MethodImpl(Inline), Op]
        public static D.movzx<imm32,r32> movzx(imm32 src, r32 dst)
            => movzx_g(src,dst);

        [MethodImpl(Inline), Op]
        public static D.movzx<imm64,r64> movzx(imm64 src, r64 dst)
            => movzx_g(src,dst);

        [MethodImpl(Inline)]
        static movzx<S,T> movzx_g<S,T>(S src, T dst)
            where S : IOperand
            where T : IOperand
                => new movzx<S,T>(src,dst);
    }
}