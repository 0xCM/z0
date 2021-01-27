//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    public struct ApiCaptureEmitter
    {
        public static ApiCaptureEmitter create(IWfShell wf, IAsmContext asm, ApiHostUri src, ApiMemberExtract[] extracts)
            => new ApiCaptureEmitter(wf, WfShell.host(typeof(ApiCaptureEmitter)), asm, src, extracts);

        readonly CorrelationToken Ct;

        readonly Index<ApiMemberExtract> Extracts;

        readonly ApiHostUri HostUri;

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
        }

        public void Emit()
        {
            var flow = Wf.Running();
            var x0 = run(Wf, Extracts, EmitExtracts);
            if(x0)
            {
                var x1 = run(Wf, Extracts, ParseExtracts);
                if(x1)
                {
                    var code = x1.Data;
                    if(code.Length != 0)
                    {
                        run(Wf, code, EmitApiHex);
                        run(Wf, code, EmitCil);
                        run(Wf, code, DecodeMembers);
                    }
                }
            }
            Wf.Ran(flow);
        }

        Index<ApiCodeExtract> EmitExtracts(Index<ApiMemberExtract> src)
        {
            var emitted = sys.empty<ApiCodeExtract>();
            var count = src.Length;
            var blocks = src.Map(x => new ApiCodeBlock(x.Address, x.OpUri, x.Encoded));
            var dst = Wf.Db().CapturedExtractFile(HostUri);
            emitted = ApiCodeExtracts.emit(blocks, dst);
            Wf.EmittedTable<ApiCodeExtract>(count, dst);
            return emitted;
        }

        Index<ApiMemberCode> ParseExtracts(Index<ApiMemberExtract> src)
        {
            if(src.Length != 0)
            {
                var parser = ApiExtractParsers.member();
                var parsed = parser.ParseMembers(src);
                Wf.Status(string.Format("Parsed {0} {1} extract blocks", parsed.Count, HostUri));
                return parsed;
            }
            else
                return Index<ApiMemberCode>.Empty;
        }

        Index<ApiHexRow> EmitApiHex(Index<ApiMemberCode> src)
            => ApiHexRows.emit(Wf, HostUri, src.View);

        Index<CilMethod> EmitCil(Index<ApiMemberCode> src)
        {
            var dst = Wf.Db().CapturedCilDataFile(HostUri);
            var count = src.Count;
            var methods = sys.alloc<CilMethod>(count);

            if(count != 0)
            {
                var view = src.View;
                using var writer = dst.Writer();
                for(var i=0u; i<count; i++)
                {
                    ref readonly var parsed = ref memory.skip(view,i);
                    var cil = ClrDynamic.cil(parsed.Address, parsed.OpUri, parsed.Method);
                    methods[i] = cil;
                    writer.WriteLine(cil.Format());
                }

                Wf.EmittedFile(GetType().Name, count, dst);
            }

            return methods;
        }

        AsmRoutines DecodeMembers(Index<ApiMemberCode> src)
        {
            var service = ApiHostAsmEmitter.service(Wf, Asm, HostUri);
            service.Emit(src, out var decoded);
            if(decoded.Count != 0)
            {
                using var match = new AsmAddressMatcher(Wf, Host, Extracts, decoded.Storage, Ct);
                match.Run();
            }
            return decoded;
       }

        static Outcome<T> run<S,T>(IWfShell wf, S src, Func<S,T> f, [CallerMemberName] string caller = null)
        {
            var flow = wf.Running(caller);
            var result = default(Outcome<T>);
            try
            {
                result = f(src);
            }
            catch(Exception e)
            {
                wf.Error(e.Message);
                result = e;
            }
            wf.Ran(flow, caller);
            return result;
        }

        // static Outcome<T> run<S,T>(S src, Func<S,T> f, [CallerMemberName] string caller = null)
        // {
        //     var result = default(Outcome<T>);
        //     try
        //     {
        //         result = f(src);
        //     }
        //     catch(Exception e)
        //     {
        //         result = e;
        //     }

        //     return result;
        // }
    }
}