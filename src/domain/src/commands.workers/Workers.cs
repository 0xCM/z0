//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;
    using static ApiDataModel;

    [PartService(ApiNames.Workers)]
    struct Workers : ICmdRouter<Workers>
    {
        IWfShell Wf;

        CmdWorkers WorkerIndex;

        IndexedView<CmdId> Commands;

        public IndexedView<CmdId> SupportedCommands
            => Commands;

        bool Accepting;

        public static Workers init(IWfShell wf)
        {
            var workers = default(Workers);
            workers.Init(wf);
            return workers;
        }

        public void Init(IWfShell wf)
        {
            Wf = wf;
            WorkerIndex = default;
            WorkerIndex = CmdWorkers.create();
            Commands = array(Cmd.id<EmitHexIndexCmd>(), Cmd.id<EmitRuntimeIndexCmd>());
            Accepting = true;
        }

        [CmdWorker]
        public CmdResult exec(EmitHexIndexCmd cmd)
        {
            require(Accepting);
            var dst = Wf.Db().Table("apihex.index");
            var descriptors = ApiCode.BlockDescriptors(Wf);
            var count= ApiCode.emit(descriptors, dst);
            Wf.EmittedTable<CodeBlockDescriptor>(count, dst);
            return Cmd.ok(cmd);
        }

        [CmdWorker]
        public CmdResult exec(EmitRuntimeIndexCmd cmd)
        {
            require(Accepting);

            var hosts = Wf.Api.ApiHosts;
            var kHost = (uint)hosts.Length;
            Wf.Status(Status.IndexingHosts.Format(kHost));

            var members  = @readonly(ApiRuntime.index(Wf));
            var target = Wf.Db().IndexFile("api.members");
            using var writer = target.Writer();
            var count = members.Length;
            var buffer = Buffers.text();
            for(var i=0; i<count; i++)
            {
                ApiRuntime.render(skip(members, i), buffer);
                writer.WriteLine(buffer.Emit());
            }

            return Cmd.ok(cmd);
        }

        public CmdResult Dispatch(CmdSpec cmd)
        {
            return default;
        }
    }
}