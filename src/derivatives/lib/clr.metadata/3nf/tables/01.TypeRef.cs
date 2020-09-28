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