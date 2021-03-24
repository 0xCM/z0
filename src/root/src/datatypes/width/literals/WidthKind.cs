//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Flags]
    public enum WidthKind : byte
    {
        None = 0,

        Data = 1,

        Type = 2,

        Numeric = 4,

        Vector = 8,

        Cell = 16,
    }
}