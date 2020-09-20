//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Part;

    partial struct ClrStorage
    {
        //  0x19
        [StructLayout(LayoutKind.Sequential)]
        public struct MethodImplRow
        {
            public uint Class;

            public uint MethodBody;

            public uint MethodDeclaration;
        }
    }
}