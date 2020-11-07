//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    ref struct AppRunner
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly Multiplex Mpx;

        readonly AppArgs Args;

        readonly CmdBuilder CmdBuilder;

        readonly IFileDb Db;

        readonly ICmdRouter Router;

        public AppRunner(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Mpx = Multiplex.create(wf, Multiplex.configure(wf.Db().Root));
            Args = wf.Args;
            CmdBuilder = wf.CmdBuilder();
            Db = Wf.Db();
            Router = CmdRouter.create(wf);
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        void Run(ToolCmd src)
        {

        }

        public void Run()
        {
            using var runner = new ToolRunner(Wf, Host);
            runner.Run();
        }
    }
}