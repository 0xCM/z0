//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    public struct ApiCaptureEmitter : IDisposable
    {
        public static ApiCaptureEmitter create(IWfShell wf, WfHost host, IAsmContext asm, ApiHostUri src, ApiMemberExtract[] extracts)
            => new ApiCaptureEmitter(wf,host, asm, src, extracts);

        readonly CorrelationToken Ct;

        readonly ApiMemberExtract[] Extracts;

        readonly ApiHostUri HostUri;

        public ApiMemberCodeBlocks ParsedBlocks;

        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IAsmContext Asm;

        public ApiCaptureEmitter(IWfShell wf, WfHost host, IAsmContext asm, ApiHostUri src, ApiMemberExtract[] extracts)
        {
            Host = host;
            Wf = wf.WithHost(host);
            Asm = asm;
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

        public void Emit()
        {
            var flow = Wf.Running();

            try
            {
                EmitExtracts();
                ParseMembers();
                EmitApiHexRows.create(HostUri, ParsedBlocks).Run(Wf);
                EmitHostCil.create(HostUri).Run(Wf, ParsedBlocks, out var _);
                DecodeMembers();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran(flow);
        }

        void EmitExtracts()
        {
            try
            {
                if(Extracts.Length == 0)
                    return;

                var dst = Wf.Db().CapturedExtractFile(HostUri);
                var emitted = ApiCode.emit(Extracts.Map(x => new ApiCodeBlock(x.Address, x.OpUri, x.Encoded, x.ApiSig)), dst);
                Wf.EmittedTable<ApiCodeRow>(emitted.Length, dst);

                // using var step = new EmitCapturedExtractsStep(Wf, new EmitCapturedExtracts(), HostUri, Extracts);
                // step.Run();
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


            if(ParsedBlocks.Count == 0)
                return;

            Wf.Status(string.Format("Parsed {0} {1} extract blocks", ParsedBlocks.Count, HostUri));

            EmitHostHex.run(Wf, HostUri, ParsedBlocks, out var payload);
        }

        void DecodeMembers()
        {
            EmitHostAsm.create(Asm, HostUri).Run(Wf, ParsedBlocks, out var decoded);
            if(decoded.Count != 0)
            {
                using var match = new MatchAddressesStep(Wf, Host, Extracts, decoded.Storage, Ct);
                match.Run();
            }
       }
    }
}