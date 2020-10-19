//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using Z0.Tools;

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

/*
dumpbin /DISASM:NOBYTES /OUT:j:\database\tools\DumpBin\output\coreclr.disasm.nobytes.asm J:\lang\net\runtime\artifacts\tests\coreclr\Windows_NT.x64.Debug\Tests\Core_Root\coreclr.dll
dumpbin /RELOCATIONS /OUT:j:\database\tools\DumpBin\output\coreclr.relocations.log J:\lang\net\runtime\artifacts\tests\coreclr\Windows_NT.x64.Debug\Tests\Core_Root\coreclr.dll
dumpbin /RAWDATA:1,32 /OUT:j:\database\tools\DumpBin\output\coreclr.rawdata.log J:\lang\net\runtime\artifacts\tests\coreclr\Windows_NT.x64.Debug\Tests\Core_Root\coreclr.dll
dumpbin /LOADCONFIG /OUT:j:\database\tools\DumpBin\output\coreclr.loadconfig.log J:\lang\net\runtime\artifacts\tests\coreclr\Windows_NT.x64.Debug\Tests\Core_Root\coreclr.dll

dumpbin /DISASM:NOBYTES /OUT:j:\database\tools\DumpBin\output\dia2lib.disasm.nobytes.asm J:\lang\net\runtime\artifacts\tests\coreclr\Windows_NT.x64.Debug\Tests\Core_Root\dia2lib.dll
dumpbin /DISASM:NOBYTES /OUT:j:\database\tools\DumpBin\output\createdump.disasm.asm J:\lang\net\runtime\artifacts\tests\coreclr\Windows_NT.x64.Debug\Tests\Core_Root\createdump.exe

*/
        public void Run()
        {
            var target = Wf.Db().ToolOutput(DumpBin.ToolId);

            var headers = list<CmdExpr>();

            var disasm = list<CmdExpr>();

            var archive = ModuleArchive.create(EnvVars.Common.ClrCoreRoot);
            foreach(var file in archive.Files())
            {
                if(file.Kind == FileModuleKind.NativeDll)
                {
                    headers.Add(DumpBin.headers(file.Path, target));
                    disasm.Add(DumpBin.disasm(file.Path, target));
                }
            }

            var headerScript = Cmd.script(headers.ToArray());
            var headersJob = Cmd.job("dumpbin.headers", headerScript);
            Wf.EmittedFile(headerScript.GetType(),
                headerScript.Length,
                Cmd.enqueue(headersJob, Wf.Db()));

            var disasmScript = Cmd.script(disasm.ToArray());
            var disasmJob = Cmd.job("dumpbin.disasm", disasmScript);
            Wf.EmittedFile(disasmScript.GetType(), disasmScript.Length,
                Cmd.enqueue(disasmJob, Wf.Db()));
        }
    }
}