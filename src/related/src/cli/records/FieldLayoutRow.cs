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
        public struct FieldLayoutRow : ICliRecord<FieldLayoutRow>
        {
            public uint Offset;

            public CliRowKey Field;
        }
    }
}