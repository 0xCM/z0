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
        [StructLayout(LayoutKind.Sequential)]
        public struct ParamRow : ICliRecord<ParamRow,Param>
        {
            public CliRowKey<Param> Key;

            public ushort Flags;

            public ushort Sequence;

            public StringIndex Name;
        }
    }
}