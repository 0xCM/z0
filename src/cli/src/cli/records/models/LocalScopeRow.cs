//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [CliRecord(CliTableKind.LocalScope), StructLayout(LayoutKind.Sequential)]
        public struct LocalScopeRow  : ICliRecord<LocalScopeRow>
        {
            public CliRowKey Method;

            public CliRowKey ImportScope;

            public CliRowKey VariableList;

            public CliRowKey ConstantList;

            public uint StartOffset;

            public uint Length;
        }
    }
}