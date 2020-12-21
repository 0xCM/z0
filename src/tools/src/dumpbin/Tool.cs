//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    [ApiHost]
    public partial struct DumpBin
    {
        public void EmitScripts()
        {
            var tool = DumpBin.create(Wf);
            var path = FS.FolderPath.Empty;
            var archive = FileArchives.modules(path);
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
        readonly IWfShell Wf;

        public FS.FolderPath OutputDir {get;}

        [Op]
        public static DumpBin create(IWfShell wf)
            => new DumpBin(wf, typeof(DumpBin));

        public const string FlagPrefix = data.tchars.FS;

        const byte MaxVarCount = 12;

        const byte MaxVarIndex = MaxVarCount - 1;

        uint ArgIndex;

        public ToolId Id {get;}

        public CmdArgs<Flag,object> Args {get;}

        [MethodImpl(Inline)]
        internal DumpBin(IWfShell wf, ToolId id)
        {
            Wf = wf;
            Id = id;
            Args =  alloc<CmdArg<Flag,object>>(MaxVarCount);
            ArgIndex = 0;
            OutputDir = Wf.Db().Output(Id);
        }

        public DumpBin With<T>(Flag option, T value)
        {
            if(ArgIndex < MaxVarIndex)
                Args[ArgIndex++] = Cmd.arg(option, (object)value);
            return this;
        }
    }
}