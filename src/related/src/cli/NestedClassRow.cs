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
        [StructLayout(LayoutKind.Sequential)]
        public struct NestedClassRow
        {
            public CliRowKey Key;

            public CliRowKey NestedClass;

            public CliRowKey EnclosingClass;
        }
    }
}