//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    readonly struct AsmWf : IAsmWf
    {
        public IWfShell Wf {get;}

        public IAsmContext Asm {get;}

        public AsmServices Services {get;}

        public IAsmDecoder Decoder {get;}

        public IAsmFormatter Formatter {get;}

        readonly QuickCapture CaptureService;

        [MethodImpl(Inline), Op]
        public AsmWf(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
            Services = AsmServices.create(wf,asm);
            var config = AsmFormatConfig.DefaultStreamFormat;
            Decoder = Services.RoutineDecoder(config);
            Formatter = Services.Formatter(config);
            CaptureService = wf.CaptureQuick(asm);
        }

        public ReadOnlySpan<AsmRoutineCode> Decode(ReadOnlySpan<MethodInfo> src, FS.FilePath target)
            => Decode(CaptureService.Capture(src), target);

        public void Decode(ReadOnlySpan<ApiCaptureBlock> src, Span<AsmRoutineCode> dst)
        {
            var count = src.Length;
            var decoder = Decoder;
            var formatter = Formatter;
            for(var i=0u; i<count; i++)
            {
                ref readonly var captured = ref skip(src,i);
                if(decoder.Decode(captured, out var fx))
                {
                    var asm = formatter.FormatFunction(fx);
                    seek(dst,i) = new AsmRoutineCode(fx,captured);
                }
            }
        }

        public ReadOnlySpan<AsmRoutineCode> Decode(ReadOnlySpan<ApiCaptureBlock> src, FS.FilePath target)
        {
            var count = src.Length;
            var dst = span<AsmRoutineCode>(count);
            var decoder = Decoder;
            var formatter = Formatter;
            using var writer = target.Writer();
            for(var i=0u; i<count; i++)
            {
                ref readonly var captured = ref skip(src,i);
                if(decoder.Decode(captured, out var fx))
                {
                    seek(dst,i) = new AsmRoutineCode(fx,captured);
                    var asm = formatter.FormatFunction(fx);
                    writer.Write(asm);
                }
            }
            return dst;
        }
    }
}