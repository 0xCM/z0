//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    using static Relations;

    [StructLayout(LayoutKind.Sequential)]
    public struct TypeDefRow : IRecord<TypeDefRow>
    {
        public RowKey Key;

        public uint Flags;

        public FK<name> Name;

        public FK<name> Namespace;

        public int Extends;

        public int FieldList;

        public int MethodList;
    }

}