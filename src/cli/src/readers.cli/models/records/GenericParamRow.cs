//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct GenericParamRow : ICliRecord<GenericParamRow>
        {
            public ushort Number;

            public ushort Flags;

            public CliRowKey Owner;

            public StringIndex Name;
        }
    }
}