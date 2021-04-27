//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

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