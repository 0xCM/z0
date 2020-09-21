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

    using static Part;

    partial struct MetadataRows
    {
        //  0x03
        [StructLayout(LayoutKind.Sequential)]
        public struct FieldPtr
        {
            public uint Field;
        }
    }
}