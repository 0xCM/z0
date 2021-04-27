//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    using static Relations;

    [StructLayout(LayoutKind.Sequential)]
    public struct ParamRow : IRecord<ParamRow>
    {
        public RowKey Key;

        public ushort Flags;

        public ushort Sequence;

        public StringIndex Name;
    }
}