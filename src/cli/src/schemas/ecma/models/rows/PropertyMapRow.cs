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
    public struct PropertyMapRow : IRecord<PropertyMapRow>
    {
        public RowKey Key;

        public Token Parent;

        public Token PropertyList;
    }
}