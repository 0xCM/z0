//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct Images
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct GenericParamRow : IRecord<GenericParamRow>
        {
            public ushort Number;

            public ushort Flags;

            public RowKey Owner;

            public StringIndex Name;
        }
    }
}