//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;
    using System.Runtime.CompilerServices;

    public struct SubSection
    {
        public string SectionName;

        public uint Offset;

        public MemoryBlock MemoryBlock;
    }
}