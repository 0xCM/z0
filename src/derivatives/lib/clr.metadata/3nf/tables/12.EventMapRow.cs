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
        //  0x12
        [StructLayout(LayoutKind.Sequential)]
        public struct EventMap
        {
            public uint Parent;

            public uint EventList;
        }
    }
}