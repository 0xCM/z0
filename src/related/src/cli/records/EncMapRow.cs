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
        [Record(CliTableKind.EncMap), StructLayout(LayoutKind.Sequential)]
        public struct EncMapRow : ICliRecord<EncMapRow>
        {
            public CliRowKey<EncMap> Key;

            public CliRowKey Token;
        }
    }
}