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
    using static AsmServiceMessages;

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

        public bool HandleParsedExtractSaved {get;} = true;

        public bool HandleHostReportSaved {get;} = false;

        public bool HandleExtractReportCreated {get;} = false;

        public bool HandleParseReportCreated {get;} = false;

        void OnEvent(MembersLocated e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Cyan);
            Analyze(e.Host, e.EventData);
            //NotifyConsole(msg);
        }

        void OnEvent(FunctionsDecoded e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Magenta);
            //NotifyConsole(msg);
            Analyze(e.Host, e.EventData);
        }

        void OnEvent(AsmHexSaved e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Cyan);
            NotifyConsole(msg);
            Analyze(e.Host, e.EventData, e.Target);
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

            if(HandleParsedExtractSaved)            
                broker.HexSaved.Receive(broker, OnEvent);

            if(HandleHostReportSaved)
                broker.HostReportSaved.Receive(broker, OnEvent);
            
            if(HandleMembersLocated)
                broker.MembersLocated.Receive(broker, OnEvent);
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

        void Analyze(in ApiHostUri hosturi, ReadOnlySpan<AsmOpData> ops, FilePath dst)
        {
            var hosted = Context.FindHost(hosturi).MapRequired(host => Context.MemberLocator().Hosted(host)).ToOpIndex();            
            var saved = Context.HexReader().Read(dst).ToArray();
            Claim.eq(saved.Length, ops.Length);
            
            var emptycount = saved.Where(s => s.Uri.IsEmpty).Count();
            Claim.eq(emptycount,0);

            ref readonly var src = ref head(ops);
            var count = ops.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var subject = ref skip(src, i);   
                Claim.eq(saved[i].Uri, subject.Uri);  
                Claim.eq(saved[i].Bytes.Length, subject.Bytes.Length);           
            }
        }

        void Analyze(in ApiHostUri host, ReadOnlySpan<LocatedMember> src)
        {
            var index = src.ToOpIndex();
            foreach(var key in index.DuplicateKeys)
                NotifyConsole(DuplicateWarning(host,key));

        }

    }
}