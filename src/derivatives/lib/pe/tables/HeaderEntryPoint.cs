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

    partial struct ImageTables
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct HeaderEntryPoint
        {
            [FieldOffset(0)]
            public readonly uint Token;

            [FieldOffset(0)]
            public readonly uint RVA;
        }
    }
}