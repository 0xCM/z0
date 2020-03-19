//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmWorkflowReports;
    using static HostCaptureWorkflow;
    using static AsmServiceMessages;

    class AsmValidationHost : TestContext<AsmValidationHost,IAsmWorkflowContext>, IAsmValidationHost
    {                
        FolderPath RootEmissionPath
            => Context.Paths.TestDataDir(GetType());                

        FilePath AppMsgLogPath
            => (RootEmissionPath + FolderName.Define("logs")) + FileName.Define("host","log");

        public static IAsmValidationHost Create(IAsmWorkflowContext context)    
            => new AsmValidationHost(context);

        public AsmValidationHost(IAsmWorkflowContext context)
            : base(context)
        {            
            Root = RootEmissionPaths.Define(RootEmissionPath);
            Root.LogDir.Clear();
        }
        
        protected override void OnDispose()
        {
            term.print($"Writting app messages to {AppMsgLogPath}");
            Flush(AppMsgLogPath);
        }

        public void Run()
        {
            if(EmitArtifacts)
                Emit();

            if(CheckExecution)
                Exec();
        }

        void Emit()
        {
            var context = AsmWorkflowContext.Rooted(Context, Random);
            var workflow = HostCaptureWorkflow.Create(context);
            require(workflow.EventBroker != null);
            ConnectReceivers(workflow.EventBroker);
            var config = Z0.Asm.HostCaptureConfig.Define(RootEmissionPath);
            workflow.Runner.Run(config);
        }

        void Exec()
        {

            var workflow = AsmExecWorkflow.Create(Context, this, RootEmissionPath);
            workflow.Run();
        }

        RootEmissionPaths Root {get;}

        public bool EmitArtifacts {get;} = false;

        public bool CheckExecution {get;} = true;

        public bool HandleMembersLocated {get;} = true;

        public bool HandleExtractsParsed {get;} = true;

        public bool HandleFunctionsDecoded {get;} = false;

        public bool HandleParsedExtractSaved {get;} = true;

        public bool HandleHostReportSaved {get;} = false;

        public bool HandleExtractReportCreated {get;} = false;

        public bool HandleParseReportCreated {get;} = false;

        void OnEvent(MembersLocated e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Cyan);
            Analyze(e.Host, e.EventData);
        }

        void OnEvent(FunctionsDecoded e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Magenta);
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

        void OnEvent(WorkflowError e)
        {
            NotifyConsole(AppMsg.Error(e.EventData));    
        }

        void OnEvent(StepStart<IApiCatalog> e)
        {
            var msg = AppMsg.Colorize($"{e}: {e.EventData.CatalogName}", AppMsgColor.Green);
            NotifyConsole(msg);
        }

        void OnEvent(StepEnd<IApiCatalog> e)
        {
            var msg = AppMsg.Colorize($"{e}: {e.EventData.CatalogName}", AppMsgColor.Magenta);
            NotifyConsole(msg);            
        }

        void ConnectReceivers(IHostCaptureEventBroker broker)
        {
            broker.Error.Receive(broker, OnEvent);
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

            Witness(broker.CaptureCatalogEnd.Receive(broker, OnEvent));
            Witness(broker.CaptureCatalogStart.Receive(broker, OnEvent));            
        }

        void Witness<E>(in BrokerAcceptance<E> accepted)
            where E : IAppEvent
        {

            NotifyConsole(accepted.Message);
        }
        
        void Analyze(in ApiHostUri host, ReadOnlySpan<AsmFunction> functions)
        {
            static int CountInstructions(in AsmFunction f)
                => f.InstructionCount;

            var _analyzer = SpanAnalyzer.Create<AsmFunction,int>(CountInstructions);
            var _counts = _analyzer.Analyze(functions);
            var _total = gspan.sum(_counts.AsUInt64());

            NotifyConsole($"The {host} host members define a total of {_total} instructions", AppMsgColor.Cyan);            
        }
            
        void Analyze(in ApiHostUri hosturi, ReadOnlySpan<AsmOpBits> ops, FilePath dst)
        {
            var hosted = Context.FindHost(hosturi).MapRequired(host => Context.MemberLocator().Hosted(host)).ToOpIndex();            
            var saved = Context.HexReader().Read(dst).ToArray();
            Claim.eq(saved.Length, ops.Length);
            
            var emptycount = saved.Where(s => s.Op.IsEmpty).Count();
            Claim.eq(emptycount,0);

            ref readonly var src = ref head(ops);
            var count = ops.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var subject = ref skip(src, i);   
                Claim.eq(saved[i].Op, subject.Op);  
                Claim.eq(saved[i].Bits.Length, subject.Bits.Length);           
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