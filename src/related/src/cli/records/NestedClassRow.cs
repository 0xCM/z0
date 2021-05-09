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
        [Record(CliTableKind.NestedClass), StructLayout(LayoutKind.Sequential)]
        public struct NestedClassRow : ICliRecord<NestedClassRow>
        {
            public CliRowKey<NestedClass> Key;

            public CliRowKey NestedClass;

            public CliRowKey EnclosingClass;
        }
    }
}