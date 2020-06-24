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
        internal static int MethodImplCount(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.MethodImpl);

        internal static int MethodDefCountt(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.MethodDef);

        internal static int MethodPtrCountt(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.MethodPtr);

        internal static int TypeDefCount(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.TypeDef);

        internal static int PropertyCount(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.Property);

        internal static int FieldPtrCount(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.FieldPtr);

        internal static int FieldCount(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.Field);

        internal static int TableRowCount(in ReaderState state, TableIndex table)
            => state.Reader.GetTableRowCount(table);    

        internal static int ConstantCount(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.Constant);

        internal static int FieldRvaCount(in ReaderState state)
            => state.Reader.GetTableRowCount(System.Reflection.Metadata.Ecma335.TableIndex.FieldRva);

    }

}