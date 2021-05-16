//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection.Metadata;

    using static Part;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct CliHandleData : ITextual, IComparable<CliHandleData>, IEquatable<CliHandleData>
    {
        public uint RowId {get;}

        public CliTableKind Table {get;}

        [MethodImpl(Inline)]
        public CliHandleData(CliTableKind table, uint row)
        {
            RowId = row;
            Table = table;
        }

        [MethodImpl(Inline)]

        public bool Equals(CliHandleData src)
            => Table == src.Table && RowId == src.RowId;

        [MethodImpl(Inline)]
        public int CompareTo(CliHandleData src)
            => Table != src.Table ? ((byte)Table).CompareTo((byte)src.Table) : RowId.CompareTo(src.RowId);

        public string Format()
            => string.Format("{0:X2}:{1:x6}", (byte)Table, RowId);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Handle(CliHandleData src)
            => CliReader.handle(src);

        [MethodImpl(Inline)]
        public static implicit operator CliHandleData(Handle src)
            => CliReader.data(src);
    }
}