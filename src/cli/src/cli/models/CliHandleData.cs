//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct CliHandleData
    {
        public uint RowId {get;}

        public CliTableKind Table {get;}

        [MethodImpl(Inline)]
        public CliHandleData(CliTableKind table, uint row)
        {
            RowId = row;
            Table = table;
        }

        public string Format()
            => string.Format("{0:X2}:{1:x6}", (byte)Table, RowId);

        public override string ToString()
            => Format();
    }
}