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
        //  0x17
        [StructLayout(LayoutKind.Sequential)]
        public struct Property
        {
            public PropertyFlags Flags;

            public uint Name;

            public uint Signature;
        }
    }
}