//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Classes;


    public enum OperandClass : byte
    {
        None = 0,

        Numeric = 1,

        Blocked = 2,

        CpuVector = 4,

        BitVector = 8,

        BitMatrix = 16,
    }

}