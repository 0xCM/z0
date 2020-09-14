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

    using static Konst;

    partial struct ClrStorage
    {
        //  0x06
        [StructLayout(LayoutKind.Sequential)]
        public struct MethodRow
        {
            public Address32 RVA;

            public MethodImplFlags ImplFlags;

            public MethodFlags Flags;

            public uint Name;

            public uint Signature;

            public uint ParamList;
        }
    }

}