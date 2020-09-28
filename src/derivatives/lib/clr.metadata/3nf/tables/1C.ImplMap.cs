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
        //  0x1C
        [StructLayout(LayoutKind.Sequential)]
        public struct ImplMap
        {
            public PInvokeMapFlags PInvokeMapFlags;

            public uint MemberForwarded;

            public uint ImportName;

            public uint ImportScope;
        }
    }
}