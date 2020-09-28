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
        //  0x19
        [StructLayout(LayoutKind.Sequential)]
        public struct MethodImpl
        {
            public uint Class;

            public uint MethodBody;

            public uint MethodDeclaration;
        }
    }
}