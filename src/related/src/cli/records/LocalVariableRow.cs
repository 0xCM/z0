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
        [Record(CliTableKind.LocalVariable), StructLayout(LayoutKind.Sequential)]
        public struct LocalVariableRow : ICliRecord<LocalVariableRow>
        {
            public CliRowKey<LocalVariable> Key;

            public ushort Attributes;

            public ushort Index;

            public StringIndex Name;
        }
    }
}