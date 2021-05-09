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
        [Record(CliTableKind.PropertyMap), StructLayout(LayoutKind.Sequential)]
        public struct PropertyMapRow : ICliRecord<PropertyMapRow>
        {
            public CliRowKey Key;

            public CliRowKey Parent;

            public CliRowKey PropertyList;
        }
    }
}