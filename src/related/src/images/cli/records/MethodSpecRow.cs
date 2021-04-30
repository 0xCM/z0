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
        [Record(CliTableKind.MethodSpec), StructLayout(LayoutKind.Sequential)]
        public struct MethodSpecRow : IRecord<MethodSpecRow>
        {
            public RowKey Key;

            public RowKey Method;

            public BlobIndex Instantiation;
        }
    }
}