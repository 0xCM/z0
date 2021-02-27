//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    public struct ApiHostAsmEmitter
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IAsmContext Asm;

        public ApiHostAsmEmitter(IWfShell wf, IAsmContext asm)
        {
            Host = WfShell.host(nameof(ApiHostAsmEmitter));
            Wf = wf.WithHost(Host);
            Asm = asm;
        }

        public ref AsmRoutines Emit(ApiHostUri host, ReadOnlySpan<ApiMemberCode> src, out AsmRoutines dst)
        {
            var flow = Wf.Running(Msg.EmittingHostRoutines.Format(host));
            Decode(host, src, out dst);
            var emitted = emit(Wf, host, dst.Storage, Asm.Formatter.Config);
            Wf.Ran(flow, Msg.EmittedHostRoutines.Format(src.Length, host, emitted.ToUri()));
            return ref dst;
        }

        void Decode(ApiHostUri host, ReadOnlySpan<ApiMemberCode> src, out AsmRoutines dst)
        {
            var decoder = AsmServices.HostDecoder(Wf, Asm.RoutineDecoder);
            dst = decoder.Decode(host, src);
        }

        static FS.FilePath emit(IWfShell wf, ApiHostUri uri, ReadOnlySpan<AsmRoutine> src, in AsmFormatConfig format)
        {
            var count = src.Length;
            if(count != 0)
            {
                var path = wf.Db().AsmFile(uri);
                using var writer = path.Writer();
                var buffer = Buffers.text();

                for(var i=0; i<count; i++)
                {
                    ref readonly var routine = ref skip(src,i);
                    AsmRender.format(routine, format, buffer);
                    writer.Write(buffer.Emit());
                }
                return path;
            }
            else
                return FS.FilePath.Empty;
        }
    }
}