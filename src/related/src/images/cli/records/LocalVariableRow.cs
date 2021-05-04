//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct ImageRecords
    {
        [Record(CliTableKind.LocalVariable), StructLayout(LayoutKind.Sequential)]
        public struct LocalVariableRow : IRecord<LocalVariableRow>
        {
            public RowKey Key;

            public ushort Attributes;

            public ushort Index;

            public StringIndex Name;
        }
    }
}