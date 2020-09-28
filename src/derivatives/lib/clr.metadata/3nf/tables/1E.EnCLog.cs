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
        //  0x1E
        [StructLayout(LayoutKind.Sequential)]
        public struct EnCLog
        {
            public uint Token;

            public uint FuncCode;
        }

        //  0x1F
        [StructLayout(LayoutKind.Sequential)]
        public struct EnCMap
        {
            public uint Token;
        }
    }
}