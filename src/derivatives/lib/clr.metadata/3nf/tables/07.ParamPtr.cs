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

    using static Part;

    partial struct ClrMetadata
    {
        //  0x07
        [StructLayout(LayoutKind.Sequential)]
        public struct ParamPtr
        {
            public uint Param;
        }
    }
}