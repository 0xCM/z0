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
        //  0x00
        [StructLayout(LayoutKind.Sequential)]
        public struct Module
        {
            public readonly ushort Generation;

            public readonly uint Name;

            public readonly uint MVId;

            public readonly uint EnCId;

            public readonly uint EnCBaseId;
        }
    }
}