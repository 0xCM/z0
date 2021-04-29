//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct Images
    {
        [Record(CliTableKind.ClassLayout), StructLayout(LayoutKind.Sequential)]
        public struct ClassLayoutRow : IRecord<ClassLayoutRow>
        {
            public RowKey Key;

            public ushort PackingSize;

            public uint ClassSize;

            public RowKey Parent;
        }
    }
}