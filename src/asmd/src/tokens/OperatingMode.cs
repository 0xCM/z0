//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    [Flags]
    public enum OperatingMode : byte
    {
        None = 0,

        Mode16 = 0b10000,

        Mode32 = 0b100000,

        Mode64 = 0b1000000,

        Non64 = Mode16 | Mode32
    }
}