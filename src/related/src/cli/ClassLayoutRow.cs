//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    using static ImageRecords;

    partial struct CliRecords
    {
        [Record(CliTableKind.ClassLayout), StructLayout(LayoutKind.Sequential)]
        public struct ClassLayoutRow : IRecord<ClassLayoutRow>
        {
            public RowKey Key;

            public ushort PackingSize;

            public uint ClassSize;

            /// <summary>
            /// An index into the <see cref='TypeDefRow'/> table
            /// </summary>
            public RowKey Parent;
        }
    }
}