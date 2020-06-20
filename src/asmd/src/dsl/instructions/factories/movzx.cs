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
        public static D.movzx<r8,r16> movzx(r8 src, r16 dst)
            => movzx_g(src,dst);

        [MethodImpl(Inline), Op]
        public static D.movzx<r8,r32> movzx(r8 src, r32 dst)
            => movzx_g(src,dst);

        [MethodImpl(Inline), Op]
        public static D.movzx<r8,r64> movzx(r8 src, r64 dst)
            => movzx_g(src,dst);

        [MethodImpl(Inline), Op]
        public static D.movzx<r16,r32> movzx(r16 src, r32 dst)
            => movzx_g(src,dst);

        [MethodImpl(Inline), Op]
        public static D.movzx<r16,r64> movzx(r16 src, r64 dst)
            => movzx_g(src,dst);


        [MethodImpl(Inline)]
        static movzx<S,T> movzx_g<S,T>(S src, T dst)
            where S : IOperand
            where T : IOperand
                => new movzx<S,T>(src,dst);
    }
}