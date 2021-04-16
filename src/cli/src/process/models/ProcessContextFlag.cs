//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    [Flags]
    public enum ProcessContextFlag : byte
    {
        None,

        Summary = 1,

        Detail = 2,

        Dump = 4,

        All = Summary | Detail | Dump
    }
}