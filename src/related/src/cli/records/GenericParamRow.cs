//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record(CliTableKind.GenericParam), StructLayout(LayoutKind.Sequential)]
        public struct GenericParamRow : ICliRecord<GenericParamRow>
        {
            public CliRowKey Key;

            public ushort Number;

            public ushort Flags;

            public CliRowKey Owner;

            public StringIndex Name;
        }
    }
}