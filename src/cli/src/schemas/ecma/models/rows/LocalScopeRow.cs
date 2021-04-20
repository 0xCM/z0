//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

    using static Relations;

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