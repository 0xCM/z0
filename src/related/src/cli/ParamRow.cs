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
        [StructLayout(LayoutKind.Sequential)]
        public struct ParamRow : IRecord<ParamRow>
        {
            public CliRowKey Key;

            public ushort Flags;

            public ushort Sequence;

            public StringIndex Name;
        }
    }
}