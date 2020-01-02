//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

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
            // var values = Pow2.Values<T>().Select(x => x.p).ToArray().ToSpan();
            // return values.AsBytes().ToArray();
        }

        public static string GenAccessor<T>()
            where T : unmanaged
                => InlineData.GenAccessor(GenData<T>(), PropName);

        public static void GenToFile()
        {
            var filename = OutFile;
            var outpath = LogArea.App.TargetPath(filename);
            print($"Generating {outpath}");

            using var dst = LogArea.App.LogWriter(filename);
            dst.WriteLine($"public static class {ClassName}");
            dst.WriteLine("{");
            dst.WriteLine(GenAccessor<ulong>());
            dst.WriteLine("}");
        }

    }

}