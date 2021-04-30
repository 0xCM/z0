//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct Images
    {
        [Record(CliTableKind.LocalScope), StructLayout(LayoutKind.Sequential)]
        public struct LocalScopeRow  : IRecord<LocalScopeRow>
        {
            public RowKey Key;

            public RowKey Method;

            public RowKey ImportScope;

            public RowKey VariableList;

            public RowKey ConstantList;

            public uint StartOffset;

            public uint Length;
        }
    }
}