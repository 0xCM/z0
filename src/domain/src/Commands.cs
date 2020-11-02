//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static Konst;

    [Cmd(Code)]
    public struct EmitResDataCmd : ICmdSpec<EmitResDataCmd>
    {
        public const string Code = CmdCodes.EmitRes;

        public Assembly Source;

        public FS.FolderPath Target;

        public string Match;

        [MethodImpl(Inline)]
        public EmitResDataCmd(Assembly src, FS.FolderPath dst, string filter = null)
        {
            Source = src;
            Target = dst;
            Match = filter ?? EmptyString;
        }
    }

    /// <summary>
    /// When executed, emits an x86 opcode set from embedded resources
    /// </summary>
    [Cmd(Code)]
    public struct EmitAsmOpCodesCmd : ICmdSpec<EmitAsmOpCodesCmd>
    {
        public const string Code = CmdCodes.EmitAsmOpCodes;

        public FS.FilePath Target;

        [MethodImpl(Inline)]
        public EmitAsmOpCodesCmd(FS.FilePath dst)
            => Target = dst;
    }

    [Cmd(Code)]
    public struct EmitApiSummariesCmd : ICmdSpec<EmitApiSummariesCmd>
    {
        public const string Code = CmdCodes.EmitApiSummaries;

        public PartId[] Parts;

        public FS.FilePath Target;
    }

    [Cmd]
    public struct EmitEnumCatalogCmd : ICmdSpec<EmitEnumCatalogCmd>
    {

    }

    [Cmd]
    public struct EmitCilTablesCmd : ICmdSpec<EmitCilTablesCmd>
    {

    }

    [StructLayout(LayoutKind.Sequential), Cmd]
    public struct EmitAssemblyRefsCmd  : ICmdSpec<EmitAssemblyRefsCmd>
    {
        public Files Sources;

        public FS.FilePath Target;
    }

    [Cmd]
    public struct EmitAsmSymbolsCmd : ICmdSpec<EmitAsmSymbolsCmd>
    {

    }

    [Cmd]
    public struct EmitImageConstantsCmd : ICmdSpec<EmitImageConstantsCmd>
    {

    }

    [Cmd]
    public struct EmitBitMasksCmd : ICmdSpec<EmitBitMasksCmd>
    {

    }

    [Cmd]
    public struct EmitFieldMetadataCmd : ICmdSpec<EmitFieldMetadataCmd>
    {

    }

    [Cmd]
    public struct EmitFieldLiteralsCmd : ICmdSpec<EmitFieldLiteralsCmd>
    {

    }

    [Cmd]
    public struct EmitImageDataCmd : ICmdSpec<EmitImageDataCmd>
    {

    }

    [Cmd]
    public struct EmitImageBlobsCmd : ICmdSpec<EmitImageBlobsCmd>
    {

    }

    [Cmd]
    public struct EmitImageHeadersCmd : ICmdSpec<EmitImageHeadersCmd>
    {
        public Files Sources;

        public FS.FilePath Target;

        [MethodImpl(Inline)]
        public static EmitImageHeadersCmd specify(IWfShell wf, FS.FilePath[] src, FS.FilePath dst)
        {
            var cmd = new EmitImageHeadersCmd();
            cmd.Sources = src;
            cmd.Target = dst;
            return cmd;
        }
    }

    [Cmd]
    public struct EmitImageSummariesCmd : ICmdSpec<EmitImageSummariesCmd>
    {

    }

    [Cmd]
    public struct EmitReferenceDataCmd : ICmdSpec<EmitReferenceDataCmd>
    {

    }

    [Cmd]
    public struct EmitRenderPatternsCmd : ICmdSpec<EmitRenderPatternsCmd>
    {
        public Type Source;

        public FS.FilePath Target;

        [MethodImpl(Inline)]
        public EmitRenderPatternsCmd(Type src, FS.FilePath dst)
        {
            Source = src;
            Target = dst;
        }
    }

    [StructLayout(LayoutKind.Sequential), Cmd]
    public struct EmitToolScriptsCmd : ICmdSpec<EmitToolScriptsCmd>
    {

    }

    [Cmd]
    public struct EmitDocCommentsCmd : ICmdSpec<EmitDocCommentsCmd>
    {

    }

    partial class XCmdFactory
    {
        [MethodImpl(Inline), Op]
        public static EmitRenderPatternsCmd EmitRenderPatterns(this CmdBuilder builder, Type src)
            => new EmitRenderPatternsCmd(src, builder.Db.Doc("render.patterns", src.Name, ArchiveFileKinds.Csv));

        [MethodImpl(Inline)]
        public static EmitAsmSymbolsCmd EmitAsmSymbols(this CmdBuilder builder)
            => new EmitAsmSymbolsCmd();

        [MethodImpl(Inline), Op]
        public static EmitApiSummariesCmd EmitApiSummaries(this CmdBuilder builder)
        {
            var dst = new EmitApiSummariesCmd();

            return dst;
        }

        [MethodImpl(Inline), Op]
        public static EmitAsmOpCodesCmd EmitAsmOpCodes(this CmdBuilder builder)
            => new EmitAsmOpCodesCmd(builder.Db.RefDataPath("asm.opcodes"));

        [MethodImpl(Inline), Op]
        public static EmitResDataCmd EmitResData(this CmdBuilder builder, Assembly src, string id, string match = null)
            => new EmitResDataCmd(src, builder.Db.RefDataRoot() + FS.folder(id), match);
    }
}