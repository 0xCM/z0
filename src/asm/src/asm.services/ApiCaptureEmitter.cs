//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    public struct ApiCaptureEmitter : IApiCaptureEmitter
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IAsmContext Asm;

        public ApiCaptureEmitter(IWfShell wf, IAsmContext asm)
        {
            Host = WfShell.host(nameof(ApiCaptureEmitter));
            Wf = wf.WithHost(Host);
            Asm = asm;
        }

        public AsmRoutines Emit(ApiHostUri host, Index<ApiMemberExtract> src)
        {
            var routines = AsmRoutines.Empty;
            try
            {
                var flow = Wf.Running();
                EmitExtracts(host, src);
                var code = ParseExtracts(host, src);
                if(code.Length != 0)
                {
                    EmitApiHex(host, code);
                    EmitCil(host, code);
                    routines = DecodeMembers(host, code, src);
                }
                Wf.Ran(flow);
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
            return routines;
        }

        public Index<ApiHexRow> EmitApiHex(ApiHostUri host, Index<ApiMemberCode> src)
            => ApiCode.emit(Wf, host, src.View);

        public Count EmitCil(ApiHostUri host, Index<ApiMemberCode> src)
        {
            if(src.Count != 0)
            {
                var emitter = CilEmitter.create(Wf);
                emitter.EmitCilCode(src, Wf.Db().CilCodeFile(host));
                emitter.EmitCilData(src, Wf.Db().CilDataFile(host));
            }

            return src.Count;
        }

        Index<ApiCodeExtract> EmitExtracts(ApiHostUri host, Index<ApiMemberExtract> src)
        {
            var emitted = sys.empty<ApiCodeExtract>();
            var count = src.Length;
            var blocks = src.Map(x => new ApiCodeBlock(x.Address, x.OpUri, x.Encoded));
            var dst = Wf.Db().ApiExtractFile(host);
            var flow = Wf.EmittingTable<ApiCodeExtract>(dst);
            emitted = ApiCodeExtracts.emit(blocks, dst);
            Wf.EmittedTable(flow, count);
            return emitted;
        }

        Index<ApiMemberCode> ParseExtracts(ApiHostUri host, Index<ApiMemberExtract> src)
        {
            if(src.Length != 0)
            {
                var parser = ApiCodeExtractors.parser();
                var parsed = parser.ParseMembers(src);
                Wf.Status(string.Format("Parsed {0} {1} extract blocks", parsed.Count, host));
                return parsed;
            }
            else
                return Index<ApiMemberCode>.Empty;
        }


        AsmRoutines DecodeMembers(ApiHostUri host, Index<ApiMemberCode> src, Index<ApiMemberExtract> extracts)
        {
            var emitter = AsmServices.HostEmitter(Wf, Asm);
            emitter.Emit(host, src, out var decoded);
            if(decoded.Count != 0)
            {
                using var match = new AsmAddressMatcher(Wf, Host, extracts, decoded.Storage, Wf.Ct);
                match.Run();
            }
            return decoded;
       }
    }
}