//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static memory;

    public sealed class SymLiterals : WfService<SymLiterals>
    {
        public Index<SymLiteral> Emit()
        {
            var target = Db.IndexTable(SymLiteral.TableId);
            var components = Wf.Components;
            return Emit(Wf.Components, target);
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

        public Index<SymLiteral> Emit(Index<Assembly> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<SymLiteral>(dst);
            var rows = SymbolicLiterals.symbolic(src).Sort();
            var kRows = rows.Length;
            using var writer = dst.Writer();
            var formatter = Tables.formatter<SymLiteral>(16);
            writer.WriteLine(formatter.FormatHeader());

            for(var i=0; i<kRows; i++)
                writer.WriteLine(formatter.Format(rows[i]));

            Wf.EmittedTable<SymLiteral>(flow, rows.Length);
            return rows;
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