//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [Flags]
    public enum MaskKind : uint
    {
        None,

        Lsb = 1,

        Msb = 2,

        Jsb = Lsb | Msb,

        Central = 4,

        Cjsb = Central | Jsb,

        Parity,

        Index = 128,
    }
}