//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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

        void OnEvent(FunctionsDecoded e)
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

        RootEmissionPaths Root
            => RootEmissionPaths.Define(DefaultDataDir);

        void ExecuteWorkflow()
        {
            var workflow = HostCaptureWorkflow.Create(Context);
            var sinks = workflow.ConnectSinks();
            sinks.HostExtractReportCreated += OnEvent;
            sinks.HostParseReportCreated += OnEvent;
            sinks.HostFunctionsDecoded += OnEvent;
            sinks.HostCodeSaved += OnEvent;
            sinks.HostReportSaved += OnEvent;
            workflow.Run(Root);
        }


        public void ExecuteOps()
        {            
            var host = ApiHost.FromType(typeof(math));
            var paths = Root.HostPaths(host);
            var codepath = paths.CodePath;
            Claim.exists(codepath);

            var locator = Context.MemberLocator();
            var members = locator.Hosted(host).CreateIndex();

            var reader = Context.CodeReader();                
            foreach(var code in reader.Read(codepath))
            {
                var id = code.Id;
                var member = members[id];
                Claim.yea(member.IsNonEmpty); 
                
                var method = member.Method;
                if(method.IsUnaryOperator())
                {
                    NotifyConsole($"{id} is a unary operator", AppMsgColor.Magenta);
                }
                else if(method.IsBinaryOperator())
                {
                    NotifyConsole($"{id} is a binary operator", AppMsgColor.Magenta);
                }
                else if(method.IsTernaryOperator())
                {
                    NotifyConsole($"{id} is a ternary operator", AppMsgColor.Magenta);
                }
                else if(method.IsPredicate())
                {
                    NotifyConsole($"{id} is a predicate", AppMsgColor.Magenta);
                }
                else if(method.IsMeasure())
                {
                    NotifyConsole($"{id} is a measure", AppMsgColor.Magenta);
                }
                else if(method.IsNumericFunction())
                {
                    NotifyConsole($"{id} is a numeric function", AppMsgColor.Magenta);
                }
                else
                {
                    NotifyConsole($"{id} is unclassified", AppMsgColor.Yellow);
                }
                
            }
        }
    }
}