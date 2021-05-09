//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [Record(CliTableKind.FieldLayout), StructLayout(LayoutKind.Sequential)]
        public struct FieldLayoutRow : ICliRecord<FieldLayoutRow>
        {
            public CliRowKey<FieldLayout> Key;

            public uint Offset;

            /// <summary>
            /// Identifies a <see cref='FieldRow'/> record
            /// </summary>
            public CliRowKey Field;
        }
    }
}