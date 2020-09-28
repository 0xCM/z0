//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Images
{
    using System;
    using System.Runtime.InteropServices;

    partial struct ClrMetadata
    {
        //  0x2C
        [StructLayout(LayoutKind.Sequential)]
        public struct GenericParamConstraint
        {
            public uint Owner;

            public uint Constraint;
        }
    }
}