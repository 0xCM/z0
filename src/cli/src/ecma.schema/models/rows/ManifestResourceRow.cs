//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct ManifestResourceRow : IRecord<ManifestResourceRow>
    {
        public RowKey Key;

        public uint Offset;

        public ManifestResourceFlags Flags;

        public FK<name> Name;

        public int Implementation;
    }
}