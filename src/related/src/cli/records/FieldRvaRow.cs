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
        [Record(CliTableKind.FieldRva), StructLayout(LayoutKind.Sequential)]
        public struct FieldRvaRow : ICliRecord<FieldRvaRow>
        {
            public CliRowKey Key;

            public uint Offset;

            public CliRowKey Field;
        }
    }
}