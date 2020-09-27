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
        //  0x2A
        [StructLayout(LayoutKind.Sequential)]
        public struct GenericParam
        {
            public ushort Number;

            public GenericParamFlags Flags;

            public uint Owner;

            public uint Name;
        }
    }
}