//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    [Table]
    public unsafe struct LIST_ENTRY
    {
        public LIST_ENTRY* Flink;
        
        public LIST_ENTRY* Blink;
    }
}