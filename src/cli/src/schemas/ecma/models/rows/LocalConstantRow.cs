//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct LocalConstantRow : IRecord<LocalConstantRow>
    {
        public RowKey Key;

        public FK<StringIndex> Name;

        public FK<BlobIndex> Signature;
    }
}