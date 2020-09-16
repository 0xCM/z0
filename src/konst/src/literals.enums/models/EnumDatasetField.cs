//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public enum EnumDatasetField : uint
    {
        Token = 0 | 16u << 16,

        Index = 1 | 16u << 16,

        Name = 2 | 24u << 16,

        Scalar = 3 | 10 << 16
    }
}