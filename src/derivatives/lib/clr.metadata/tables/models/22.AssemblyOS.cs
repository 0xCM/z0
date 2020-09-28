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
        //  0x22
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyOS
        {
            public uint OSPlatformId;

            public uint OSMajorVersionId;

            public uint OSMinorVersionId;
        }
    }
}