//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System;
    using System.Runtime.InteropServices;

    public struct PropertyRow : IRecord<PropertyRow>
    {
        public RowKey Key;

        public ushort PropFlags;

        public FK<name> Name;

        public FK<bytes> Type;
    }
}