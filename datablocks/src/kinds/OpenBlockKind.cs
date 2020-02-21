//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static FixedWidth;

    /// <summary>
    /// Classifies open generic block types
    /// </summary>
    public enum OpenBlockKind : uint
    {
        None = 0,

        Block16 = W16,

        Block32 = W32,

        Block64 = W64,

        Block128 = W128,

        Block256 = W256,

        Block512 = W512
    }

}