//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Images
{
    using System;
    using System.Runtime.InteropServices;

    partial struct ClrMetadata
    {
        //  0x24
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRefProcessor
        {
            public uint Processor;

            public uint AssemblyRef;
        }
    }
}