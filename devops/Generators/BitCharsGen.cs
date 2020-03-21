//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;

    public class BitCharsGen
    {
        const string PropName = "BitChars";

        static string ClassName => $"{PropName}Data";

        static FileName OutFile => FileName.Define($"{ClassName}.cs");

        public static byte[] GenData()
        {
            const byte Off = (byte)'0';
            const byte On = (byte)'1';


            var dst = new byte[16*256];
            var value = (byte)0;

            for(var i=0; i<dst.Length; i+=16, value++)
            {
                for(var j=0; j<8; j++)
                    dst[i + j*2] = bit.test(value,j) ? On : Off;
                
            }
            return dst;
        }

        public static string GenAccessor(string propname)
            => ResourceData.GenAccessor(GenData(), propname, seglen: 16);

        public static void GenToFile()
        {
            // var filename = OutFile;
            // var outpath = LogArea.App.TargetPath(filename);
            // term.print($"Generating {outpath}");

            var outpath = FilePath.Empty;

            using var dst = outpath.Writer();
            
            dst.WriteLine($"public static class {ClassName}");
            dst.WriteLine("{");
            dst.WriteLine(GenAccessor(PropName));
            dst.WriteLine("}");
        }
    }
}