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

    using static zfunc;

    public class Pow2M1Gen
    {
        const string BasePropName = "Pow2M1Bytes";

        static string ClassName => $"Pow2M1Data";

        static FileName OutFile => FileName.Define($"{ClassName}.cs");

        public static byte[] GenData()
            => Pow2M1.All.Select(x => x.p).ToSpan().AsBytes().ToArray();

        public static byte[] GenData<T>()
            where T : unmanaged
        {
            
            var values = Pow2M1.Values<T>().Select(x => x.p).ToArray().ToSpan();
            return values.AsBytes().ToArray();
        }

        public static string GenAccessor()
            => InlineData.GenAccessor(GenData(), $"{BasePropName}{moniker<ulong>()}");

        public static string GenAccessor<T>()
            where T : unmanaged
                => InlineData.GenAccessor(GenData<T>(), $"{BasePropName}{moniker<T>()}");

        public static void GenToFile()
        {
            var filename = OutFile;
            var outpath = LogArea.App.TargetPath(filename);
            print($"Generating {outpath}");

            using var dst = LogArea.App.LogWriter(filename);
            dst.WriteLine($"public static class {ClassName}");
            dst.WriteLine("{");
            dst.WriteLine(GenAccessor<sbyte>());
            dst.WriteLine(GenAccessor<byte>());
            dst.WriteLine(GenAccessor<short>());
            dst.WriteLine(GenAccessor<ushort>());
            dst.WriteLine(GenAccessor<int>());
            dst.WriteLine(GenAccessor<uint>());
            dst.WriteLine(GenAccessor<long>());
            dst.WriteLine(GenAccessor<ulong>());
            dst.WriteLine("}");

        }
    }

}