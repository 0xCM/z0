//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct ClrStorage
    {
        public struct SubSection
        {
            public string SectionName;

            public uint Offset;

            public MemoryBlock MemoryBlock;
        }
    }
}