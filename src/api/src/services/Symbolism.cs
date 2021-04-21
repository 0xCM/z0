//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static memory;

    public sealed class Symbolism : WfService<Symbolism>
    {
        public Index<SymLiteral> Emit()
            => Emit(Db.IndexTable<SymLiteral>());

        public Index<SymLiteral> Emit(FS.FilePath dst)
            => Emit(Wf.Components, dst);

        public Index<SymLiteral> Emit(Index<Assembly> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<SymLiteral>(dst);
            var rows = Symbols.literals(src);
            var view = rows.View;
            var count = rows.Length;
            var formatter = Tables.formatter<SymLiteral>(24);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(view,i)));
            Wf.EmittedTable<SymLiteral>(flow, count);
            return rows;
        }

        public void EmitSymbols<K>(string subject)
            where K : unmanaged, Enum
        {
            EmitSymbols(Symbols.symbolic<K>().View, Db.AsmCatalogPath(subject, FS.file(typeof(K).Name.ToLower(), FS.Csv)));
        }

        public void EmitSymbols<K>(ReadOnlySpan<Sym<K>> src, FS.FilePath dst)
            where K : unmanaged
        {
            var count = src.Length;
            if(count != 0)
            {
                var flow = Wf.EmittingFile(dst);
                using var writer = dst.Writer();
                writer.WriteLine(Symbols.header());
                for(var i=0; i<count; i++)
                    writer.WriteLine(skip(src,i));
                Wf.EmittedFile(flow, count);
            }
        }

        public void EmitApiClasses()
        {
            var dst = Db.IndexTable("api.classes");
            var flow = Wf.EmittingTable<SymLiteral>(dst);
            var service = Wf.ApiClassCatalog();
            var formatter = Tables.formatter<SymLiteral>();
            var classifiers = service.Classifiers();
            var literals = classifiers.SelectMany(x => x.Literals);
            var count = Tables.emit(literals, dst);
            Wf.EmittedTable(flow, count);
        }

        public Index<SymLiteral> Load(TextDoc src)
        {
            var rc = src.RowCount;
            var dst = alloc<SymLiteral>(rc);
            var parser = HexByteParser.Service;
            for(var i=0; i<rc; i++)
            {
                ref readonly var row = ref src[i];
                if(row.CellCount >= 3)
                {
                    var data = row[2];
                    var result = parser.ParseData(data);
                    if(result.Succeeded)
                    {
                        var bytes = span(result.Value);
                        var storage = 0ul;
                        ref var store = ref @as<ulong,byte>(storage);
                        var count = root.min(bytes.Length,8);
                        for(var j=0u; j<count; j++)
                            seek(store,j) = skip(bytes,j);

                        dst[i] = default;
                    }
                }
                else
                    dst[i] = default;
            }
            return dst;
        }
    }
}