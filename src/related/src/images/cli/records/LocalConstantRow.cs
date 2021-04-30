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
        [Record(CliTableKind.LocalConstant), StructLayout(LayoutKind.Sequential)]
        public struct LocalConstantRow : IRecord<LocalConstantRow>
        {
            public RowKey Key;

            public StringIndex Name;

            public BlobIndex Signature;
        }
    }
}