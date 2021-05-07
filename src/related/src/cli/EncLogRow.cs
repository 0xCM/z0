//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static ImageRecords;

    partial struct CliRecords
    {
        [Record(CliTableKind.EncLog), StructLayout(LayoutKind.Sequential)]
        public struct EncLogRow : IRecord<EncLogRow>
        {
            public CliRowKey Key;

            public CliRowKey Token;

            public byte FuncCode;
        }
    }
}