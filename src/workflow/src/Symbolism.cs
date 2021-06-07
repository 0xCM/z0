//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static core;
    using static Root;

    public sealed class Symbolism : AppService<Symbolism>
    {
        public ReadOnlySpan<SymLiteral> EmitLiterals()
            => EmitLiterals(Db.IndexTable<SymLiteral>());

        public ReadOnlySpan<SymLiteral> EmitLiterals(FS.FilePath dst)
            => EmitLiterals(Wf.Components, dst);

        /// <summary>
        /// Discovers all symbolic literals everywhere
        /// </summary>
        /// <returns></returns>
        public ReadOnlySpan<SymLiteral> DiscoverLiterals()
            => Symbols.literals(Wf.Components);

        /// <summary>
        /// Discovers the symbolic literals for parametrically-identified symbol type
        /// </summary>
        /// <typeparam name="E">The defining type</typeparam>
        public ReadOnlySpan<SymLiteral> DiscoverLiterals<E>()
            where E : unmanaged, Enum
                => Symbols.records<E>();

        /// <summary>
        /// Emits the symbolic literals for parametrically-identified symbol type
        /// </summary>
        /// <typeparam name="E">The defining type</typeparam>
        public ReadOnlySpan<SymLiteral> EmitLiterals<E>()
            where E : unmanaged, Enum
        {
            var dst = Db.Table<SymLiteral>(typeof(E).FullName);
            var flow = Wf.EmittingTable<SymLiteral>(dst);
            var rows = Symbols.records<E>();
            var count = rows.Length;
            var formatter = Tables.formatter<SymLiteral>(SymLiteral.RenderWidths);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(rows,i)));
            Wf.EmittedTable<SymLiteral>(flow, count);
            return rows;
        }

        public ReadOnlySpan<SymLiteral> EmitLiterals(Index<Assembly> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<SymLiteral>(dst);
            var rows = Symbols.literals(src);
            TableEmit(rows, SymLiteral.RenderWidths, dst);
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

        public Index<SymLiteral> LoadLiterals(FS.FilePath src)
        {
            using var reader = src.TableReader<SymLiteral>(Symbols.parse);
            var header = reader.Header.Split(Chars.Tab);
            if(header.Length != SymLiteral.FieldCount)
            {
                Wf.Error(AppMsg.FieldCountMismatch.Format(SymLiteral.FieldCount,header.Length));
                return Index<SymLiteral>.Empty;
            }

            var dst = new DataList<SymLiteral>();
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