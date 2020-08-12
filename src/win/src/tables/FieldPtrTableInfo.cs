//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
 
    [Table]
    public readonly struct FieldPtrTableInfo
    {
        public uint RowCount {get;}

        public uint RowSize {get;}
        
        public readonly bool IsFieldTableRowRefSizeSmall;
        
        public readonly int FieldOffset;            
    }             
}