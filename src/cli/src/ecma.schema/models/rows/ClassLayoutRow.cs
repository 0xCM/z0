//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct ClassLayoutRow : IRecord<ClassLayoutRow>
    {
        public RowKey Key;

        public ushort PackingSize;

        public uint ClassSize;

        public token Parent;
    }
}