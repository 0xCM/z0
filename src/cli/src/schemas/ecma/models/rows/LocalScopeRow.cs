//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

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