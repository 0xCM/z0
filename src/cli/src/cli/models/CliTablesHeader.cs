//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.InteropServices;

    using static SRM;

    [StructLayout(LayoutKind.Sequential)]
    public struct CliTablesHeader
    {
        public utf8 Version;

        public HeapSizes HeapSizes;

        public Index<uint> RowCounts;

        public TableMask Tables;
    }
}