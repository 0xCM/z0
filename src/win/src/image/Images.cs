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

    public readonly struct Images
    {
        public static SourceStream source(Stream src, bool virt = false)
            => SourceStream.create(src,virt);
        
        public static PEImage adapter(string path)
        {
            var reader = new StreamReader(path);
            return new PEImage(reader.BaseStream);
        }
        
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