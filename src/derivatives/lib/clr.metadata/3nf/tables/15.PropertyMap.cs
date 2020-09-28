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
        //  0x15
        [StructLayout(LayoutKind.Sequential)]
        public struct PropertyMap
        {
            public uint Parent;

            public uint PropertyList;
        }
    }
}