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
        //  0x1D
        [StructLayout(LayoutKind.Sequential)]
        public struct FieldRVA
        {
            public uint RVA;

            public uint Field;
        }
    }
}