//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;
    using System.Runtime.InteropServices;

    partial struct MetadataRows
    {
        //  0x29
        [StructLayout(LayoutKind.Sequential)]
        public struct NestedClassRow
        {
            public uint NestedClass;

            public uint EnclosingClass;
        }
    }
}