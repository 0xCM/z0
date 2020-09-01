//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ImageTables
    {
        public struct MethodTableInfo
        {
            public uint RowCount;

            public uint RowSize;

            public bool IsParamRefSizeSmall;

            public bool IsStringHeapRefSizeSmall;

            public bool IsBlobHeapRefSizeSmall;

            public int RvaOffset;

            public int ImplFlagsOffset;

            public int FlagsOffset;

            public int NameOffset;

            public int SignatureOffset;

            public int ParamListOffset;
        }
    }
}