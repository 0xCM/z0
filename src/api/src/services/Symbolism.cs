//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static memory;

    public sealed class Symbolism : AppService<Symbolism>
    {
        public Index<SymLiteral> EmitLiterals()
            => EmitLiterals(Db.IndexTable<SymLiteral>());

        public Index<SymLiteral> EmitLiterals(FS.FilePath dst)
            => EmitLiterals(Wf.Components, dst);

        /// <summary>
        /// Discovers all symbolic literals everywhere
        /// </summary>
        /// <returns></returns>
        public Index<SymLiteral> DiscoverLiterals()
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

        public Index<SymLiteral> EmitLiterals(Index<Assembly> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<SymLiteral>(dst);
            var rows = Symbols.literals(src);
            var view = rows.View;
            var count = rows.Length;
            var formatter = Tables.formatter<SymLiteral>(SymLiteral.RenderWidths);
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
            var literals = Wf.ApiQuery().ApiClassLiterals();
            var count = Tables.emit(literals, dst);
            Wf.EmittedTable(flow, count);
        }

        Outcome FieldCountMismatch(int actual)
            => (false, Tables.FieldCountMismatch.Format(SymLiteral.FieldCount, actual));

        Outcome Parse(TextLine src, out SymLiteral dst)
        {
            var outcome = Outcome.Success;
            var j=0;
            var cells = src.Split(Chars.Pipe);
            if(cells.Length != SymLiteral.FieldCount)
            {
                dst = default;
                return FieldCountMismatch(cells.Length);
            }

            outcome += DataParser.parse(skip(cells,j), out dst.Component);
            outcome += DataParser.parse(skip(cells,j), out dst.Type);
            outcome += DataParser.parse(skip(cells,j), out dst.Position);
            outcome += DataParser.parse(skip(cells,j), out dst.Name);
            outcome += DataParser.parse(skip(cells,j), out dst.Identity);
            outcome += DataParser.eparse(skip(cells,j), out dst.DataType);
            outcome += DataParser.parse(skip(cells,j), out dst.ScalarValue);
            outcome += DataParser.parse(skip(cells,j), out dst.Symbol);
            outcome += DataParser.parse(skip(cells,j), out dst.Description);
            outcome += DataParser.parse(skip(cells,j), out dst.Hidden);
            return outcome;
        }

        public Index<SymLiteral> LoadLiterals(FS.FilePath src)
        {
            using var reader = src.TableReader<SymLiteral>(Parse);
            var header = reader.Header.Split(Chars.Tab);
            if(header.Length != SymLiteral.FieldCount)
            {
                Wf.Error(FieldCountMismatch(header.Length).Message);
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