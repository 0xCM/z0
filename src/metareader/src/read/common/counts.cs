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
    
    partial class MetadataRead
    {        
       internal static int MethodImplCount(in ReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.MethodImpl);

        internal static int MethodDefCountt(in ReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.MethodDef);

        internal static int MethodPtrCountt(in ReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.MethodPtr);

        internal static int TypeDefCount(in ReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.TypeDef);

        internal static int PropertyCount(in ReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.Property);

        internal static int ConstantCount(in ReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.Constant);

        internal static int FieldPtrCount(in ReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.FieldPtr);

        internal static int FieldCount(in ReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.Field);

        internal static int FieldRvaCount(in ReaderState state)
            => state.Reader.GetTableRowCount(TableIndex.FieldRva);

        internal static int TableRowCount(in ReaderState state, TableIndex table)
            => state.Reader.GetTableRowCount(table);    
    }
}