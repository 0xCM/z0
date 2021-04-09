//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public partial struct DumpBin
    {
        public void EmitScripts()
        {
            var tool = DumpBin.create(Wf);
            var path = FS.FolderPath.Empty;
            var archive = ModuleArchive.create(path);
            var exe = archive.NativeExeFiles().Array();
            var libs = archive.StaticLibs().Array();
            // var managed = archive.Files().Where(f => f.IsManaged).Array();
            // var modules = managed;

            // Emit(tool.Script("dumpbin.headers",  DumpBin.CmdId.EmitHeaders, modules));
            // Emit(tool.Script("dumpbin.exports",  DumpBin.CmdId.EmitExports, modules));
            // Emit(tool.Script("dumpbin.relocations",  DumpBin.CmdId.EmitRelocations, modules));
            // Emit(tool.Script("dumpbin.disasm",  DumpBin.CmdId.EmitAsm, modules));
            // Emit(tool.Script("dumpbin.rawdata",  DumpBin.CmdId.EmitRawData, modules));
            // Emit(tool.Script("dumpbin.loadConfig",  DumpBin.CmdId.EmitLoadConfig, modules));

        }
        readonly IWfRuntime Wf;

        public FS.FolderPath OutputDir {get;}

        [Op]
        public static DumpBin create(IWfRuntime wf)
            => new DumpBin(wf, typeof(DumpBin));

        public const string FlagPrefix = CharText.FS;

        const byte MaxVarCount = 12;

        const byte MaxVarIndex = MaxVarCount - 1;

        uint ArgIndex;

        public ToolId Id {get;}

        public ToolCmdArgs<Flag,object> Args {get;}

        [MethodImpl(Inline)]
        internal DumpBin(IWfRuntime wf, ToolId id)
        {
            Wf = wf;
            Id = id;
            Args =  alloc<ToolCmdArg<Flag,object>>(MaxVarCount);
            ArgIndex = 0;
            OutputDir = Wf.Db().ToolOutDir(Id);
        }

        public DumpBin With<T>(Flag option, T value)
        {
            if(ArgIndex < MaxVarIndex)
                Args[ArgIndex++] = ToolArgs.arg(option, (object)value);
            return this;
        }
    }
}