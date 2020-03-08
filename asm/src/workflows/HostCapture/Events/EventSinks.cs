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
    using static AsmWorkflowReports;

    partial class HostCaptureWorkflow
    {
        public class EventSinks : IBrokeredSource,
            IAppEventSink<ExtractReportCreated>,
            IAppEventSink<ParseReportCreated>, 
            IAppEventSink<FunctionsDecoded>,
            IAppEventSink<AsmCodeSaved>,
            IAppEventSink<ExtractsParsed>,
            IAppEventSink<ApiHostReportSaved>
        {
            readonly Runner Workflow;

            readonly AppEventBroker Broker;

            public event Action<ExtractReportCreated> HostExtractReportCreated;

            public event Action<ParseReportCreated> HostParseReportCreated;

            public event Action<FunctionsDecoded> HostFunctionsDecoded;

            public event Action<ExtractsParsed> HostExtractsParsed;

            public event Action<AsmCodeSaved> HostCodeSaved;

            public event Action<ApiHostReportSaved> HostReportSaved;

            [MethodImpl(Inline)]
            internal static EventSinks Connect(Runner workflow)
                => new EventSinks(workflow);            

            EventSinks(Runner workflow)
            {
                this.Workflow = workflow;
                //this.Broker = AppEventBroker.Create(this);
                AddSinks();
            }

            public void AddSinks()
            {
                Workflow.WithSink(this, ExtractReportCreated.Empty);
                Workflow.WithSink(this, ParseReportCreated.Empty);
                Workflow.WithSink(this, FunctionsDecoded.Empty);
                Workflow.WithSink(this, ExtractsParsed.Empty);
                Workflow.WithSink(this, AsmCodeSaved.Empty);
                Workflow.WithSink(this, ApiHostReportSaved.Empty);
            }

            public void AddSinks(IAppEventBroker broker)
            {
                broker.AddSink(this, ExtractReportCreated.Empty);
                broker.AddSink(this, ParseReportCreated.Empty);
                broker.AddSink(this, FunctionsDecoded.Empty);
                broker.AddSink(this, ExtractsParsed.Empty);
                broker.AddSink(this, AsmCodeSaved.Empty);
                broker.AddSink(this, ApiHostReportSaved.Empty);
            }

            public virtual void Accept(in ExtractReportCreated e)
            {
                HostExtractReportCreated?.Invoke(e);
            }

            public virtual void Accept(in ParseReportCreated e)
            {
                HostParseReportCreated?.Invoke(e);
            }

            public virtual void Accept(in FunctionsDecoded e)
            {
                HostFunctionsDecoded?.Invoke(e);
            }

            public virtual void Accept(in AsmCodeSaved e)
            {
                HostCodeSaved?.Invoke(e);
            }

            public virtual void Accept(in ApiHostReportSaved e)
            {
                HostReportSaved?.Invoke(e);
            }

            public void Accept(in ExtractsParsed e)
            {
                HostExtractsParsed?.Invoke(e);
            }
        }
    }
}