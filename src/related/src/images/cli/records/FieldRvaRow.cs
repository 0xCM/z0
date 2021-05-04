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
        [Record(CliTableKind.FieldRva), StructLayout(LayoutKind.Sequential)]
        public struct FieldRvaRow : IRecord<FieldRvaRow>
        {
            public RowKey Key;

            public uint Offset;

            public RowKey Field;
        }
    }
}