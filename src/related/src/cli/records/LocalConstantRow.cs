//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record(CliTableKind.LocalConstant), StructLayout(LayoutKind.Sequential)]
        public struct LocalConstantRow : ICliRecord<LocalConstantRow>
        {
            public CliRowKey Key;

            public StringIndex Name;

            public BlobIndex Signature;
        }
    }
}