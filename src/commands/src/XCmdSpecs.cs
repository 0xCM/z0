//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    using api = Cmd;

    [ApiHost]
    public static partial class XCmdSpecs
    {
        [MethodImpl(Inline), Op]
        public static CmdBuilder CmdBuilder(this IWfShell wf)
            => new CmdBuilder(wf);

        [MethodImpl(Inline), Op]
        public static ICmdCatalog CmdSpecs(this IWfShell wf)
            => api.catalog(wf);

        [MethodImpl(Inline), Op]
        public static EmitApiSummariesCmd EmitApiSummaries(this ICmdCatalog wf)
            => default;

        [MethodImpl(Inline), Op]
        public static EmitResourceDataCmd EmitResourceData(this ICmdCatalog wf)
            => default;

        [MethodImpl(Inline), Op]
        public static EmitAsmMnemonicsCmd EmitAsmSymbols(this ICmdCatalog wf)
            => default;

        [MethodImpl(Inline), Op]
        public static EmitAsmMnemonicsCmd EmitHexIndex(this ICmdCatalog wf)
            => default;

        [MethodImpl(Inline), Op]
        public static EmitRuntimeIndexCmd EmitRuntimeIndex(this ICmdCatalog wf)
            => default;

        [MethodImpl(Inline), Op]
        public static EmitRenderPatternsCmd EmitRenderPatterns(this ICmdCatalog wf)
            => default;


        [MethodImpl(Inline), Op]
        public static EmitAsmOpCodesCmd EmitAsmOpCodes(this ICmdCatalog wf)
            => default;

        [Op]
        public static EmitRenderPatternsCmd EmitRenderPatterns(this ICmdCatalog builder, Type src)
        {
            var cmd = new EmitRenderPatternsCmd();
            cmd.Source = src;
            cmd.Target = builder.Db.Doc("render.patterns", src.Name, FileExtensions.Csv);
            return cmd;
        }

        [Op]
        public static ListFilesCmd ListFiles(this CmdBuilder builder, string name, FS.FolderPath src, params FS.FileExt[] kinds)
        {
            var cmd = new ListFilesCmd();
            cmd.ListName = name;
            cmd.SourceDir = src;
            cmd.Extensions = kinds;
            cmd.TargetPath = builder.Db.List(name, FileExtensions.Csv);
            cmd.ListFormat = ListFormatKind.Markdown;
            return cmd;
        }

        [MethodImpl(Inline), Op]
        public static EmitAsmMnemonicsCmd EmitAsmMnemonics(this CmdBuilder builder)
            => new EmitAsmMnemonicsCmd();

        [MethodImpl(Inline), Op]
        public static EmitAsmOpCodesCmd EmitAsmOpCodes(this CmdBuilder builder, FS.FilePath? dst = null)
        {
            var cmd = new EmitAsmOpCodesCmd();
            cmd.Target = dst ?? builder.Db.RefDataPath("asm.opcodes");
            return cmd;
        }


        [MethodImpl(Inline), Op]
        public static EmitResourceDataCmd EmitResourceData(this CmdBuilder builder, Assembly src, string id, string match = null)
        {
            var dst = new EmitResourceDataCmd();
            dst.Source = src;
            dst.Target = builder.Db.RefDataRoot() + FS.folder(id);
            dst.Match = match ?? EmptyString;
            return dst;
        }

        public static ref ListFilesCmd WithExt(this ref ListFilesCmd cmd, params FS.FileExt[] ext)
        {
            cmd.Extensions = ext;
            return ref cmd;
        }

        public static ref ListFilesCmd WithFormat(this ref ListFilesCmd cmd, ListFormatKind format)
        {
            cmd.ListFormat = format;
            return ref cmd;
        }

        public static ref ListFilesCmd WithLimit(this ref ListFilesCmd cmd, uint max)
        {
            cmd.EmissionLimit = max;
            return ref cmd;
        }
    }
}