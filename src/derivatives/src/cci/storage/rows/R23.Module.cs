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
        //  0x17
        [StructLayout(LayoutKind.Sequential)]
        public struct PropertyRow
        {
            public PropertyFlags Flags;

            public uint Name;

            public uint Signature;
        }
    }
}