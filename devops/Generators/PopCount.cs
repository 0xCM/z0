//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class PopCountGen
    {
        public static byte[] GenData()
        {
            var dst = new byte[256];
            for(var i=0; i<=255; i++)
            {
                var bs = BitString.scalar(i);
                dst[i] = (byte)bs.PopCount();
            }
            return dst;
        }

        public static string GenAccessor(string propname)
            => ResourceData.GenAccessor(GenData(), propname);

        public static void GenToFile()
        {
            var filename = FileName.Define($"PopCounts.cs");
            using var dst = LogArea.App.LogWriter(filename);
            dst.WriteLine("public static class PopCountData");
            dst.WriteLine("{");
            dst.WriteLine(GenAccessor("PopCounts"));
            dst.WriteLine("}");

        }
    }
}