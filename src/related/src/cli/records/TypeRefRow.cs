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
        public struct TypeRefRow : ICliRecord<TypeRefRow>
        {
            public CliRowKey ResolutionScope;

            public StringIndex Name;

            public StringIndex Namespace;
        }
    }
}