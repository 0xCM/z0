//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct Images
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct TypeRefRow : IRecord<TypeRefRow>
        {
            public RowKey Key;

            public RowKey ResolutionScope;

            public StringIndex Name;

            public StringIndex Namespace;
        }
    }
}