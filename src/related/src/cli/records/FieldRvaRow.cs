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
        [Record(CliTableKind.FieldRva), StructLayout(LayoutKind.Sequential)]
        public struct FieldRvaRow : ICliRecord<FieldRvaRow,FieldRva>
        {
            public CliRowKey<FieldRva> Key;

            public uint Offset;

            public CliRowKey Field;
        }
    }
}