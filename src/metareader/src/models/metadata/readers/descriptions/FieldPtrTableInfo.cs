//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
 
    public readonly partial struct MdR
    {   
        public readonly struct FieldPtrTableInfo : ISourceFacets<FieldPtrTableInfo>
        {
            public uint RowCount {get;}

            public uint RowSize {get;}
            
            public readonly bool IsFieldTableRowRefSizeSmall;
            
            public readonly int FieldOffset;            
        }             
    }
}