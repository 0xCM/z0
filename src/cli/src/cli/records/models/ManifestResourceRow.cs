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
        [CliRecord(CliTableKind.ManifestResource), StructLayout(LayoutKind.Sequential)]
        public struct ManifestResourceRow : ICliRecord<ManifestResourceRow>
        {
            public uint Offset;

            public ManifestResourceFlags Flags;

            public CliStringIndex Name;

            public CliRowKey Implementation;
        }
    }
}