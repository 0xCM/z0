//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Represents a subset of 8 distinct choices, including the empty set
    /// </summary>
    [Flags]
    public enum Choice8 : byte
    {
        None = 0,

        Choice1 = 1,

        Choice2 = Choice1 << 1,

        Choice3 = Choice2 << 1,

        Choice4 = Choice3 << 1,

        Choice5 = Choice4 << 1,

        Choice6 = Choice5 << 1,

        Choice7 = Choice6 << 1,

        Choice8 = Choice7 << 1,

        All = Choice1 | Choice2 | Choice3 | Choice4 | Choice5 | Choice6 | Choice7 | Choice8
    }
}