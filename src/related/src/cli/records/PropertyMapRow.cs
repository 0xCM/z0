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
        [Record(CliTableKind.PropertyMap), StructLayout(LayoutKind.Sequential)]
        public struct PropertyMapRow : ICliRecord<PropertyMapRow>
        {
            public CliRowKey<PropertyMap> Key;

            public CliRowKey Parent;

            public CliRowKey PropertyList;
        }
    }
}