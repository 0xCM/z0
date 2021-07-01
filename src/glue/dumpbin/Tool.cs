//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public partial struct DumpBin
    {
        public Identifier ScriptId(CmdId cmd, FS.FileExt ext)
            => string.Format("{0}.{1}.{2}", Id, ext.Name, CmdSymbols[cmd].Expr);

        public Index<FS.FilePath> EmitScripts(FS.FolderPath src, FS.FolderPath dst)
        {
            var paths = root.list<FS.FilePath>();
            var archive = ModuleArchive.create(src);
            var exe = archive.NativeExeFiles();
            var lib = archive.StaticLibs();
            var dll = archive.NativeDllFiles();
            var sid = Identifier.Empty;
            var cmd = DumpBin.CmdId.None;
            var ext = FS.FileExt.Empty;

            ext = FS.Dll;

            cmd = DumpBin.CmdId.EmitHeaders;
            paths.Add(EmitScript(cmd,dll, ext, dst));

            cmd = DumpBin.CmdId.EmitAsm;
            paths.Add(EmitScript(cmd,dll,ext, dst));

            cmd = DumpBin.CmdId.EmitRawData;
            paths.Add(EmitScript(cmd,dll,ext, dst));

            cmd = DumpBin.CmdId.EmitRelocations;
            paths.Add(EmitScript(cmd,dll,ext, dst));

            cmd = DumpBin.CmdId.EmitLoadConfig;
            paths.Add(EmitScript(cmd,dll,ext, dst));

            cmd = DumpBin.CmdId.EmitExports;
            paths.Add(EmitScript(cmd,dll,ext, dst));

            return paths.ToArray();
        }

        FS.FilePath EmitScript(CmdId cmd, FileModule[] src, FS.FileExt ext, FS.FolderPath dst)
        {
            var sid = ScriptId(cmd, ext);
            var script = Script(sid, cmd, src, dst);
            var path = dst + FS.file(script.Id.Format(), FS.Cmd);
            var emitting = Wf.EmittingFile(path);
            path.Overwrite(script.Format());
            Wf.EmittedFile(emitting,1);
            return path;
        }

        readonly IWfRuntime Wf;

        [Op]
        public static DumpBin create(IWfRuntime wf)
            => new DumpBin(wf, typeof(DumpBin));

        public const string FlagPrefix = CharText.FS;

        const byte MaxVarCount = 12;

        const byte MaxVarIndex = MaxVarCount - 1;

        uint ArgIndex;

        public ToolId Id {get;}

        public ToolCmdArgs<Flag,object> Args {get;}

        Symbols<CmdId> CmdSymbols {get;}

        [MethodImpl(Inline)]
        internal DumpBin(IWfRuntime wf, ToolId id)
        {
            Wf = wf;
            Id = id;
            Args =  alloc<ToolCmdArg<Flag,object>>(MaxVarCount);
            ArgIndex = 0;
            CmdSymbols = Symbols.index<CmdId>();
        }

        public DumpBin With<T>(Flag option, T value)
        {
            if(ArgIndex < MaxVarIndex)
                Args[ArgIndex++] = Cmd.toolarg(option, (object)value);
            return this;
        }
    }
}