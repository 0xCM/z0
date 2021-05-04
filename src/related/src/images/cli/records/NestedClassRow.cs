//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct ImageRecords
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct NestedClassRow
        {
            public RowKey Key;

            public RowKey NestedClass;

            public RowKey EnclosingClass;
        }
    }
}