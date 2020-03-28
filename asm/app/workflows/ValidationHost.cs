//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static root;
    using static AsmWorkflowReports;
    using static HostCaptureWorkflow;
    using static AsmServiceMessages;

    class ValidationHost : TestContext<ValidationHost,IAsmContext>, IAsmValidationHost
    {               
        FolderPath RootEmissionPath
            => Context.Paths.TestDataDir(GetType());                

        FilePath AppMsgLogPath
            => (RootEmissionPath + FolderName.Define("logs")) + FileName.Define("host","log");

        public static IAsmValidationHost Create(IAsmContext context)    
            => new ValidationHost(context);

        public ValidationHost(IAsmContext context)
            : base(context)
        {            
            Root = RootEmissionPaths.Define(RootEmissionPath);
            Root.LogDir.Clear();
            Settings = ValidationHostConfig.From(context.Settings);            
        }

        ValidationHostConfig Settings {get;}

        RootEmissionPaths Root {get;}

        protected override void OnDispose()
        {
            term.print($"Writting app messages to {AppMsgLogPath}");
            Emit(AppMsgLogPath);
        }

        public void Run()
        {
            if(Settings.EmitArtifacts)
                Emit();

            if(Settings.CheckExecution)
                Exec();
        }

        void Emit()
        {
            var workflow = HostCaptureWorkflow.Create(Context);
            var config = HostCaptureConfig.Define(RootEmissionPath);            

            ConnectReceivers(workflow.EventBroker);
            workflow.Runner.Run(config);
        }

        void Exec()
        {
            var workflow = AsmExecWorkflow.Create(Context, this, RootEmissionPath);
            workflow.Run();
        }

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

            if(Settings.HandleExtractReportCreated)
                broker.ExtractReportCreated.Receive(broker, OnEvent);

            if(Settings.HandleParseReportCreated)
                broker.ParseReportCreated.Receive(broker, OnEvent);

            if(Settings.HandleFunctionsDecoded)
                broker.FunctionsDecoded.Receive(broker, OnEvent);

            if(Settings.HandleParsedExtractSaved)            
                broker.HexSaved.Receive(broker, OnEvent);

            if(Settings.HandleHostReportSaved)
                broker.HostReportSaved.Receive(broker, OnEvent);
            
            if(Settings.HandleMembersLocated)
                broker.MembersLocated.Receive(broker, OnEvent);
            
            broker.CaptureCatalogStart.Receive(broker, OnEvent);            
            broker.CaptureCatalogEnd.Receive(broker, OnEvent);

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

        void Analyze(in ApiHostUri host, ReadOnlySpan<ApiLocatedMember> src)
        {
            var index = src.ToOpIndex();
            foreach(var key in index.DuplicateKeys)
                NotifyConsole(DuplicateWarning(host,key));
        }
    }
}