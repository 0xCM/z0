//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using Types;

    partial struct AsmSemantic
    {
        [MethodImpl(Inline), Op]
        public MOVZX<R8,R16> movzx(R8 src, R16 dst)
            => MOVZX.create(src,dst);

        [MethodImpl(Inline), Op]
        public MOVZX<R8,R32> movzx(R8 src, R32 dst)
            => MOVZX.create(src,dst);

        [MethodImpl(Inline), Op]
        public MOVZX<R8,R64> movzx(R8 src, R64 dst)
            => MOVZX.create(src,dst);

        [MethodImpl(Inline), Op]
        public MOVZX<R16,R32> movzx(R16 src, R32 dst)
            => MOVZX.create(src,dst);

        [MethodImpl(Inline), Op]
        public MOVZX<R16,R64> movzx(R16 src, R64 dst)
            => MOVZX.create(src,dst);
    }
}