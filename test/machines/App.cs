//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Threading;

    class App : TestApp<App>
    {            
        AgentContext AgentContext;

        Option<ServerComplex> Complex;

        void ManageServerComplex()
        {
            Terminal.Get().SetTerminationHandler(OnTerminate);
            
            term.cyan($"Starting server complex");
            ServerComplex.Start(AgentContext).ContinueWith(complex => 
                {
                    Complex = complex.Result;
                    term.magenta("Server complex started");

                });

            var control = AgentControl.FromContext(this);
            control.Configure(AgentContext).ContinueWith(_ => 
            {
                term.inform($"There are {control.SummaryStats.AgentCount.ToString()} agents in play");
            });

            
            term.readKey("Press any key to terminate the application");            
        }

        void OnTerminate()
        {
            if(Complex)
            {                          

                Complex.OnSome(c => {
                    term.cyan($"Shutting down server complex");
                    c.Stop().Wait();
                    term.magenta($"Server complex shut down complete");                    
                });
            }
        }   

        protected override void RunTests(params string[] filters)
        {
            this.AgentContext = new AgentContext(SystemEventWriter.Log);
            
            //ManageServerComplex();

            base.RunTests();
        
        }

        public static void Main(params string[] args)
            => Run(args);
    }
}