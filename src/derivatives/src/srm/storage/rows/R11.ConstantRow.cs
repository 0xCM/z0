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
        //  0x0B
        [StructLayout(LayoutKind.Sequential)]
        public struct ConstantRow
        {
            public byte Type;

            public uint Parent;

            public uint Value;

        }
    }
}