//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Reflection;

    using Z0.Data;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct DataFlow
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<string> describe(FormatPatterns src)
            => src.Descriptions;
        
        public static FormatPatterns patterns(Type type)            
        {
            var fields = span(type.LiteralFields().Where(f => f.FieldType == typeof(string)));
            var count = fields.Length;            
            var buffer = alloc<FormatPattern>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
            {
                var field = skip(fields,i);
                var value = (string) field.GetRawConstantValue();
                seek(dst,i) = new FormatPattern(field, value);
            }
            return new FormatPatterns(buffer);
        }

        [MethodImpl(Inline)]
        public static TableFormatter<F> formatter<F>(StringBuilder dst = null, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new TableFormatter<F>(dst, delimiter);


        [MethodImpl(Inline), Op]
        public static TableArchive archive(FolderPath root)
            => new TableArchive(root);

        [MethodImpl(Inline), Op]
        public static FilePath path(FolderPath dst, IDataModel model)
            => dst + FileName.Define(model.Name, FileExtensions.Csv);

        [MethodImpl(Inline)]
        public static Table<F,T> table<F,T>(T[] rows)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
                => new Table<F,T>(rows);

        [MethodImpl(Inline)]
        public static ArchivedTable<F,T> archived<F,T>(FilePath location)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
                => new ArchivedTable<F,T>(location);

        [MethodImpl(Inline)]
        public static DataModel<K> model<K>(string name, K kind)
            where K : unmanaged, Enum
                => new DataModel<K>(name, kind);

        [MethodImpl(Inline)]
        public static DataFlow<S,T> define<S,T>(S src, T dst)
            => new DataFlow<S,T>(src,dst);

        public static DataFlow<Table<F,T>, ArchivedTable<F,T>> archive<F,T>(Table<F,T> src, FilePath dst)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
        {

            return define(src, archived<F,T>(dst));
        }        

        public static DataFlow<Table<F,T>, ArchivedTable<F,T>> archive<F,T,M,K>(Table<F,T> src, TableArchive dst, M m = default,  F f = default)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
            where M : struct, IDataModel<M,K>
            where K : unmanaged, Enum
        {
            var path = dst.ArchiveRoot + FolderName.Define(m.Name) + FileName.Define(typeof(T).Name);

            return define(src, archived<F,T>(path));
        }        

        public static DataFlow<Table<F,T>, ArchivedTable<F,T>> archive<F,T,M,K>(T[] src, TableArchive dst, M m = default,  F f = default)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
            where M : struct, IDataModel<M,K>
            where K : unmanaged, Enum
        {
            var path = dst.ArchiveRoot + FolderName.Define(m.Name) + FileName.Define(typeof(T).Name);
            var transform = formatter<F>();
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
            return define(table<F,T>(src), archived<F,T>(path));
        }        
    }
}