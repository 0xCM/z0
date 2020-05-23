//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using Z0.Asm.Data;

    using M = MemOpKind;

    public enum RegOpKind : byte
    {
        None,

        r8 = M.m8,

        r16 = M.m16,

        r32 = M.m32,

        r64 = M.m64,

        xmm = M.m128,

        ymm = M.m256,

        zmm = M.m512,
    }
}