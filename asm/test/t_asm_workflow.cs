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

    using WF = HostCaptureWorkflow;

    public abstract class WorkflowHost
    {

    }

    public class t_asm_workflow : t_asm<t_asm_workflow>
    {

        public t_asm_workflow()
        {

        }

        public bool HandleMembersLocated {get;} = true;

        public bool HandleExtractsParsed {get;} = true;

        public bool HandleFunctionsDecoded {get;} = true;

        public bool HandleCodeSaved {get;} = true;

        public bool HandleHostReportSaved {get;} = false;

        public bool HandleExtractReportCreated {get;} = false;

        public bool HandleParseReportCreated {get;} = false;

        void OnEvent(MembersLocated e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Cyan);
            Analyze(e.Host, e.EventData);
            NotifyConsole(msg);
        }

        void OnEvent(ExtractsParsed e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Green);
            NotifyConsole(msg);
            Analyze(e.Host, e.EventData);
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

            Analyze(e.Host, e.EventData);
        }

        void OnEvent(AsmCodeSaved e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Cyan);
            NotifyConsole(msg);
        }

        void OnEvent(ExtractReportSaved e)
        {            
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Cyan);
            NotifyConsole(msg);
        }

        RootEmissionPaths Root
            => RootEmissionPaths.Define(DefaultDataDir);

        void ConnectReceivers(IWorkflowEventBroker broker)
        {
            if(HandleExtractReportCreated)
                broker.ExtractReportCreated.Receive(broker, OnEvent);

            if(HandleParseReportCreated)
                broker.ParseReportCreated.Receive(broker, OnEvent);

            if(HandleFunctionsDecoded)
                broker.FunctionsDecoded.Receive(broker, OnEvent);

            if(HandleCodeSaved)            
                broker.CodeSaved.Receive(broker, OnEvent);

            if(HandleHostReportSaved)
                broker.HostReportSaved.Receive(broker, OnEvent);
            
            if(HandleMembersLocated)
                broker.MembersLocated.Receive(broker, OnEvent);

            if(HandleExtractsParsed)            
                broker.ExtractsParsed.Receive(broker, OnEvent);
        }

        public void ExecuteWorkflow()
        {
            var workflow = HostCaptureWorkflow.Create(Context);
            ConnectReceivers(workflow.EventBroker);
            workflow.Run(Root);
        }

        void Analyze(in ApiHostUri host, ReadOnlySpan<AsmFunction> functions)
        {
            var analyzer = FunctionAnalyzer.Create();
            var analyses = analyzer.Analyze(functions);
            var counts = analyses.Map(a => a.InstructionCount);
            var total = gspan.sum(counts.AsUInt64());
            NotifyConsole($"The {host} host members define a total of {total} instructions", AppMsgColor.Cyan);            
        }

        void Analyze(in ApiHostUri host, ReadOnlySpan<ParsedExtract> extracts)
        {
            ref readonly var src = ref head(extracts);
            var count = extracts.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var subject = ref skip(src, i);                
            }
        }

        void Analyze(in ApiHostUri host, ReadOnlySpan<LocatedMember> members)
        {
            foreach(var member in members)
            {
                member.KindId.OnValue(id => NotifyConsole($"The {member.Uri} is of kind {id}"));
            }
        }

        void DescribeOpKinds(ApiHost host)
        {            
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
                var kind = method.KindId();
                if(kind.HasValue)
                    NotifyConsole($"Member {method.Name} has a kind identifier: {kind}", AppMsgColor.Magenta);
            }
        }
    }
}