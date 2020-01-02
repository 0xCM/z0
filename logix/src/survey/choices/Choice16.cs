//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Reprsents a subset of 16 distinct choices, including the empty set
    /// </summary>
    [Flags]
    public enum Choice16 : ushort
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

        All = Choice1 | Choice2 | Choice3 | Choice4 | Choice5 | Choice6 | Choice7 | Choice8
            | Choice9 | Choice10 | Choice11 | Choice12 | Choice13 | Choice14 | Choice15 | Choice16
    }


}