//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm.Dsl;
    using Z0.Asm;

    using static Konst;

    /// <summary>
    /// Represents the <see cref='Mnemonic.Movzx'/> instruction
    /// </summary>
    partial struct asm
    {

        [MethodImpl(Inline), Op]
        public static AsmArgs<r8,r16> movzx(r8 src, r16 dst)
            => asm.args(src,dst);

        [MethodImpl(Inline), Op]
        public static AsmArgs<r8,r32> movzx(r8 src, r32 dst)
            => asm.args(src,dst);

        [MethodImpl(Inline), Op]
        public static AsmArgs<r8,r64> movzx(r8 src, r64 dst)
            => asm.args(src,dst);

        [MethodImpl(Inline), Op]
        public static AsmArgs<r16,r32> movzx(r16 src, r32 dst)
            => asm.args(src,dst);

        [MethodImpl(Inline), Op]
        public static AsmArgs<r16,r64> movzx(r16 src, r64 dst)
            => asm.args(src,dst);
    }
}