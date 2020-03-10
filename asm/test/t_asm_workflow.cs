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



    public abstract class WorkflowHost
    {

    }

    public enum OverwriteOption
    {
        Overwrite = 0,

        Append = 1
    }

    public enum WorkflowLogKind
    {
        None = 0,

        IdentifiedKind = 1,
    }

    public class t_asm_workflow : t_asm<t_asm_workflow>
    {

        public t_asm_workflow()
        {
            Root = RootEmissionPaths.Define(DefaultDataDir);
            Root.LogDir.Clear();
        }

        
        public override void Dispose()
        {
            base.Dispose();

        }

        RootEmissionPaths Root {get;}

        ILogDevice OpenLog(WorkflowLogKind kind, string name = null, FileExtension ext = null, OverwriteOption? overwrite = null,  bool display = false)
        {
            var devname = name  ?? kind.ToString();            
            var target = Root.LogDir + FileName.Define(devname, ext ?? FileExtensions.Log);
            var append = (overwrite ?? OverwriteOption.Overwrite) == OverwriteOption.Append;
            return Context.OpenLogDevice(target, devname, append, display);
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

        void OnEvent(StepStart<IAssemblyCatalog> e)
        {
            var msg = AppMsg.Colorize($"{e}: {e.EventData.CatalogName}", AppMsgColor.Green);
            NotifyConsole(msg);
        }

        void OnEvent(StepEnd<IAssemblyCatalog> e)
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

        IEnumerable<LocatedMember> KindedOperators(IEnumerable<LocatedMember> src, int? arity = null)
            => from located in src
                let m = located.Method
                let id = m.KindId()
                where id.HasValue && m.IsOperator() && (arity != null ? m.Arity() == arity : true)
                select located;

        IEnumerable<LocatedMember> KindedNumericOperators(IEnumerable<LocatedMember> src, int arity)
            => from located in src
                let m = located.Method
                let id = m.KindId()
                where id.HasValue && m.IsNumericOperator(arity)
                select located;

        void Analyze(in ApiHostUri host, ReadOnlySpan<LocatedMember> src)
        {
            var index = src.ToOpIndex();
            foreach(var key in index.DuplicateKeys)
                NotifyConsole(DuplicateWarning(host,key));

            var kinded = (from located in KindedOperators(src.ToEnumerable())
                         let m = located.Method
                         let id = m.KindId().Value
                         let c = TypedOperatorClass.Infer(m)
                         select (located.Uri, m, c,  id)).ToArray();


            var messages = list<AppMsg>(kinded.Length);        
            foreach(var (uri,method,oc,kind) in kinded)
                messages.Add(AppMsg.NoCaller(text.concat(uri.Identifier.PadRight(90), text.spaced(text.pipe()), kind.ToString().PadRight(14), oc), AppMsgKind.Info));

            if(messages.Count != 0)
            {
                using var log = OpenLog(WorkflowLogKind.IdentifiedKind, "numeric-binary-ops", FileExtensions.Csv, OverwriteOption.Append);
                log.Write(messages.ToArray());
            }
        }

    }
}