//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct TableCellSpec : ITextual
    {
        public readonly string CellName;

        public readonly Type CellType;

        [MethodImpl(Inline)]
        public static implicit operator TableCellSpec((string name, Type type) src)
            => new TableCellSpec(src.name, src.type);

        [MethodImpl(Inline)]
        public TableCellSpec(string name, Type type)
        {
            CellName = name;
            CellType = type;
        }

        public string Format()
            => string.Format("{0,-30} | {1}", CellName, CellType);

        [MethodImpl(Inline)]
        public override string ToString()
            => Format();
    }
}