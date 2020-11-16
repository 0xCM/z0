//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class MachinesTestApp
    {
        AgentContext AgentContext;

        IWfShell Wf;

        Option<AgentComplex> Complex;

        IAgentControl Control;

        MachinesTestApp(AgentContext context, string[] args)
        {
            AgentContext = context;
            Wf = WfShell.create(args);
            Control = AgentControl.FromContext(Wf.Context);
        }

        void Exec()
        {
            Terminal.Get().SetTerminationHandler(OnTerminate);

            Wf.Status($"Starting server complex");
            AgentComplex.Start(AgentContext).ContinueWith(complex =>
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

        public static void run(params string[] args)
        {
            var app = new MachinesTestApp(new AgentContext(SystemEventWriter.Log), args);
            app.Exec();

        }
        static void Main(params string[] args)
            => run(args);
    }
}