//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct TypeDefRow : ICliRecord<TypeDefRow>
        {
            public uint Flags;

            public StringIndex Name;

            public StringIndex Namespace;

            public int Extends;

            public int FieldList;

            public int MethodList;
        }
    }
}