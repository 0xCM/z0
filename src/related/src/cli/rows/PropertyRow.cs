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
        public struct PropertyRow : IRecord<PropertyRow>
        {
            public RowKey Key;

            public ushort PropFlags;

            public StringIndex Name;

            public BlobIndex Type;
        }
    }
}