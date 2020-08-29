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

        readonly WfCaptureState Wf;

        [MethodImpl(Inline)]
        public ExtractMembers(WfCaptureState state, CorrelationToken ct)
        {
            Wf = state;
            Ct = ct;
            Wf.Created(StepName,  Ct);
        }

        public void Dispose()
        {
            Wf.Finished(StepName, Ct);
        }

        X86MemberExtract[] Extract(ICaptureContext context, IApiHost host)
        {
            var members = ApiMemberJit.jit(host);
            context.Raise(new MembersLocated(host.Uri, members));
            return Extractor.Extract(members);
        }

        public X86MemberExtract[] Extract(IApiHost host)
        {
            var extracted = sys.empty<X86MemberExtract>();
            try
            {
                extracted = Extract(Wf.CWf.Context ,host);
                Wf.Raise(new ExtractedMembers(host.Uri, extracted.Length));
            }
            catch(Exception e)
            {
                Wf.Error(StepName, e, Ct);
            }
            return extracted;
        }

        public X86MemberExtract[] Extract(IApiHost[] hosts)
        {
            var extracted = sys.empty<X86MemberExtract>();
            try
            {
                var members = ApiMemberJit.jit(hosts, Wf.WfEventSink);
                Wf.Raise(new PreparedConsolidated(nameof(ExtractMembers), hosts, members, Ct));
                return Extractor.Extract(members);
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