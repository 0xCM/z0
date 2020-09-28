//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Images
{
    using System.Runtime.InteropServices;

    partial struct ClrMetadata
    {
        //  0x17
        [StructLayout(LayoutKind.Sequential)]
        public struct Property
        {
            public PropertyFlags Flags;

            public uint Name;

            public uint Signature;
        }
    }
}