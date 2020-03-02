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

    using static Root;

    public class Pow2M1Gen
    {
        const string BasePropName = "Pow2M1Bytes";

        static string ClassName => $"Pow2M1Data";

        static FileName OutFile => FileName.Define($"{ClassName}.cs");

        public static byte[] GenData()
            => Pow2.M1Values.Select(x => x.vallue).ToSpan().AsBytes().ToArray();

        public static byte[] GenData<T>()
            where T : unmanaged
        {
            
            var values = Pow2.m1Values<T>().Select(x => x.value).ToArray().ToSpan();
            return values.AsBytes().ToArray();
        }

        public static string GenAccessor()
            => ResourceData.GenAccessor(GenData(), $"{BasePropName}{TypeIdentity.numeric<ulong>()}");

        public static string GenAccessor<T>()
            where T : unmanaged
                => ResourceData.GenAccessor(GenData<T>(), $"{BasePropName}{TypeIdentity.numeric<T>()}");

        public static void GenToFile()
        {
            var filename = OutFile;
            var outpath = LogArea.App.TargetPath(filename);
            term.print($"Generating {outpath}");

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