//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;
    using static z;

    sealed class EmitRuntimeIndex : CmdReactor<EmitRuntimeIndexCmd,CmdResult>
    {
        protected override CmdResult Run(EmitRuntimeIndexCmd cmd)
            => run(Wf,cmd);

        public static CmdResult run(IWfShell wf, EmitRuntimeIndexCmd cmd)
        {
            var hosts = wf.Api.ApiHosts;
            var kHost = (uint)hosts.Length;
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

            wf.Status(Msg.EmittedOpIndex.Apply(kHost, target));

            return Cmd.ok(cmd);
        }
    }
}
