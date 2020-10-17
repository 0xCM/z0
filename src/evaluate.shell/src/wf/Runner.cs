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

        public void Run()
        {
            var archive = RuntimeArchive.create();
            //Wf.Rows(archive.NativeLibraries.Storage);

            var dll = archive.Root + FS.file("mscoredbi", ArchiveFileKinds.Dll);
            var cmd = DumpBin.headers(dll, Wf.Db().ToolOutput(DumpBin.ToolId));
            Wf.Status(cmd);
        }
    }
}