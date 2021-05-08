//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record(CliTableKind.LocalScope), StructLayout(LayoutKind.Sequential)]
        public struct LocalScopeRow  : IRecord<LocalScopeRow>
        {
            public CliRowKey Key;

            public CliRowKey Method;

            public CliRowKey ImportScope;

            public CliRowKey VariableList;

            public CliRowKey ConstantList;

            public uint StartOffset;

            public uint Length;
        }
    }
}