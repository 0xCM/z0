//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [WfHost]
    public sealed class ExtractMembersHost : WfHost<ExtractMembersHost>
    {
        protected override void Execute(IWfShell wf)
            => throw missing();
    }

    public readonly ref struct ExtractMembers
    {
        readonly IWfShell Wf;

        readonly ExtractMembersHost Host;

        readonly CorrelationToken Ct;

        readonly MemberExtractor Extractor;

        [MethodImpl(Inline)]
        public ExtractMembers(IWfShell wf, ExtractMembersHost host)
        {
            Wf = wf;
            Host = host;
            Ct = Wf.Ct;
            Extractor = ApiCodeExtractors.service(ApiCodeExtractors.DefaultBufferLength);
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public ApiMemberExtract[] Extract(IApiHost host)
        {
            try
            {
                return Extractor.Extract(ApiMemberJit.jit(host));
            }
            catch(Exception e)
            {
                Wf.Error(Host, e);
                return sys.empty<ApiMemberExtract>();
            }
        }

        public ApiMemberExtract[] Extract(IApiHost[] hosts)
        {
            try
            {
                return Extractor.Extract(ApiMemberJit.jit(hosts, Wf.Broker.Sink));
            }
            catch(Exception e)
            {
                Wf.Error(Host, e);
                return sys.empty<ApiMemberExtract>();
            }
        }

        public ApiMemberExtract[] Extract(ApiDataTypes types)
        {
            var extracted = sys.empty<ApiMemberExtract>();
            try
            {
                return Extractor.Extract(ApiMemberJit.jit(types));
            }
            catch(Exception e)
            {
                Wf.Error(Host, e);
                return sys.empty<ApiMemberExtract>();
            }
        }
    }
}