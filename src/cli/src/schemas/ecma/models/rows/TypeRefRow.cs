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
    public struct TypeRefRow : IRecord<TypeRefRow>
    {
        public RowKey Key;

        public int ResolutionScope;

        public FK<StringIndex> Name;

        public FK<StringIndex> Namespace;
    }
}