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

    [ApiHost(ApiNames.XCmdCatalog)]
    public static partial class XCmdCatalog
    {
        [MethodImpl(Inline), Op]
        public static CmdBuilder CmdBuilder(this IWfShell wf)
            => new CmdBuilder(wf);

        [MethodImpl(Inline), Op]
        public static EmitApiSummariesCmd EmitApiSummaries(this ICmdCatalog wf)
            => default;

        [MethodImpl(Inline)]
        public static EmitAsmSymbolsCmd EmitAsmSymbols(this ICmdCatalog wf)
            => default;

        [MethodImpl(Inline), Op]
        public static EmitRuntimeIndexCmd EmitRuntimeIndex(this ICmdCatalog wf)
            => default;

        [MethodImpl(Inline), Op]
        public static EmitRenderPatternsCmd EmitRenderPatterns(this ICmdCatalog wf)
            => default;

        [MethodImpl(Inline), Op]
        public static EmitImageHeadersCmd EmitImageHeaders(this ICmdCatalog wf)
            => default;

        [MethodImpl(Inline), Op]
        public static EmitRenderPatternsCmd EmitRenderPatterns(this ICmdCatalog builder, Type src)
        {
            var cmd = new EmitRenderPatternsCmd();
            cmd.Source = src;
            cmd.Target = builder.Db.Doc("render.patterns", src.Name, ArchiveFileKinds.Csv);
            return cmd;
        }

        [MethodImpl(Inline)]
        public static EmitAsmSymbolsCmd EmitAsmSymbols(this CmdBuilder builder)
            => new EmitAsmSymbolsCmd();

        [MethodImpl(Inline), Op]
        public static EmitAsmOpCodesCmd EmitAsmOpCodes(this CmdBuilder builder)
            => new EmitAsmOpCodesCmd(builder.Db.RefDataPath("asm.opcodes"));

        [MethodImpl(Inline), Op]
        public static EmitResDataCmd EmitResData(this CmdBuilder builder, Assembly src, string id, string match = null)
        {
            var dst = new EmitResDataCmd();
            dst.Source = src;
            dst.Target = builder.Db.RefDataRoot() + FS.folder(id);
            dst.Match = match ?? EmptyString;
            return dst;
        }

        public static ref EmitFileListCmd WithKinds(this ref EmitFileListCmd cmd, params FS.FileExt[] ext)
        {
            cmd.FileKinds = ext;
            return ref cmd;
        }

        public static ref EmitFileListCmd LimitEmissions(this ref EmitFileListCmd cmd, uint max)
        {
            cmd.EmissionLimit = max;
            return ref cmd;
        }
    }
}