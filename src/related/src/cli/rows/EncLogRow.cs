//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct Images
    {
        [Record(CliTableKind.EncLog), StructLayout(LayoutKind.Sequential)]
        public struct EncLogRow : IRecord<EncLogRow>
        {
            public RowKey Key;

            public RowKey Token;

            public byte FuncCode;
        }
    }
}