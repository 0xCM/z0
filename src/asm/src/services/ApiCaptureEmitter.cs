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

        readonly MsilPipe IlPipe;

        public ApiCaptureEmitter(IWfShell wf)
        {
            Wf = wf;
            IlPipe = Wf.MsilPipe();
        }

        public AsmMemberRoutines Emit(ApiHostUri host, Index<ApiMemberExtract> src)
        {
            var routines = AsmMemberRoutines.Empty;
            try
            {
                var flow = Wf.Running(Msg.RunningHostEmissionWorkflow.Format(host,src.Count));
                var extracts = EmitExtracts(host, src, Wf.Db().RawExtractFile(host));
                var parsed = ParseExtracts(host, src);
                if(parsed.Length != 0)
                {
                    EmitApiHex(host, parsed, Wf.Db().ApiHexFile(host));
                    EmitMsilData(host, parsed, Wf.Db().CilDataPath(host));
                    EmitMsilCode(host, parsed, Wf.Db().CilCodePath(host));
                    routines = DecodeMembers(host, parsed, src);
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
            => ApiHex.emit(Wf, host, src.View, Wf.Db().ApiHexFile(host));

        public Index<ApiHexRow> EmitApiHex(ApiHostUri host, Index<ApiMemberCode> src, FS.FilePath dst)
            => ApiHex.emit(Wf, host, src.View, dst);

        public Count EmitMsilCode(ApiHostUri host, Index<ApiMemberCode> src, FS.FilePath dst)
        {
            if(src.Count != 0)
                IlPipe.EmitMsil(src, dst);
            return src.Count;
        }

        public Count EmitMsilData(ApiHostUri host, Index<ApiMemberCode> src, FS.FilePath dst)
        {
            if(src.Count != 0)
                IlPipe.EmitMsilData(src, dst);

            return src.Count;
        }

        public Index<ApiExtractRow> EmitExtracts(ApiHostUri host, Index<ApiMemberExtract> src, FS.FilePath dst)
        {
            var count = src.Length;
            var blocks = src.Map(x => new ApiExtractBlock(x.Address, x.OpUri, x.Encoded));
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
            => DecodeMembers(host,src,extracts, Wf.Db().AsmFile(host));

        AsmMemberRoutines DecodeMembers(ApiHostUri host, Index<ApiMemberCode> src, Index<ApiMemberExtract> extracts, FS.FilePath dst)
        {
            var emitter = Wf.AsmHostEmitter();
            var decoded = emitter.Emit(host, src, dst);
            if(decoded.Count != 0)
                MatchAddresses(extracts, decoded.AsmRoutines);
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


        void MatchAddresses(ApiMemberExtract[] extracted, AsmRoutine[] decoded)
        {
            try
            {
                var flow = Wf.Running(string.Format("Attempting to match <{0}> routine addresses", extracted.Length));
                var a = extracted.Select(x => x.Address).ToHashSet();
                if(a.Count != extracted.Length)
                {
                    Wf.Error($"count(Extracted) = {extracted.Length} != {a.Count} = count(set(Extracted))");
                    return;
                }

                var b = decoded.Select(f => f.BaseAddress).ToHashSet();
                if(b.Count != decoded.Length)
                {
                    Wf.Error($"count(Decoded) = {decoded.Length} != {b.Count} = count(set(Decoded))");
                    return;
                }

                b.IntersectWith(a);
                if(b.Count != decoded.Length)
                {
                    Wf.Error($"count(Decoded) = {decoded.Length} != {b.Count} = count(intersect(Decoded,Extracted))");
                    return;
                }

                Wf.Ran(flow, string.Format("Matched <{0}> routine addresses", extracted.Length));
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        static ReadOnlySpan<byte> X86TableWidths => new byte[3]{16,80,80};
    }
}