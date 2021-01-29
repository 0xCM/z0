//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static z;
    using static TextRules;

    public sealed class AsmCatalogEtl : WfService<AsmCatalogEtl,AsmCatalogEtl>
    {
        readonly TextDocFormat SourceFormat;

        public AsmCatalogEtl()
        {
            SourceFormat = TextDocFormat.Structured(Chars.Tab);
        }

        public void Run()
        {
            if(Resources.descriptor(Parts.Res.Assembly, ContentNames.StokeX86, out var descriptor))
            {
                Wf.Status(descriptor.Format());
                var content = Resources.utf8(descriptor);
                var srcFormat = TextDocFormat.Structured(Chars.Tab);
                var lines = Parse.lines(content).View;
                var count = lines.Length;
                var dstFormatter = Records.formatter<AsmCatalogImportRow>(42);
                var dstPath = Wf.Db().IndexTable<AsmCatalogImportRow>();
                var writer = dstPath.Writer();
                writer.WriteLine(dstFormatter.FormatHeader());
                var foundheader = false;
                for(var i=0; i<count; i++)
                {
                    ref readonly var line = ref skip(lines,i);
                    if(foundheader)
                    {
                        var row = default(AsmCatalogImportRow);
                        if(parse(line, ref row))
                        {
                            writer.WriteLine(dstFormatter.Format(row));
                        }
                    }
                    else
                    {
                        if(line.Content.Equals(AsmCatalogImportRow.SourceHeader))
                            foundheader = true;
                    }
                }
            }
            else
            {
                Wf.Error(Resources.ContentNotFound.Format(ContentNames.StokeX86));
            }
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