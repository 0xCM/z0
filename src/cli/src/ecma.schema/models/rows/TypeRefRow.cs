//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct TypeRefRow : IRecord<TypeRefRow>
    {
        public RowKey Key;

        public int ResolutionScope;

        public FK<name> Name;

        public FK<name> Namespace;
    }
}