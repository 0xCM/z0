//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmSemantic;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public Movzx<R8,R16> movzx(R8 src, R16 dst)
            => Movzx.create(src,dst);

        [MethodImpl(Inline), Op]
        public Movzx<R8,R32> movzx(R8 src, R32 dst)
            => Movzx.create(src,dst);

        [MethodImpl(Inline), Op]
        public Movzx<R8,R64> movzx(R8 src, R64 dst)
            => Movzx.create(src,dst);

        [MethodImpl(Inline), Op]
        public Movzx<R16,R32> movzx(R16 src, R32 dst)
            => Movzx.create(src,dst);

        [MethodImpl(Inline), Op]
        public Movzx<R16,R64> movzx(R16 src, R64 dst)
            => Movzx.create(src,dst);
    }
}