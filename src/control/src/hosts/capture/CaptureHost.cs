//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static Seed;
    using static Memories;
    
    using static Asm.CaptureWorkflowEvents;

    public class CaptureHost : ICaptureHost
    {               
        public IAppMsgSink Sink {get;}

        public ICaptureBroker Broker {get;}

        readonly IAsmContext Context;

        readonly CaptureConfig Settings;

        readonly AsmWorkflowConfig WorkflowConfig;

        readonly IAsmFormatter Formatter;

        readonly IAsmFunctionDecoder Decoder;

        readonly ICaptureWorkflow CaptureWorkflow;

        readonly IImmEmissionWorkflow ImmWorkflow;

        readonly IUriBitsReader UriBitsReader;

        readonly AsmFormatSpec FormatConfig;
        
        public static ICaptureHost Create(IAsmContext context, FolderPath root)    
            => new CaptureHost(context,root);

        CaptureHost(IAsmContext context, FolderPath root)
        {                    
            Context = context;
            Sink = context;
            WorkflowConfig = new AsmWorkflowConfig(root);
            Settings = CaptureConfig.From(context.Settings);            
            FormatConfig = AsmFormatSpec.WithSectionDelimiter;
            Formatter = context.Contextual.AsmFormatter(FormatConfig);            

            var wfc = AsmWorkflows.Create(context);            
            Decoder = Capture.Services.AsmDecoder(FormatConfig);
            UriBitsReader = Capture.Services.UriBitsReader;
            CaptureWorkflow = wfc.CaptureWorkflow(Decoder, Formatter, Capture.Services.CaptureArchive(root));
            Broker = CaptureWorkflow.EventBroker;
            ImmWorkflow = wfc.ImmEmissionWorkflow(Sink, context.ApiSet, Formatter, Decoder, root);
            
            (this as ICaptureClient).Connect();            
        }

        IChecks Claim => Checks.Checker;

        ICheckEquatable Equatable => CheckEquatable.Checker;

        public void Dispose()
        {
            term.print($"Commpleted capture workflow");
        }
        
        public void Execute(params PartId[] parts)
        {
            if(Settings.EmitImmArtifacts)
                EmitImm(parts);

            if(Settings.EmitPrimaryArtifacts)
                EmitPrimary(parts);

            if(Settings.CheckExecution)
                CheckExec(parts);
        }

        void EmitImm(params PartId[] parts)
        {
            ImmWorkflow.ClearArchive();
            ImmWorkflow.EmitRefined();
        }

        void EmitPrimary(params PartId[] parts)
        {
            CaptureWorkflow.Run(WorkflowConfig, parts);
        }

        void CheckExec(params PartId[] parts)
        {            
            Context.Contextual.CreateEvalWorkflow(WorkflowConfig).Execute(parts);
        }

        public void OnEvent(FunctionsDecoded e)
        {
            Sink.Deposit(e);

            if(Settings.CollectAsmStats)
                CollectAsmStats(e.Host, e.Payload);
        }

        public void OnEvent(HexSaved e)
        {
            Sink.Deposit(e);

            if(Settings.MatchEmissions)
                CaptureWorkflow.MatchEmissions.MatchEmissions(e.Host, e.Payload, e.Target);
        }

        public void OnEvent(MembersLocated e)
        {
            Sink.Deposit(e);

            if(Settings.DuplicateCheck)
                CheckDuplicates(e.Host, e.Members);
        }

        
        void CollectAsmStats(ApiHostUri host, ReadOnlySpan<AsmFunction> functions)
        {
            var count = 0ul;
            for(var i = 0; i<functions.Length; i++)
                count += (ulong)skip(functions,i).InstructionCount;
            
            Sink.CountedInstructions(host, count);                   
        }
             
        void CheckDuplicates(ApiHostUri host, ReadOnlySpan<Member> src)
        {
            var index = ApiMemberOps.Service.CreateIndex(src);
            foreach(var key in index.DuplicateKeys)
                Sink.DuplicateWarning(host,key);
        }
    }
}