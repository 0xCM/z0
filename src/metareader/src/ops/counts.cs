//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata.Ecma335;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using I = System.Reflection.Metadata.Ecma335.TableIndex;

    partial class PeTableReader
    {
        [MethodImpl(Inline), Op]
        public static int MethodImplCount(in ReaderState state)
            => state.Reader.GetTableRowCount(I.MethodImpl);

        [MethodImpl(Inline), Op]
        public static int MethodDefCount(in ReaderState state)
            => state.Reader.GetTableRowCount(I.MethodDef);

        [MethodImpl(Inline), Op]
        public static int MethodPtrCount(in ReaderState state)
            => state.Reader.GetTableRowCount(I.MethodPtr);

        [MethodImpl(Inline), Op]
        public static int TypeDefCount(in ReaderState state)
            => state.Reader.GetTableRowCount(I.TypeDef);

        [MethodImpl(Inline), Op]
        public static int PropertyCount(in ReaderState state)
            => state.Reader.GetTableRowCount(I.Property);

        [MethodImpl(Inline), Op]
        public static int FieldPtrCount(in ReaderState state)
            => state.Reader.GetTableRowCount(I.FieldPtr);

        [MethodImpl(Inline), Op]
        public static int FieldCount(in ReaderState state)
            => state.Reader.GetTableRowCount(I.Field);

        [MethodImpl(Inline), Op]
        public static int TableRowCount(in ReaderState state, TableIndex table)
            => state.Reader.GetTableRowCount(table);

        [MethodImpl(Inline), Op]
        public static int ConstantCount(in ReaderState state)
            => state.Reader.GetTableRowCount(I.Constant);

        [MethodImpl(Inline), Op]
        public static int FieldRvaCount(in ReaderState state)
            => state.Reader.GetTableRowCount(I.FieldRva);
    }
}