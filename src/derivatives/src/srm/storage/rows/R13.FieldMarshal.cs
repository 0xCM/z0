//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System.Runtime.InteropServices;

    partial struct MetadataRows
    {
        //  0x0D
        [StructLayout(LayoutKind.Sequential)]
        public struct FieldMarshal
        {
            public uint Parent;

            public uint NativeType;
        }
    }
}