//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Seed;    
    using static MetadataRecords;
    using static Control;
    
    partial class MetaRead
    {        
       internal static int MethodImplCount(in MetaReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.MethodImpl);

        internal static int MethodDefCountt(in MetaReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.MethodDef);

        internal static int MethodPtrCountt(in MetaReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.MethodPtr);

        internal static int TypeDefCount(in MetaReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.TypeDef);

        internal static int PropertyCount(in MetaReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.Property);

        internal static int ConstantCount(in MetaReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.Constant);

        internal static int FieldPtrCount(in MetaReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.FieldPtr);

        internal static int FieldCount(in MetaReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.Field);

        internal static int FieldRvaCount(in MetaReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.FieldRva);

        internal static int TableRowCount(in MetaReaderState state, TableIndex table)
            => state.Reader.GetTableRowCount(table);    
    }
}