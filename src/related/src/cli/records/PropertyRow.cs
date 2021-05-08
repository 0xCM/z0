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
        [Record(CliTableKind.Property), StructLayout(LayoutKind.Sequential)]
        public struct PropertyRow : IRecord<PropertyRow>
        {
            public CliRowKey Key;

            public ushort PropFlags;

            public StringIndex Name;

            public BlobIndex Type;
        }
    }
}