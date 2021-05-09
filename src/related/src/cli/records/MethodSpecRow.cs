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
        [Record(CliTableKind.MethodSpec), StructLayout(LayoutKind.Sequential)]
        public struct MethodSpecRow : ICliRecord<MethodSpecRow>
        {
            public CliRowKey<MethodSpec> Key;

            public CliRowKey Method;

            public BlobIndex Instantiation;
        }
    }
}