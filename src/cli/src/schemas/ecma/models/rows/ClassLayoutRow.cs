//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

    [Record(CliTableKind.ClassLayout), StructLayout(LayoutKind.Sequential)]
    public struct ClassLayoutRow : IRecord<ClassLayoutRow>
    {
        public RowKey Key;

        public ushort PackingSize;

        public uint ClassSize;

        public RowKey Parent;
    }
}