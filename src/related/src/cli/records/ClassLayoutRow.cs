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
        [StructLayout(LayoutKind.Sequential)]
        public struct ClassLayoutRow : ICliRecord<ClassLayoutRow,ClassLayout>
        {
            public CliRowKey<ClassLayout> Key;

            public ushort PackingSize;

            public uint ClassSize;

            /// <summary>
            /// An index into the <see cref='TypeDefRow'/> table
            /// </summary>
            public CliRowKey Parent;
        }
    }
}