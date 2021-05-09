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
        [Record(CliTableKind.TypeSpec), StructLayout(LayoutKind.Sequential)]
        public struct TypeSpecRow : ICliRecord<TypeSpecRow>
        {
            public CliRowKey<TypeSpec> Key;

            public BlobIndex Signature;
        }
    }
}