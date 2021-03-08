//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct PropertyRow : IRecord<PropertyRow>
    {
        public RowKey Key;

        public ushort PropFlags;

        public FK<StringIndex> Name;

        public FK<BlobIndex> Type;
    }
}