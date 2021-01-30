//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

    using static Part;
    using static memory;
    using static TextRules;
    using static AsmExpr;

    public sealed class AsmCatalogEtl : WfService<AsmCatalogEtl,AsmCatalogEtl>
    {
        readonly TextDocFormat SourceFormat;

        readonly Index<AsmCatalogImportRow> RowBuffer;

        const uint MaxRowCount = 2500;

        public AsmCatalogEtl()
        {
            SourceFormat = TextDocFormat.Structured(Chars.Tab);
            RowBuffer = alloc<AsmCatalogImportRow>(MaxRowCount);
        }

        public uint ImportRowCount {get; private set;}

        public Index<AsmMnemonicExpr> Mnemonics()
        {
            var mnemonics = root.hashset<AsmMnemonicExpr>();
            var rows = ImportedRows();
            var count = rows.Length;
            var parser = AsmSigParser.create(Wf);
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows,i);
                var sig = AsmExpr.sig(row.Instruction);
                if(parser.ParseMnemonic(sig, out var mnemonic))
                    mnemonics.Add(mnemonic);
            }
            return mnemonics.ToArray();
        }

        public ReadOnlySpan<AsmCatalogImportRow> ImportedRows()
        {
            if(ImportRowCount != 0)
                return slice(RowBuffer.View,0, ImportRowCount);
            else
                return ImportRows();
        }

        ReadOnlySpan<AsmCatalogImportRow> ImportRows()
        {
            if(Resources.descriptor(Parts.Res.Assembly, ContentNames.AsmCatalog, out var descriptor))
            {
                var content = Resources.utf8(descriptor);
                var srcFormat = TextDocFormat.Structured(Chars.Tab);
                var foundheader = false;
                var lines = Parse.lines(content).View;
                var count = lines.Length;
                var buffer = RowBuffer.Edit;
                ref var dst = ref first(buffer);
                var j = 0u;
                for(var i=0; i<count; i++)
                {
                    ref readonly var line = ref skip(lines,i);
                    if(foundheader)
                    {
                        var row = default(AsmCatalogImportRow);
                        if(parse(line, ref row))
                            seek(dst,j++) = row;
                    }
                    else
                    {
                        if(line.Content.Equals(AsmCatalogImportRow.SourceHeader))
                            foundheader = true;
                    }
                }
                ImportRowCount = j;
                return slice(buffer,0, ImportRowCount);
            }
            else
                return Index<AsmCatalogImportRow>.Empty;
        }

        public void Run()
        {
            var dst = Wf.Db().IndexTable<AsmCatalogImportRow>();
            var flow = Wf.EmittingTable<AsmCatalogImportRow>(dst);
            var imports = ImportedRows();
            var count = Records.emit(imports, dst, 42);
            Wf.EmittedTable<AsmCatalogImportRow>(flow, count, dst);
        }

        bool parse(in TextLine src, ref AsmCatalogImportRow dst)
        {
            if(Parse.row(src, SourceFormat, out var row))
            {
                if(row.CellCount == 15)
                {
                    var cells = row.Cells.View;
                    var i = 0;
                    dst.SourceLine = src.LineNumber;
                    dst.OpCode = skip(cells, i++);
                    dst.Instruction = skip(cells, i++);
                    dst.EncodingKind = skip(cells, i++);
                    dst.Properties = skip(cells, i++);
                    dst.ImplicitRead = skip(cells, i++);
                    dst.ImplicitWrite = skip(cells, i++);
                    dst.ImplicitUndef = skip(cells, i++);
                    dst.Useful = skip(cells, i++);
                    dst.Protected = skip(cells, i++);
                    dst.Mode64 = skip(cells, i++);
                    dst.LegacyMode = skip(cells, i++);
                    dst.Cpuid = skip(cells, i++);
                    dst.AttMnemonic = skip(cells, i++);
                    dst.Preferred = skip(cells, i++);
                    dst.Description = skip(cells, i++);
                    return true;
                }
            }

            return false;
        }
    }
}