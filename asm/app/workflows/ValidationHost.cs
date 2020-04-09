//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Core;
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
            Paths = RootEmissionPaths.Define(RootEmissionPath);
            Paths.LogDir.Clear();
            Settings = ValidationHostConfig.From(context.Settings);            
        }

        ValidationHostConfig Settings {get;}

        RootEmissionPaths Paths {get;}

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
            var decoder = Context.AsmFunctionDecoder();
            var formatter = Context.AsmFormatter(Context.AsmFormat.WithSectionDelimiter());
            var workflow = HostCaptureWorkflow.Create(Context, decoder,formatter,Context.AsmWriterFactory());
            var config = AsmWorkflowConfig.Define(RootEmissionPath);            
            ConnectReceivers(workflow.EventBroker);
            workflow.Runner.Run(config);
        }

        void Exec()
        {
            var workflow = AsmExecWorkflow.Create(Context, this, RootEmissionPath);
            workflow.Run();
        }

        void OnEvent(HostMembersLocated e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Cyan);
            Analyze(e.Host, e.Payload);
        }

        void OnEvent(ExtractReportCreated e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Blue);
            NotifyConsole(msg);
        }

        void OnEvent(ExtractReportSaved e)
        {            
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Cyan);
            NotifyConsole(msg);
        }

        void OnEvent(HostFunctionsDecoded e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Magenta);
            Analyze(e.Host, e.Payload);
        }

        void OnEvent(HostAsmHexSaved e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Cyan);
            NotifyConsole(msg);
            Analyze(e.Host, e.Payload, e.Target);
        }

        void OnEvent(ParseReportCreated e)
        {
            var msg = AppMsg.Colorize(e.Format(), AppMsgColor.Blue);
            NotifyConsole(msg);
        }

        void OnEvent(WorkflowError e)
        {
            NotifyConsole(AppMsg.Error(e.Payload));    
        }

        void OnEvent(StepStart<IApiCatalog> e)
        {
            var msg = AppMsg.Colorize($"{e}: {e.Payload.CatalogName}", AppMsgColor.Green);
            NotifyConsole(msg);
        }

        void OnEvent(StepEnd<IApiCatalog> e)
        {
            var msg = AppMsg.Colorize($"{e}: {e.Payload.CatalogName}", AppMsgColor.Magenta);
            NotifyConsole(msg);            
        }

        void ConnectReceivers(IHostCaptureWorkflowRelay broker)
        {
            broker.Error.Subscribe(broker, OnEvent);

            if(Settings.HandleMembersLocated)
                broker.MembersLocated.Subscribe(broker, OnEvent);

            if(Settings.HandleExtractReportCreated)
                broker.ExtractReportCreated.Subscribe(broker, OnEvent);

            if(Settings.HandleExtractReportSaved)
                broker.ExtractReportSaved.Subscribe(broker, OnEvent);

            if(Settings.HandleParseReportCreated)
                broker.ParseReportCreated.Subscribe(broker, OnEvent);

            if(Settings.HandleFunctionsDecoded)
                broker.FunctionsDecoded.Subscribe(broker, OnEvent);

            if(Settings.HandleParsedExtractSaved)            
                broker.HexSaved.Subscribe(broker, OnEvent);            
            
            broker.CaptureCatalogStart.Subscribe(broker, OnEvent);            
            broker.CaptureCatalogEnd.Subscribe(broker, OnEvent);

        }
        
        void Analyze(in ApiHostUri host, ReadOnlySpan<AsmFunction> functions)
        {
            static int CountInstructions(in AsmFunction f)
                => f.InstructionCount;

            var analyzer = SpanAnalyzer.Create<AsmFunction,int>(CountInstructions);
            var counts = analyzer.Analyze(functions);
            var total = gspan.sum(counts.AsUInt64());

            NotifyConsole($"The {host} host members define a total of {total} instructions", AppMsgColor.Cyan);            
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

        void Analyze(in ApiHostUri host, ReadOnlySpan<ApiMember> src)
        {
            var index = src.ToOpIndex();
            foreach(var key in index.DuplicateKeys)
                NotifyConsole(DuplicateWarning(host,key));
        }
    }
}