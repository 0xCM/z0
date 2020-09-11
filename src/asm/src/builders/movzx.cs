//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;


    using static Konst;

    partial struct AsmBuilder
    {
        [MethodImpl(Inline), Op]
        public static AsmArgs<R8,R16> movzx(R8 src, R16 dst)
            => asm.args(src,dst);

        [MethodImpl(Inline), Op]
        public static AsmArgs<R8,R32> movzx(R8 src, R32 dst)
            => asm.args(src,dst);

        [MethodImpl(Inline), Op]
        public static AsmArgs<R8,R64> movzx(R8 src, R64 dst)
            => asm.args(src,dst);

        [MethodImpl(Inline), Op]
        public static AsmArgs<R16,R32> movzx(R16 src, R32 dst)
            => asm.args(src,dst);

        [MethodImpl(Inline), Op]
        public static AsmArgs<R16,R64> movzx(R16 src, R64 dst)
            => asm.args(src,dst);
    }
}