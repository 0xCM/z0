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

    partial class HostCaptureWorkflow
    {
        public class EventSinks : 
            IAppEventSink<ExtractReportCreated>,
            IAppEventSink<ParseReportCreated>, 
            IAppEventSink<FunctionsDecoded>
        {
            readonly IHostCaptureWorkflow Workflow;

            public static EventSinks Connect(IHostCaptureWorkflow workflow)
                => new EventSinks(workflow);
            
            EventSinks(IHostCaptureWorkflow workflow)
            {
                this.Workflow = workflow;
                workflow.WithSink(this, ExtractReportCreated.Empty);
                workflow.WithSink(this, ParseReportCreated.Empty);
                workflow.WithSink(this, FunctionsDecoded.Empty);
            }

            public virtual void Accept(in ExtractReportCreated e)
            {
                term.golden(e.Format());
            }

            public virtual void Accept(in ParseReportCreated e)
            {
                term.cyan(e.Format());
            }

            public virtual void Accept(in FunctionsDecoded e)
            {
                term.magenta(e.Format());
            }
        }
    }
}