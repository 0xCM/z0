//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record(CliTableKind.FieldLayout), StructLayout(LayoutKind.Sequential)]
        public struct FieldLayoutRow : IRecord<FieldLayoutRow>
        {
            public CliRowKey Key;

            public uint Offset;

            /// <summary>
            /// Identifies a <see cref='FieldRow'/> record
            /// </summary>
            public CliRowKey Field;
        }
    }
}