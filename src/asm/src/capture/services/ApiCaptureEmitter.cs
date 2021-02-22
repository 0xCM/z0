//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;
    using static memory;

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

        Index<ApiExtractRow> EmitExtracts(ApiHostUri host, Index<ApiMemberExtract> src)
        {
            var emitted = sys.empty<ApiExtractRow>();
            var count = src.Length;
            var blocks = src.Map(x => new ApiExtractBlock(x.Address, x.OpUri, x.Encoded));
            var dst = Wf.Db().RawExtractFile(host);
            var flow = Wf.EmittingTable<ApiExtractRow>(dst);
            emitted = emit(blocks, dst);
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

        static ApiExtractRow[] emit(ReadOnlySpan<ApiExtractBlock> src, FS.FilePath dst, bool append = false)
        {
            var count = src.Length;
            var header = (dst.Exists && append) ? false : true;
            ref readonly var w0 = ref skip(X86TableWidths, 0);
            ref readonly var w1 = ref skip(X86TableWidths, 1);
            ref readonly var w2 = ref skip(X86TableWidths, 2);
            var pattern = text.embrace($"0,-{w0}") + RP.SpacedPipe + text.embrace($"1,-{w1}") + RP.SpacedPipe + text.embrace($"2,-{w2}");

            using var writer = dst.Writer(append);
            if(header)
                writer.WriteLine(string.Format(pattern, nameof(ApiExtractRow.Base), nameof(ApiExtractRow.Uri), nameof(ApiExtractRow.Encoded)));

            var buffer = alloc<ApiExtractRow>(count);
            var records = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var code = ref skip(src, i);
                if(code.IsNonEmpty)
                {
                    var extract = row(code, ref seek(records,i));
                    writer.WriteLine(string.Format(pattern, extract.Base, extract.Uri, extract.Encoded));
                }
            }
            return buffer;
        }

        [MethodImpl(Inline), Op]
        static ref ApiExtractRow row(in ApiExtractBlock src, ref ApiExtractRow dst)
        {
            dst.Base = src.Extract.BaseAddress;
            dst.Encoded = src.Storage;
            dst.Uri = src.Uri.Format();
            return ref dst;
        }

        static ReadOnlySpan<byte> X86TableWidths => new byte[3]{16,80,80};
    }
}