//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmRegs;
    using M = AsmMnemonics;

    partial struct AsmBuilder
    {
        [MethodImpl(Inline), Op]
        public AsmStatement<r8,r16> movzx(r8 src, r16 dst)
            => statement(M.movzx, args(src,dst));

        [MethodImpl(Inline), Op]
        public AsmStatement<r8,r32> movzx(r8 src, r32 dst)
            => statement(M.movzx, args(src,dst));

        [MethodImpl(Inline), Op]
        public AsmStatement<r8,r64> movzx(r8 src, r64 dst)
            => statement(M.movzx, args(src,dst));

        [MethodImpl(Inline), Op]
        public AsmStatement<r16,r32> movzx(r16 src, r32 dst)
            => statement(M.movzx, args(src,dst));

        [MethodImpl(Inline), Op]
        public AsmStatement<r16,r64> movzx(r16 src, r64 dst)
            => statement(M.movzx, args(src,dst));
    }
}