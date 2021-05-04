//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct ImageRecords
    {
        [Record(CliTableKind.ManifestResource), StructLayout(LayoutKind.Sequential)]
        public struct ManifestResourceRow : IRecord<ManifestResourceRow>
        {
            public RowKey Key;

            public uint Offset;

            public ManifestResourceFlags Flags;

            public StringIndex Name;

            public RowKey Implementation;
        }
    }
}