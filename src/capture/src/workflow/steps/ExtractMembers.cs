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

        readonly WfHost Host;

        readonly CorrelationToken Ct;

        readonly MemberExtractor Extractor;

        [MethodImpl(Inline)]
        public ExtractMembers(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(host);
            Ct = Wf.Ct;
            Extractor = ApiCodeExtractors.service(ApiCodeExtractors.DefaultBufferLength);
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public ApiMemberExtract[] Extract(IApiHost host)
        {
            try
            {
                return Extractor.Extract(ApiJit.jit(host));
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return sys.empty<ApiMemberExtract>();
            }
        }

        public ApiMemberExtract[] Extract(ApiDataTypes types)
        {
            try
            {
                return Extractor.Extract(ApiJit.jit(types));
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return sys.empty<ApiMemberExtract>();
            }
        }
    }
}