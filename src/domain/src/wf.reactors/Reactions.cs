//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    [ApiHost]
    readonly partial struct Reactions
    {
        [Op]
        public static FS.FilePath react(IWfShell wf, EmitHexIndexCmd cmd)
        {
            var dst = wf.Db().IndexTable("apihex.index");
            var descriptors = ApiArchives.BlockDescriptors(wf);
            var count = ApiArchives.emit(descriptors, dst);
            wf.EmittedTable<ApiCodeDescriptor>(count, dst);
            return dst;
        }

        [Op]
        public static CmdResult react(IWfShell wf, EmitRuntimeIndexCmd cmd)
        {
            var hosts = wf.Api.ApiHosts;
            var kHost = (uint)hosts.Length;
            var members  = @readonly(ApiRuntime.index(wf));
            var target = wf.Db().IndexFile("api.members");
            using var writer = target.Writer();
            var count = members.Length;
            var buffer = Buffers.text();
            for(var i=0; i<count; i++)
            {
                ApiRuntime.render(skip(members, i), buffer);
                writer.WriteLine(buffer.Emit());
            }

            wf.Status(Msg.EmittedOpIndex.Format(kHost, target));

            return Cmd.ok(cmd);
        }

        [Op]
        public static CmdResult react(IWfShell wf, ListApiHexFilesCmd cmd)
        {
            var archive = ApiArchives.hex(wf);
            var files = archive.List();
            wf.Status(string.Format("Discovered {0} files in {1}", files.Count, archive.Root));
            z.iter(archive.List().Storage, file => wf.Status(file));
            return Cmd.ok(cmd);
        }

        [Op]
        public static FS.FilePath react(IWfShell wf, EmitAsmOpCodesCmd cmd)
        {
            var data = AsmOpCodes.dataset().Entries;
            var count = data.Count;
            var view = data.View;
            var formatter = AsmOpCodes.formatter<AsmOpCodeField>();
            var rowbuffer = alloc<AsmOpCodeRow>(count);
            var rows = span(rowbuffer);
            using var dst = cmd.Target.Writer();
            formatter.EmitHeader(false);
            dst.WriteLine(formatter.Render());
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(view,i);
                seek(rows,i) = record;

                AsmOpCodes.format(record, formatter);
                dst.WriteLine(formatter.Render());
            }
            return  cmd.Target;
        }

        public static CmdResult react(IWfShell wf, EmitAsmSymbolsCmd cmd)
        {
            const string RenderPattern = "{0,-20} | {1,-20} | {2,-20} | {3}";
            const string TableId = "asm.mnemonics";

            var target = wf.Db().RefDataPath(TableId);
            var symbols = AsmOpCodes.symbols();
            var src = symbols.Mnemonics.View;
            var count = src.Length;
            var fields = Enums.literals<SymbolAspectKind>();
            var symType = typeof(Asm.Mnemonic);
            var cellType = typeof(ushort);
            var header = text.format(RenderPattern, SymbolAspectKind.SymbolValue, SymbolAspectKind.SymbolType, SymbolAspectKind.CellValue, SymbolAspectKind.CellType);
            using var writer = target.Writer();
            writer.WriteLine(header);
            for(var i=0u; i<count; i++)
            {
                ref readonly var symbol = ref skip(src,i);
                var rendered = text.format(RenderPattern, symbol.Value, symType.Name, symbol.Cell, cellType.Name);
                writer.WriteLine(rendered);
            }
            return Cmd.ok(cmd);
        }

        public static FS.FilePath react(IWfShell wf, LocateImagesCmd cmd)
        {
            var records = rows(ProcessImages.locate());
            var count = records.Length;
            var spec = Table.renderspec2<LocatedImageRow.Fields>();
            using var writer = cmd.Target.Writer();
            writer.WriteLine(spec.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(records,i);
                writer.Write(row.ImageName.Format().PadRight(spec[0].Width));
                writer.Write(row.PartId.Format().PadRight(spec[1].Width));
                writer.Write(row.EntryAddress.Format().PadRight(spec[2].Width));
                writer.Write(row.BaseAddress.Format().PadRight(spec[3].Width));
                writer.Write(row.EndAddress.Format().PadRight(spec[4].Width));
                writer.Write(row.Size.Format().PadRight(spec[5].Width));
                writer.Write(row.Gap.Format().PadRight(spec[6].Width));
                writer.WriteLine();
            }
            return cmd.Target;
        }

        [Op]
        static ReadOnlySpan<LocatedImageRow> rows(LocatedImages src)
        {
            var count = src.Count;
            var images = src.View;
            var summaries = span<LocatedImageRow>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var image = ref skip(images, i);
                ref var summary = ref seek(summaries,i);
                var name = image.Name;
                summary.ImageName = name;
                fill(image, ref summary);

                if(i != 0)
                {
                    ref readonly var prior = ref skip(images, i - 1);
                    var gap = (ulong)(image.BaseAddress - prior.EndAddress);
                    summary.Gap = gap;
                }
            }

            return summaries;
        }

        [MethodImpl(Inline), Op]
        static void fill(in LocatedImage src, ref LocatedImageRow dst)
        {
            dst.ImageName = src.Name;
            dst.PartId = src.PartId;
            dst.EntryAddress = src.EndAddress;
            dst.BaseAddress = src.BaseAddress;
            dst.EndAddress = src.EndAddress;
            dst.Size = src.Size;
        }
    }
}