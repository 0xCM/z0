//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Z0.Tools;

    using static Konst;
    using static z;

    ref struct Runner
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        public Runner(IWfShell wf)
        {
            Host = WfSelfHost.create(typeof(Runner));
            Wf = wf.WithHost(Host);
        }

        public void Dispose()
        {
        }

        void CloneTables()
        {
            var models = TableModels.create();
            var count = models.Count;
            var view = models.View;
            for(var i =0; i<count; i++)
            {
                ref readonly var model = ref skip(view,i);
                var clone = CilTableSpecs.clone(model);
                Wf.Rows(clone);
            }
        }


        public void EmitScripts()
        {
            var tool = DumpBin.create(Wf);
            var archive = ModuleArchive.create(EnvVars.Common.ClrCoreRoot);
            var exe = archive.NativeExeFiles().Array();
            var libs = archive.StaticLibs().Array();
            var managed = archive.Files().Where(f => f.IsManaged).Array();
            var modules = managed;


            Emit(tool.Script("dumpbin.headers",  DumpBin.CmdId.EmitHeaders, modules));
            Emit(tool.Script("dumpbin.exports",  DumpBin.CmdId.EmitExports, modules));
            Emit(tool.Script("dumpbin.relocations",  DumpBin.CmdId.EmitRelocations, modules));
            Emit(tool.Script("dumpbin.disasm",  DumpBin.CmdId.EmitAsm, modules));
            Emit(tool.Script("dumpbin.rawdata",  DumpBin.CmdId.EmitRawData, modules));
            Emit(tool.Script("dumpbin.loadConfig",  DumpBin.CmdId.EmitLoadConfig, modules));

        }

        void Emit(CmdScript script)
        {
            Wf.EmittedFile(script.GetType(), script.Length, Cmd.enqueue(Cmd.job(script.Id, script), Wf.Db()));

        }

        public void Run()
        {
            UnmanagedParserCases.create(Wf).Run();
        }

    }

    public readonly struct CmdScriptBuilder
    {

    }
}