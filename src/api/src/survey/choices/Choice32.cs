//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Represents a subset of 32 distinct choices, including the empty set
    /// </summary>
    [Flags]
    public enum Choice32 : uint
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

        Choice9 = Choice8 << 1,

        Choice10 = Choice9 << 1,

        Choice11 = Choice10 << 1,

        Choice12 = Choice11 << 1,

        Choice13 = Choice12 << 1,

        Choice14 = Choice13 << 1,

        Choice15 = Choice14 << 1,

        Choice16 = Choice15 << 1,

        Choice17 = Choice16 << 1,

        Choice18 = Choice17 << 1,

        Choice19 = Choice18 << 1,

        Choice20 = Choice19 << 1,

        Choice21 = Choice20 << 1,

        Choice22 = Choice21 << 1,

        Choice23 = Choice22 << 1,

        Choice24 = Choice23 << 1,

        Choice25 = Choice24 << 1,

        Choice26 = Choice25 << 1,

        Choice27 = Choice26 << 1,

        Choice28 = Choice27 << 1,

        Choice29 = Choice28 << 1,

        Choice30 = Choice29 << 1,

        Choice31 = Choice30 << 1,

        Choice32 = Choice31 << 1,

        All = Choice1  | Choice2  | Choice3  | Choice4  | Choice5  | Choice6  | Choice7  | Choice8
            | Choice9  | Choice10 | Choice11 | Choice12 | Choice13 | Choice14 | Choice15 | Choice16
            | Choice17 | Choice18 | Choice19 | Choice20 | Choice21 | Choice22 | Choice23 | Choice24
            | Choice25 | Choice26 | Choice27 | Choice28 | Choice29 | Choice30 | Choice31 | Choice32
    }
}