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
        [CliRecord(CliTableKind.TypeRef), StructLayout(LayoutKind.Sequential)]
        public struct TypeRefRow : ICliRecord<TypeRefRow>
        {
            public CliRowKey ResolutionScope;

            public CliStringIndex Name;

            public CliStringIndex Namespace;
        }
    }
}