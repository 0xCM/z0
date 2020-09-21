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
        //  0x0C
        [StructLayout(LayoutKind.Sequential)]
        public struct CustomAttribute
        {
            public uint Parent;

            public uint Type;

            public uint Value;
        }
    }
}