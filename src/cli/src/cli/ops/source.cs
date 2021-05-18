//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection;
    using System.Reflection.PortableExecutable;
    using Microsoft.CodeAnalysis;

    using static Part;
    using static core;

    partial struct Cli
    {
        [Op]
        public static CliTableSource<T> source<T>(Assembly src)
            where T : struct, IRecord<T>
                => new CliTableSource<T>(src);

        [Op]
        public static CliTableSource<T> source<T>(MetadataReader src)
            where T : struct, IRecord<T>
                => new CliTableSource<T>(src);

        [Op]
        public static CliTableSource<T> source<T>(MemorySeg src)
            where T : struct, IRecord<T>
                => new CliTableSource<T>(src);

        [Op]
        public static CliTableSource<T> source<T>(PEMemoryBlock src)
            where T : struct, IRecord<T>
                => new CliTableSource<T>(src);

        [Op]
        public static CliDataSource source(Assembly src)
            => new CliDataSource(src);

        [Op]
        public static CliDataSource source(MetadataReader src)
            => new CliDataSource(src);

        [Op]
        public static CliDataSource source(MemorySeg src)
            => new CliDataSource(src);

        [Op]
        public static CliDataSource source(PEMemoryBlock src)
            => new CliDataSource(src);
    }
}