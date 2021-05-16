//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct ManifestResourceRow : ICliRecord<ManifestResourceRow>
        {
            public uint Offset;

            public ManifestResourceFlags Flags;

            public StringIndex Name;

            public CliRowKey Implementation;
        }
    }
}