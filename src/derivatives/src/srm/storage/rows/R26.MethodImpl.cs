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