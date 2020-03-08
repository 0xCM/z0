//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmWorkflowReports;
    using static HostCaptureWorkflow;

    public class t_asm_workflow : t_asm<t_asm_workflow>
    {

        public t_asm_workflow()
        {

        }
        
        void OnEvent(ExtractReportCreated e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Blue);
            NotifyConsole(msg);
        }

        void OnEvent(ParseReportCreated e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Blue);
            NotifyConsole(msg);
        }

        void OnEvent(AsmFunctionsDecoded e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Magenta);
            NotifyConsole(msg);
        }

        void OnEvent(AsmCodeSaved e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Cyan);
            NotifyConsole(msg);
        }

        void OnEvent(ApiHostReportSaved e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Cyan);
            NotifyConsole(msg);
        }

        public void ExecuteWorkflow()
        {
            var workflow = HostCaptureWorkflow.Create(Context);
            var sinks = workflow.ConnectSinks();
            sinks.HostExtractReportCreated += OnEvent;
            sinks.HostParseReportCreated += OnEvent;
            sinks.HostFunctionsDecoded += OnEvent;
            sinks.HostCodeSaved += OnEvent;
            sinks.HostReportSaved += OnEvent;
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