//-----------------------------------------------------------------------------
// Copyright   :  Microsoft
// License     : MIT via .Net Foundation
// Extracted from System.Reflection.MetadataReader library code
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    partial class MetadataFlags
    {
        internal static class TokenTypeIds
        {
            internal const int RowIdBitCount = 24;

            internal const uint RIDMask = (1 << RowIdBitCount) - 1;

            internal static bool IsValidRowId(uint rowId)
            {
                return (rowId & ~RIDMask) == 0;
            }
        }                
    }
}