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

        readonly IAsmContext Asm;

        readonly CilEmitter CilSvc;

        readonly AsmAddressMatcher AddressMatcher;

        public ApiCaptureEmitter(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
            CilSvc = CilEmitter.create(Wf);
            AddressMatcher = AsmAddressMatcher.create(wf);
        }

        public AsmMemberRoutines Emit(ApiHostUri host, Index<ApiMemberExtract> src)
        {
            var routines = AsmMemberRoutines.Empty;
            try
            {
                var flow = Wf.Running(Msg.RunningHostEmissionWorkflow.Format(host,src.Count));
                var emitted = EmitExtracts(host, src);
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
                CilSvc.EmitCilCode(src, Wf.Db().CilCodeFile(host));
                CilSvc.EmitCilData(src, Wf.Db().CilDataFile(host));
            }

            return src.Count;
        }

        Index<ApiExtractRow> EmitExtracts(ApiHostUri host, Index<ApiMemberExtract> src)
        {
            var count = src.Length;
            var blocks = src.Map(x => new ApiExtractBlock(x.Address, x.OpUri, x.Encoded));
            var dst = Wf.Db().RawExtractFile(host);
            var flow = Wf.EmittingTable<ApiExtractRow>(dst);
            var emitted = Emit(blocks, dst);
            Wf.EmittedTable(flow, count);
            return emitted;
        }

        Index<ApiMemberCode> ParseExtracts(ApiHostUri host, Index<ApiMemberExtract> src)
        {
            if(src.Length != 0)
            {
                var flow = Wf.Running();
                var parser = ApiCodeExtractors.parser();
                var parsed = parser.ParseMembers(src);
                Wf.Ran(flow, Msg.ParsedExtractBlocks.Format(parsed.Count, host));
                return parsed;
            }
            else
                return Index<ApiMemberCode>.Empty;
        }

        AsmMemberRoutines DecodeMembers(ApiHostUri host, Index<ApiMemberCode> src, Index<ApiMemberExtract> extracts)
        {
            var emitter = AsmServices.HostEmitter(Wf, Asm);
            emitter.Emit(host, src, out var decoded);
            if(decoded.Count != 0)
                AddressMatcher.Match(extracts, decoded.AsmRoutines);
            return decoded;
       }

        Index<ApiExtractRow> Emit(ReadOnlySpan<ApiExtractBlock> src, FS.FilePath dst, bool append = false)
        {
            var count = src.Length;
            var header = (dst.Exists && append) ? false : true;
            ref readonly var w0 = ref skip(X86TableWidths, 0);
            ref readonly var w1 = ref skip(X86TableWidths, 1);
            ref readonly var w2 = ref skip(X86TableWidths, 2);
            var pattern = text.embrace($"0,-{w0}") + RP.SpacedPipe
                        + text.embrace($"1,-{w1}") + RP.SpacedPipe
                        + text.embrace($"2,-{w2}");

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