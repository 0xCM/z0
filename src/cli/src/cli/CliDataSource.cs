//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;

    using static Root;

    public sealed class CliDataSource : DataSource<CliDataSource>
    {
        [Op]
        public static CliTableSource<T> create<T>(Assembly src)
            where T : struct, IRecord<T>
                => new CliTableSource<T>(src);

        [Op]
        public static CliTableSource<T> create<T>(MetadataReader src)
            where T : struct, IRecord<T>
                => new CliTableSource<T>(src);

        [Op]
        public static CliTableSource<T> create<T>(MemorySeg src)
            where T : struct, IRecord<T>
                => new CliTableSource<T>(src);

        [Op]
        public static CliTableSource<T> create<T>(PEMemoryBlock src)
            where T : struct, IRecord<T>
                => new CliTableSource<T>(src);

        [Op]
        public static CliDataSource create(Assembly src)
            => new CliDataSource(src);

        [Op]
        public static CliDataSource create(MetadataReader src)
            => new CliDataSource(src);

        [Op]
        public static CliDataSource source(MemorySeg src)
            => new CliDataSource(src);

        [Op]
        public static CliDataSource create(PEMemoryBlock src)
            => new CliDataSource(src);

        public CliReader Reader {get;}

        internal CliDataSource(Assembly src)
        {
            Reader = CliReader.read(src);
        }

        internal CliDataSource(MetadataReader src)
        {
            Reader = CliReader.read(src);
        }

        internal CliDataSource(MemorySeg src)
        {
            Reader = CliReader.read(src);
        }

        internal CliDataSource(PEMemoryBlock src)
        {
            Reader = CliReader.read(src);
        }

        public CliTableSource<T> TableSouce<T>()
            where T : struct, IRecord<T>
                => new CliTableSource<T>(Reader);
    }
}