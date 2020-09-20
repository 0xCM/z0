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
        //  0x09
        [StructLayout(LayoutKind.Sequential)]
        public struct InterfaceImplRow
        {
            public uint Class;

            public uint Interface;
        }
    }
}