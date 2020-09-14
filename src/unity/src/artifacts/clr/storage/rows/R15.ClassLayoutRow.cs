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

    using static Konst;

    partial struct ClrStorage
    {
        //  0x0F
        [StructLayout(LayoutKind.Sequential)]
        public struct ClassLayoutRow
        {
            public ushort PackingSize;

            public uint ClassSize;

            public uint Parent;
        }
    }

}