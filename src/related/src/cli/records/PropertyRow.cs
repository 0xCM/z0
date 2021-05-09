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
        [StructLayout(LayoutKind.Sequential)]
        public struct PropertyRow : ICliRecord<PropertyRow,Property>
        {
            public CliRowKey<Property> Key;

            public ushort PropFlags;

            public StringIndex Name;

            public BlobIndex Type;
        }
    }
}