//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [Record(CliTableKind.LocalConstant), StructLayout(LayoutKind.Sequential)]
        public struct LocalConstantRow : ICliRecord<LocalConstantRow>
        {
            public CliRowKey<LocalConstant> Key;

            public StringIndex Name;

            public BlobIndex Signature;
        }
    }
}