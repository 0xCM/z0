//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public enum PrimalKindMask : byte
    {
        Width = 0b0_0000_111,

        KindId = 0b0_1111_000,

        Sign = 0b1_0000_000,
    }
}