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
        //  0x26
        [StructLayout(LayoutKind.Sequential)]
        public struct FileRow
        {
            public FileFlags Flags;

            public uint Name;

            public uint HashValue;
        }
    }
}