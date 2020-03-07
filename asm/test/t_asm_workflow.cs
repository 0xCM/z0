//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;
    using static HostCaptureWorkflow;

    using WF = HostCaptureWorkflow;

    public class t_asm_workflow : t_asm<t_asm_workflow>
    {

        public t_asm_workflow()
        {

        }
        
        void Created(ExtractReportCreated e)
        {
            term.golden(e.Format());

        }

        void Created(ParseReportCreated e)
        {
            term.cyan(e.Format());

        }

        void Decoded(WF.FunctionsDecoded e)
        {
            term.magenta(e.Format());
        }

        public void ExecuteWorkflow()
        {
            var workflow = WF.Create(Context);
            var sinks = WF.EventSinks.Connect(workflow);
            workflow.ExecuteWorkflow(DefaultDataDir);
        }

        void load_reports(FolderPath src)
        {
            var root = RootEmissionPaths.Define(src);

        }

        public Option<MemberParseReport> LoadMemberParseReport(ApiHostUri host)
        {            
            try
            {            

                return default;
            }
            catch(Exception e)
            {
                term.error(e);
                return none<MemberParseReport>();
            }
        }

    }
}