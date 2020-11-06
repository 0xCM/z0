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

    [ApiHost(ApiNames.Workers, true)]
    readonly struct Workers
    {
        [CmdWorker]
        public static CmdResult exec(IWfShell wf, EmitHexIndexCmd cmd)
        {
            var dst = wf.Db().Table("apihex.index");
            var descriptors = ApiCode.BlockDescriptors(wf);
            var count= ApiCode.emit(descriptors, dst);
            wf.EmittedTable<CodeBlockDescriptor>(count, dst);
            return Cmd.ok(cmd);
        }

        [CmdWorker]
        public static CmdResult exec(IWfShell wf, EmitRuntimeIndexCmd cmd)
        {
            var hosts = wf.Api.ApiHosts;
            var kHost = (uint)hosts.Length;
            wf.Status(Status.IndexingHosts.Format(kHost));

            var members  = @readonly(ApiRuntime.index(wf));
            var target = wf.Db().IndexFile("api.members");
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
    }
}