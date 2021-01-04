//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct LocalScopeRow  : IRecord<LocalScopeRow>
    {
        public RowKey Key;

        public int Method;

        public int ImportScope;

        public int VariableList;

        public int ConstantList;

        public int StartOffset;

        public int Length;
    }
}