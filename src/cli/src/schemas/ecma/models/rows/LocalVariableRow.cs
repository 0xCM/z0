//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

    using static Relations;

    [StructLayout(LayoutKind.Sequential)]
    public struct LocalVariableRow : IRecord<LocalVariableRow>
    {
        public RowKey Key;

        public ushort Attributes;

        public ushort Index;

        public FK<StringIndex> Name;
    }
}