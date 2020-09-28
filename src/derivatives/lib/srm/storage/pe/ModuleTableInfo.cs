//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
 
    public struct ModuleTableInfo
    {            
        public uint RowCount {get;}

        public uint RowSize {get;}

        public bool IsStringHeapRefSizeSmall;

        public bool IsGUIDHeapRefSizeSmall;

        public int GenerationOffset;

        public int NameOffset;

        public int MVIdOffset;

        public int EnCIdOffset;

        public int EnCBaseIdOffset;            
    } 
}