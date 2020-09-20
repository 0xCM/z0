//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Part;

    partial struct ClrStorage
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct StreamHeader
        {
            public uint Offset;

            public int Size;

            public string Name;
        }
    }
}