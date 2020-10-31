//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    [Step]
    public sealed class EmitCaptureArtifacts : WfHost<EmitCaptureArtifacts>
    {
        protected override void Execute(IWfShell wf)
            => missing();
    }

    public ref struct EmitCaptureArtifactsStep
    {
        public IWfCaptureState State {get;}

        readonly CorrelationToken Ct;

        readonly ApiMemberExtract[] Extracts;

        readonly ApiHostUri HostUri;

        public ApiMemberCodeBlocks ParsedBlocks;

        readonly IWfShell Wf;

        readonly WfHost Host;

        public EmitCaptureArtifactsStep(IWfCaptureState state, WfHost host, ApiHostUri src, ApiMemberExtract[] extracts)
        {
            Wf = state.Wf.WithHost(host);
            Host = host;
            State = state;
            Ct = Wf.Ct;
            HostUri = src;
            Extracts = extracts;
            ParsedBlocks = default;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            Wf.Running();

            try
            {
                EmitExtracts();
                ParseMembers();
                EmitParsedExtracts.create(HostUri, ParsedBlocks).Run(Wf);
                EmitHostCil.create(HostUri).Run(Wf, ParsedBlocks, out var _);
                DecodeMembers();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran();
        }

        void EmitExtracts()
        {
            try
            {
                if(Extracts.Length == 0)
                    return;

                using var step = new EmitCapturedExtractsStep(Wf, new EmitCapturedExtracts(), HostUri, Extracts);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        void ParseMembers()
        {
            if(Extracts.Length == 0)
                return;

            var parser = ApiExtractParsers.member();
            ParsedBlocks = parser.ParseMembers(Extracts);
            Wf.Raise(new ExtractsParsed(Host, HostUri, ParsedBlocks.Count, Ct));

            if(ParsedBlocks.Count == 0)
                return;

            EmitHostHex.run(Wf, HostUri, ParsedBlocks, out var payload);
        }

        void DecodeMembers()
        {
            EmitHostAsm.create(State.CWf.Context, HostUri).Run(Wf, ParsedBlocks, out var decoded);
            if(decoded.Count != 0)
            {
                using var match = new MatchAddressesStep(State, Host, Extracts, decoded.Storage, Ct);
                match.Run();
            }
       }
    }
}