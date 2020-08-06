//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.IO;

    public readonly partial struct Images
    {                    
        public const byte IMAGE_SIZEOF_SHORT_NAME = 8;
        
        public static void SerializeRowCounts(BinaryWriter writer, int[] rowCounts)
        {
            for (int i = 0; i < rowCounts.Length; i++)
            {
                int rowCount = rowCounts[i];
                if (rowCount > 0)
                {
                    writer.Write(rowCount);
                }
            }
        }                
    }
}