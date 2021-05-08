//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record(CliTableKind.ManifestResource), StructLayout(LayoutKind.Sequential)]
        public struct ManifestResourceRow : IRecord<ManifestResourceRow>
        {
            public CliRowKey Key;

            public uint Offset;

            public ManifestResourceFlags Flags;

            public StringIndex Name;

            public CliRowKey Implementation;
        }
    }
}