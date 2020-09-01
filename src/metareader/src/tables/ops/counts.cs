//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata.Ecma335;

    partial struct ReaderInternals
    {
        public static int MethodImplCount(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.MethodImpl);

        public static int MethodDefCount(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.MethodDef);

        public static int MethodPtrCount(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.MethodPtr);

        public static int TypeDefCount(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.TypeDef);

        public static int PropertyCount(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.Property);

        public static int FieldPtrCount(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.FieldPtr);

        public static int FieldCount(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.Field);

        public static int TableRowCount(in ReaderState state, TableIndex table)
            => state.Reader.GetTableRowCount(table);

        public static int ConstantCount(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.Constant);

        public static int FieldRvaCount(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.FieldRva);
    }
}