//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Linq;

    using Z0.Tools;

    using static Konst;
    using static z;

    [CmdHost, ApiHost]
    public sealed class EmitToolScripts : CmdHost<EmitToolScripts, EmitToolScriptsCmd>
    {
        public static EmitToolScriptsCmd specify(IWfShell wf)
        {
            var cmd = new EmitToolScriptsCmd();
            return cmd;
        }

        [Op]
        public static CmdResult run(IWfShell wf, in EmitToolScriptsCmd spec)
        {
            var tool = DumpBin.create(wf);
            var archive = ModuleArchive.create(EnvVars.Common.ClrCoreRoot);
            var exe = archive.NativeExeFiles().Array();
            var libs = archive.StaticLibs().Array();
            var managed = archive.Files().Where(f => f.IsManaged).Array();
            var modules = managed;

            emit(wf, tool.Script("dumpbin.headers",  DumpBin.CmdId.EmitHeaders, modules));
            emit(wf, tool.Script("dumpbin.exports",  DumpBin.CmdId.EmitExports, modules));
            emit(wf, tool.Script("dumpbin.relocations",  DumpBin.CmdId.EmitRelocations, modules));
            emit(wf, tool.Script("dumpbin.disasm",  DumpBin.CmdId.EmitAsm, modules));
            emit(wf, tool.Script("dumpbin.rawdata",  DumpBin.CmdId.EmitRawData, modules));
            emit(wf, tool.Script("dumpbin.loadConfig",  DumpBin.CmdId.EmitLoadConfig, modules));
            return Win();
        }

        [Op]
        public static void emit(IWfShell wf, CmdScript script)
        {
            wf.EmittedFile(script.GetType(),
                script.Length,
                Cmd.enqueue(Cmd.job(script.Id, script), wf.Db()));
        }

         protected override CmdResult Execute(IWfShell wf, in EmitToolScriptsCmd spec)
            => run(wf, spec);
    }
}