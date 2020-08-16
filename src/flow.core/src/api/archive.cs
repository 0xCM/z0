//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial struct Flow
    {
        [MethodImpl(Inline)]
        public static ArchivedTable<F,T> archived<F,T>(FilePath location)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
                => new ArchivedTable<F,T>(location);

        [MethodImpl(Inline)]
        public static DataFlow<TableContent<F,T>, ArchivedTable<F,T>> archive<F,T,M,K>(TableContent<F,T> src, TableArchive dst, M m = default,  F f = default)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
            where M : struct, IDataModel<M,K>
            where K : unmanaged, Enum
        {
            var path = dst.ArchiveRoot + FolderName.Define(m.Name) + FileName.Define(typeof(T).Name);
            return Table.flow(src, archived<F,T>(path));
        }        

        public static DataFlow<TableContent<F,T>, ArchivedTable<F,T>> archive<F,T,M,K>(T[] src, TableArchive dst, M m = default,  F f = default)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
            where M : struct, IDataModel<M,K>
            where K : unmanaged, Enum
        {
            var path = dst.ArchiveRoot + FolderName.Define(m.Name) + FileName.Define(typeof(T).Name);
            var transform = Table.formatter<F>();
            var records = z.span(src);
            var count = records.Length;

            using var writer = path.Writer();
            writer.WriteLine(transform.FormatHeader());

            for(var i=0u; i<count; i++)
            {
                ref readonly var record = ref z.skip(records, i);
                var formatted = transform.FormatRow(record);
                writer.WriteLine(formatted);
            }
            return Table.flow(Table.content<F,T>(src), archived<F,T>(path));
        }        

        [MethodImpl(Inline)]
        public static DataFlow<TableContent<F,T>, ArchivedTable<F,T>> archive<F,T>(TableContent<F,T> src, FilePath dst)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
                => Table.flow(src, Flow.archived<F,T>(dst));

    }
}