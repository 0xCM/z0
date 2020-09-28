//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Images
{
    using System.Runtime.InteropServices;

    partial struct ClrMetadata
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