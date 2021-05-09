//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record(CliTableKind.LocalVariable), StructLayout(LayoutKind.Sequential)]
        public struct LocalVariableRow : ICliRecord<LocalVariableRow>
        {
            public CliRowKey Key;

            public ushort Attributes;

            public ushort Index;

            public StringIndex Name;
        }
    }
}