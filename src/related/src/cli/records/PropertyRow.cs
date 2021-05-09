//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [Record(CliTableKind.Property), StructLayout(LayoutKind.Sequential)]
        public struct PropertyRow : ICliRecord<PropertyRow>
        {
            public CliRowKey<Property> Key;

            public ushort PropFlags;

            public StringIndex Name;

            public BlobIndex Type;
        }
    }
}