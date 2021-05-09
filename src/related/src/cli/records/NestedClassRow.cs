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
        [StructLayout(LayoutKind.Sequential)]
        public struct NestedClassRow : ICliRecord<NestedClassRow,NestedClass>
        {
            public CliRowKey<NestedClass> Key;

            public CliRowKey NestedClass;

            public CliRowKey EnclosingClass;
        }
    }
}