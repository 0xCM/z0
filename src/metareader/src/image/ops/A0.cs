//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    using static MdR;

    partial struct ImageOps
    {
        public static void SerializeRowCounts(BlobBuilder writer, int[] rowCounts)
        {
            for (int i = 0; i < rowCounts.Length; i++)
            {
                int rowCount = rowCounts[i];
                if (rowCount > 0)
                {
                    writer.WriteInt32(rowCount);
                }
            }
        }        
    }
}