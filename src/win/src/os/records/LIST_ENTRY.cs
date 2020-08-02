//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    [Record]
    public unsafe struct LIST_ENTRY
    {
        public LIST_ENTRY* Flink;
        
        public LIST_ENTRY* Blink;
    }
}