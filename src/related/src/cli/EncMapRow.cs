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
        [Record(CliTableKind.EncMap), StructLayout(LayoutKind.Sequential)]
        public struct EncMapRow : IRecord<EncMapRow>
        {
            public CliRowKey Key;

            public CliRowKey Token;
        }
    }
}