//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static SRM;

    using static Part;

    [StructLayout(LayoutKind.Sequential)]
    public struct CliHeader
    {
        public utf8 Version;

        public HeapSizes HeapSizes;

        public Index<uint> RowCounts;

        public TableMask Tables;
    }
}