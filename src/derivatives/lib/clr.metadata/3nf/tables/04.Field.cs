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
        //  0x04
        [StructLayout(LayoutKind.Sequential)]
        public struct Field
        {
            public FieldFlags Flags;

            public uint Name;

            public uint Signature;
        }
    }
}