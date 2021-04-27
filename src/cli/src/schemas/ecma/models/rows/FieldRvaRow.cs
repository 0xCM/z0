//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct FieldRvaRow : IRecord<FieldRvaRow>
    {
        public uint Offset;

        public RowKey Field;
    }
}