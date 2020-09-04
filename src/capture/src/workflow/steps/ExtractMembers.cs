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

    using Z0.Asm;

    public readonly ref struct ExtractMembers
    {
        readonly CorrelationToken Ct;

        readonly IWfCaptureState State;

        readonly IWfShell Wf;

        [MethodImpl(Inline)]
        public ExtractMembers(IWfCaptureState state, CorrelationToken ct)
        {
            State = state;
            Wf = state.Wf;
            Ct = ct;
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        X86MemberExtract[] Extract(ICaptureContext context, IApiHost host)
        {
            var members = ApiMemberJit.jit(host);
            Wf.Raise(new MembersLocated(host.Uri, members, Ct));
            return Extractor.Extract(members);
        }

        public X86MemberExtract[] Extract(IApiHost host)
        {
            var extracted = sys.empty<X86MemberExtract>();
            try
            {
                extracted = Extract(State.CWf.Context ,host);
                Wf.Raise(new ExtractedMembers(host.Uri, extracted.Length, Ct));
            }
            catch(Exception e)
            {
                Wf.Error(StepId, e);
            }
            return extracted;
        }

        public X86MemberExtract[] Extract(IApiHost[] hosts)
        {
            var extracted = sys.empty<X86MemberExtract>();
            try
            {
                var members = ApiMemberJit.jit(hosts, Wf.Broker.Sink);
                Wf.Raise(new PreparedConsolidated(nameof(ExtractMembers), hosts, members, Ct));
                return Extractor.Extract(members);
            }
            catch(Exception e)
            {
                Wf.Error(StepName, e, Ct);
                return sys.empty<X86MemberExtract>();
            }
        }

        public X86MemberExtract[] Extract(ApiDataType[] types)
        {
            var extracted = sys.empty<X86MemberExtract>();
            try
            {
                return Extractor.Extract(ApiMemberJit.jit(types));
            }
            catch(Exception e)
            {
                Wf.Error(StepName, e, Ct);
                return sys.empty<X86MemberExtract>();
            }
        }

        static MemberExtractor Extractor
            => MemberExtraction.service(Extractors.DefaultBufferLength);
    }
}