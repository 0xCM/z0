//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public class Pow2Gen
    {
        const string PropName = "Pow2Bytes";

        static string ClassName => $"Pow2Data";

        static FileName OutFile => FileName.Define($"{ClassName}.cs");

        public static Span<byte> GenData<T>()
            where T : unmanaged
        {
            
            Span<ulong> dst = new ulong[64];
            for(var i=0; i< dst.Length; i++)
                dst[i] = 1ul << i;
            return dst.As<byte>();
        }

        public static string GenAccessor<T>()
            where T : unmanaged
                => ResourceData.GenAccessor(GenData<T>(), PropName);

        public static void GenToFile()
        {
            var outpath = FilePath.Empty;
            // var filename = OutFile;
            // var outpath = LogArea.App.TargetPath(filename);
            // term.print($"Generating {outpath}");

            using var dst = outpath.Writer();
            dst.WriteLine($"public static class {ClassName}");
            dst.WriteLine("{");
            dst.WriteLine(GenAccessor<ulong>());
            dst.WriteLine("}");
        }
    }
}