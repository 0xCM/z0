//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;

    using M = MemOpKind;

    public enum ImmOpKind : byte
    {
        None = 0,

        imm8 = M.m8,

        imm16 = M.m16,

        imm32 = M.m32,

        imm64 = M.m64,
    }
}