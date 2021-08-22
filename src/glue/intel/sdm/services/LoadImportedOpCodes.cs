//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static core;
    using static SdmParsers;
    using static SdmModels;

    partial class IntelSdm
    {
        /// <summary>
        /// Distills <see cref='AsmForm'/> values from a <see cref='SdmOpCodeDetail'/> sequence
        /// </summary>
        /// <param name="src">The data source</param>
        [Op]
        static Index<AsmForm> forms(ReadOnlySpan<SdmOpCodeDetail> src)
        {
            var count = src.Length;
            var buffer = alloc<AsmForm>(count);
            ref var dst = ref first(buffer);

            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(src,i);
                ref var opcode = ref SdmModels.opcode(record, out _);
                ref var form = ref seek(dst,i);
                form = asm.form(
                    asm.sig(opcode.Mnemonic.Format(), SdmModels.operands(opcode)),
                    asm.opcode((ushort)opcode.OpCodeId, opcode.Expr)
                    );
            }
            return buffer;
        }

        public ReadOnlySpan<AsmForm> DeriveAsmForms(FS.FilePath src)
        {
            const string Pattern = "{0,-80} | {1}:{2} | {3}:{4}";
            var result = LoadImportedOpCodes(src, out var details);
            if(result.Fail)
            {
                Error(result.Message);
                return default;
            }

            var ws = Ws.Tables();
            var dst = ws.Root + FS.file("asm.forms", FS.Txt);
            using var writer = dst.UnicodeWriter();
            var forms = IntelSdm.forms(details).View;
            var count = forms.Length;

            for(var i=0; i<count; i++)
                writer.WriteLine(skip(forms,i));

            return forms;
        }


        public Outcome LoadImportedOpCodes(FS.FilePath src, out SdmOpCodeDetail[] dst)
        {
            var result = Outcome.Success;
            dst = sys.empty<SdmOpCodeDetail>();
            var lines = src.ReadLines(TextEncodingKind.Unicode).View;
            result = TextGrids.load(lines, out var grid);
            if(result.Fail)
                return result;
            var count = grid.RowCount;

            dst = alloc<SdmOpCodeDetail>(count);
            result = AsmParser.parse(grid, dst);
            if(result.Fail)
                return result;

            return result;
        }

        string VolumeMarker(byte vol)
            => string.Format("Vol. {0}", vol);

        Strings VolumeMarkers(byte min, byte max)
        {
            var dst = Strings.create();
            for(var i=min; i<=max; i++)
                dst.Add(VolumeMarker(i));
            return dst;
        }

        public Outcome EmitTocRecords()
        {
            var result = Outcome.Success;
            var flow = Wf.Running();
            var vols = VolumeMarkers(1,4);
            var src = TocImportPath();
            if(!src.Exists)
            {
                result = (false,FS.missing(src));
                Wf.Error(result.Message);
                return result;
            }

            var encoding = TextEncodingKind.Unicode;
            using var reader = src.LineReader(encoding);
            var buffer = text.buffer();
            var dst = ProcessLog("toc.combined");
            using var writer = dst.Writer(encoding);
            var cn = ChapterNumber.Empty;
            var tn = TableNumber.Empty;
            var title = TocTitle.Empty;
            var entry = TocEntry.Empty;
            var entries = list<TocEntry>();
            var _snbuffer = span<SectionNumber>(1);
            ref var _sn = ref first(_snbuffer);
            _sn = SectionNumber.Empty;
            while(reader.Next(out var line))
            {
                var content = line.Content;
                var number = line.LineNumber;
                if(vols.CoversAny(content))
                {
                    writer.WriteLine(string.Format("{0}:{1}", number, content));
                    continue;
                }

                if(parse(content, out cn))
                {
                    render(number, cn, buffer);
                    writer.WriteLine(buffer.Emit());
                    continue;
                }

                if(parse(content, out SectionNumber sn))
                {
                    _sn = sn;
                    render(number, _sn, buffer);
                    writer.WriteLine(buffer.Emit());
                    continue;
                }

                if(parse(content, out title))
                {
                    entry = toc(_sn, title);
                    entries.Add(entry);
                    render(number, entry, buffer);
                    writer.WriteLine(buffer.Emit());
                    continue;
                }

                if(parse(content, out tn))
                {
                    render(number, tn, buffer);
                    writer.WriteLine(buffer.Emit());
                    continue;
                }
            }

            var rowcount = TableEmit(entries.ViewDeposited(), TocEntryTable());
            Wf.Ran(flow, string.Format("Collected {0} toc entries", rowcount));
            return result;
        }
    }
}