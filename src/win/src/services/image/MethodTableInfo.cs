//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    public readonly struct MethodTableInfo
    {
        public uint RowCount {get;}

        public uint RowSize {get;}

        public readonly bool IsParamRefSizeSmall;
        
        public readonly bool IsStringHeapRefSizeSmall;
        
        public readonly bool IsBlobHeapRefSizeSmall;
        
        public readonly int RvaOffset;
        
        public readonly int ImplFlagsOffset;
        
        public readonly int FlagsOffset;
        
        public readonly int NameOffset;
        
        public readonly int SignatureOffset;
        
        public readonly int ParamListOffset;
    }    
}