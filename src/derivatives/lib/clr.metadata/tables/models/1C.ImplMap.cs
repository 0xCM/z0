//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;
    using System.Runtime.InteropServices;

    partial struct MetadataRows
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