//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [CliRecord(CliTableKind.EncLog), StructLayout(LayoutKind.Sequential)]
        public struct EncLogRow : ICliRecord<EncLogRow>
        {
            public CliRowKey Token;

            public byte FuncCode;
        }
    }
}