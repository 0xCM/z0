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
        //  0x18
        [StructLayout(LayoutKind.Sequential)]
        public struct MethodSemantics
        {
            public MethodSemanticsFlags SemanticsFlag;

            public uint Method;

            public uint Association;
        }
    }
}