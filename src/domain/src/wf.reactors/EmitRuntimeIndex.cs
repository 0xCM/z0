//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static z;

    sealed class EmitRuntimeIndex : CmdReactor<EmitRuntimeIndexCmd,CmdResult>
    {
        protected override CmdResult Run(EmitRuntimeIndexCmd cmd)
            => react(Wf, cmd);

        [Op]
        public static CmdResult react(IWfShell wf, EmitRuntimeIndexCmd cmd)
        {

            var outcome = ApiRuntime.EmitIndex(wf);
            outcome.OnSuccess(path => wf.Status(Msg.EmittedRuntimeIndex.Format(path))).OnFailure(msg => wf.Error(msg));

            // var hosts = wf.Api.ApiHosts;
            // var kHost = (uint)hosts.Length;
            // var members  = @readonly(ApiRuntime.index(wf));
            // var target = wf.Db().IndexFile("api.members");
            // using var writer = target.Writer();
            // var count = members.Length;
            // var buffer = Buffers.text();
            // for(var i=0; i<count; i++)
            // {
            //     ApiRuntime.render(skip(members, i), buffer);
            //     writer.WriteLine(buffer.Emit());
            // }

            //wf.Status(Msg.EmittedRuntimeIndex.Format(kHost, target));

            return outcome ?  Cmd.ok(cmd) : Cmd.fail(cmd, outcome.Message);
        }
    }
}