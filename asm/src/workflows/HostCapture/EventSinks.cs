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

    partial class HostCaptureWorkflow
    {
        public class EventSinks : 
            IAppEventSink<ExtractReportCreated>,
            IAppEventSink<ParseReportCreated>, 
            IAppEventSink<AsmFunctionsDecoded>,
            IAppEventSink<AsmCodeSaved>,
            IAppEventSink<ApiHostReportSaved>

        {
            readonly WorkflowService Workflow;

            public event Action<ExtractReportCreated> HostExtractReportCreated;

            public event Action<ParseReportCreated> HostParseReportCreated;

            public event Action<AsmFunctionsDecoded> HostFunctionsDecoded;

            public event Action<AsmCodeSaved> HostCodeSaved;

            public event Action<ApiHostReportSaved> HostReportSaved;

            [MethodImpl(Inline)]
            internal static EventSinks Connect(WorkflowService workflow)
                => new EventSinks(workflow);            

            EventSinks(WorkflowService workflow)
            {
                this.Workflow = workflow;
                workflow.WithSink(this, ExtractReportCreated.Empty);
                workflow.WithSink(this, ParseReportCreated.Empty);
                workflow.WithSink(this, AsmFunctionsDecoded.Empty);
                workflow.WithSink(this, AsmCodeSaved.Empty);
                workflow.WithSink(this, ApiHostReportSaved.Empty);
            }

            public virtual void Accept(in ExtractReportCreated e)
            {
                HostExtractReportCreated?.Invoke(e);
            }

            public virtual void Accept(in ParseReportCreated e)
            {
                HostParseReportCreated?.Invoke(e);
            }

            public virtual void Accept(in AsmFunctionsDecoded e)
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

        }
    }
}