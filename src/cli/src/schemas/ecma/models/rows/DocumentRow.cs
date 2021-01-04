//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct DocumentRow
    {
        public RowKey Key;

        public FK<BlobIndex> Name;

        public FK<guid> HashAlgorithm;

        public FK<BlobIndex> Hash;

        public FK<guid> Language;
    }
}