//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [CliRecord(CliTableKind.NestedClass), StructLayout(LayoutKind.Sequential)]
        public struct NestedClassRow : ICliRecord<NestedClassRow>
        {
            public CliRowKey NestedClass;

            public CliRowKey EnclosingClass;
        }
    }
}