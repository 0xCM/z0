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
        [Record(CliTableKind.EncLog), StructLayout(LayoutKind.Sequential)]
        public struct EncLogRow : ICliRecord<EncLogRow>
        {
            public CliRowKey<EncLog> Key;

            public CliRowKey Token;

            public byte FuncCode;
        }
    }
}