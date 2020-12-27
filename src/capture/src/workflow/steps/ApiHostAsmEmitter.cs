//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Z0.Asm;

    public struct ApiHostAsmEmitter
    {
        public static ApiHostAsmEmitter service(IWfShell wf, IAsmContext asm, ApiHostUri uri)
            => new ApiHostAsmEmitter(wf, WfShell.host(typeof(ApiHostAsmEmitter)), asm, uri);

        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IAsmContext Asm;

        readonly ApiHostUri Uri;

        public ApiHostAsmEmitter(IWfShell wf, WfHost host, IAsmContext asm, ApiHostUri uri)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Asm = asm;
            Uri = uri;
        }

        public ref AsmRoutines Emit(ReadOnlySpan<ApiMemberCode> src, out AsmRoutines dst)
        {
            var flow = Wf.Running();
            Decode(src, out dst);
            var emitted = Z0.Asm.ApiAsm.emit(Wf, Uri, dst.Storage, Asm.Formatter.Config);
            if(emitted.IsNonEmpty)
                Wf.EmittedFile(dst, dst.Count, emitted);

            Wf.Ran(flow);
            return ref dst;
        }

        void Decode(ReadOnlySpan<ApiMemberCode> src, out AsmRoutines dst)
        {
            using var decoder = ApiHostDecoder.create(Wf, Asm.RoutineDecoder);
            dst = decoder.Decode(Uri, src);
        }
    }
}