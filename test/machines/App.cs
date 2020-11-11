//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    class App
    {
        AgentContext AgentContext;

        IWfShell Wf;

        Option<ServerComplex> Complex;

        IAgentControl Control;

        App(AgentContext context, string[] args)
        {
            AgentContext = context;
            Wf = WfShellInit.create(args);
            Control = AgentControl.FromContext(Wf.Context);
        }

        void Exec()
        {
            Terminal.Get().SetTerminationHandler(OnTerminate);

            Wf.Status($"Starting server complex");
            ServerComplex.Start(AgentContext).ContinueWith(complex =>
                {
                    Complex = complex.Result;
                    Wf.Status("Server complex started");

                });

            Control.Configure(AgentContext).ContinueWith(_ =>
            {
                Wf.Status($"There are {Control.SummaryStats.AgentCount.ToString()} agents in play");
            });

            term.readKey("Press any key to terminate the application");
        }

        void OnTerminate()
        {
            if(Complex)
            {

                Complex.OnSome(c => {
                    Wf.Status($"Shutting down server complex");
                    c.Stop().Wait();
                    Wf.Status($"Server complex shut down complete");
                });
            }
        }

        public static void Main(params string[] args)
        {
            var app = new App(new AgentContext(SystemEventWriter.Log), args);
            app.Exec();
        }
    }
}