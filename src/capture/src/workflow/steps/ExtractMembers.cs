//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static ExtractMembersStep;

    public readonly ref struct ExtractMembers
    {
        readonly CorrelationToken Ct;

        readonly IWfShell Wf;

        readonly MemberExtractor Extractor;

        [MethodImpl(Inline)]
        public ExtractMembers(IWfShell wf)
        {
            Wf = wf;
            Ct = Wf.Ct;
            Extractor = X86Extraction.service(X86Extraction.DefaultBufferLength);
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        public X86ApiExtract[] Extract(IApiHost host)
        {
            try
            {
                return Extractor.Extract(ApiMemberJit.jit(host));
            }
            catch(Exception e)
            {
                Wf.Error(StepId, e);
                return sys.empty<X86ApiExtract>();
            }
        }

        public X86ApiExtract[] Extract(IApiHost[] hosts)
        {
            try
            {
                return Extractor.Extract(ApiMemberJit.jit(hosts, Wf.Broker.Sink));
            }
            catch(Exception e)
            {
                Wf.Error(StepName, e, Ct);
                return sys.empty<X86ApiExtract>();
            }
        }

        public X86ApiExtract[] Extract(ApiDataTypes types)
        {
            var extracted = sys.empty<X86ApiExtract>();
            try
            {
                return Extractor.Extract(ApiMemberJit.jit(types));
            }
            catch(Exception e)
            {
                Wf.Error(StepName, e, Ct);
                return sys.empty<X86ApiExtract>();
            }
        }
    }
}