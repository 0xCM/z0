//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;

    [Flags]
    public enum OperatingMode : byte
    {
        None = 0,

        Mode16 = 0b10000,

        Mode32 = 0b100000,

        Mode64 = 0b1000000,

        Mode16x32 =  Mode16 | Mode32,

        All = Mode16 | Mode32 | Mode64,
    }
}