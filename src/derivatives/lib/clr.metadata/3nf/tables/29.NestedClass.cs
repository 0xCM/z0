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
        //  0x29
        [StructLayout(LayoutKind.Sequential)]
        public struct NestedClassRow
        {
            public uint NestedClass;

            public uint EnclosingClass;
        }
    }
}