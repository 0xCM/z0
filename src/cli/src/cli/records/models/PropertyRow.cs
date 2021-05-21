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
        [CliRecord(CliTableKind.Property), StructLayout(LayoutKind.Sequential)]
        public struct PropertyRow : ICliRecord<PropertyRow>
        {
            public ushort PropFlags;

            public StringIndex Name;

            public BlobIndex Type;
        }
    }
}