//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct InterfaceImplRow : IRecord<InterfaceImplRow>
    {
        public RowKey Key;

        public token Class;

        public token Interface;
    }
}