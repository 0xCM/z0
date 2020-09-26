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

    partial struct MetadataRows
    {
        //  0x06
        [StructLayout(LayoutKind.Sequential)]
        public struct Method
        {
            public uint RVA;

            public MethodImplFlags ImplFlags;

            public MethodFlags Flags;

            public uint Name;

            public uint Signature;

            public uint ParamList;
        }
    }
}