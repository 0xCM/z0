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
        //  0x01
        [StructLayout(LayoutKind.Sequential)]
        public struct TypeRef
        {
            public readonly uint ResolutionScope;

            public readonly uint Name;

            public readonly uint Namespace;
        }
    }
}