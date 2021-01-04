//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct GenericParamRow : IRecord<GenericParamRow>
    {
        public RowKey Key;

        public ushort Number;

        public ushort Flags;

        public int Owner;

        public FK<string> Name;
    }
}