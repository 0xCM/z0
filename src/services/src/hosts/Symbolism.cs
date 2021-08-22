//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static core;

    public sealed class Symbolism : AppService<Symbolism>
    {
        public ReadOnlySpan<SymLiteralRow> EmitLiterals()
            => EmitLiterals(Db.IndexTable<SymLiteralRow>());

        public ReadOnlySpan<SymLiteralRow> EmitLiterals(FS.FilePath dst)
            => EmitLiterals(Wf.Components, dst);

        /// <summary>
        /// Discovers all symbolic literals everywhere
        /// </summary>
        /// <returns></returns>
        public ReadOnlySpan<SymLiteralRow> DiscoverLiterals()
            => Symbols.literals(Wf.Components);

        /// <summary>
        /// Discovers the symbolic literals for parametrically-identified symbol type
        /// </summary>
        /// <typeparam name="E">The defining type</typeparam>
        public ReadOnlySpan<SymLiteralRow> DiscoverLiterals<E>()
            where E : unmanaged, Enum
                => Symbols.literals<E>();

        /// <summary>
        /// Emits the symbolic literals for parametrically-identified symbol type
        /// </summary>
        /// <typeparam name="E">The defining type</typeparam>
        public ReadOnlySpan<SymLiteralRow> EmitLiterals<E>()
            where E : unmanaged, Enum
        {
            var dst = Db.Table<SymLiteralRow>(typeof(E).FullName);
            return EmitLiterals<E>(dst);
        }

        public ReadOnlySpan<SymLiteralRow> EmitLiterals<E>(FS.FilePath dst)
            where E : unmanaged, Enum
        {
            //var dst = Db.Table<SymLiteralRow>(typeof(E).FullName);
            var flow = Wf.EmittingTable<SymLiteralRow>(dst);
            var rows = Symbols.literals<E>();
            var count = rows.Length;
            var formatter = Tables.formatter<SymLiteralRow>(SymLiteralRow.RenderWidths);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(rows,i)));
            Wf.EmittedTable<SymLiteralRow>(flow, count);
            return rows;
        }

        public ReadOnlySpan<SymLiteralRow> EmitLiterals(Index<Assembly> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<SymLiteralRow>(dst);
            var rows = Symbols.literals(src);
            TableEmit(rows, SymLiteralRow.RenderWidths, dst);
            return rows;
        }

        public void EmitSymbols<K>(FS.FolderPath dir)
            where K : unmanaged, Enum
        {
            EmitSymbols(Symbols.index<K>().View, dir);
        }

        public void EmitSymbols<K>(ReadOnlySpan<Sym<K>> src, FS.FolderPath dir)
            where K : unmanaged
        {
            var dst  = dir + FS.file(typeof(K).Name.ToLower(), FS.Csv);
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

        public Index<SymLiteralRow> LoadLiterals(FS.FilePath src)
        {
            using var reader = src.TableReader<SymLiteralRow>(DataParser.parse);
            var header = reader.Header.Split(Chars.Tab);
            if(header.Length != SymLiteralRow.FieldCount)
            {
                Wf.Error(AppMsg.FieldCountMismatch.Format(SymLiteralRow.FieldCount,header.Length));
                return Index<SymLiteralRow>.Empty;
            }

            var dst = new DataList<SymLiteralRow>();
            while(!reader.Complete)
            {
                var outcome = reader.ReadRow(out var row);
                if(!outcome)
                {
                    Wf.Error(outcome.Message);
                    break;
                }
                dst.Add(row);
            }

            return dst.Emit();
        }
    }
}