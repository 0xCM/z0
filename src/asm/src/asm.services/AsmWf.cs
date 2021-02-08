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
    using static z;

    readonly struct AsmWf : IAsmWf
    {
        public IWfShell Wf {get;}

        public IAsmContext Asm {get;}

        public AsmFormatConfig FormatConfig {get;}

        public IAsmDecoder Decoder {get;}

        public IAsmFormatter Formatter {get;}

        public ICaptureAlt CaptureService {get;}

        [MethodImpl(Inline), Op]
        public AsmWf(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
            FormatConfig = AsmFormatConfig.DefaultStreamFormat;
            Decoder = AsmServices.decoder(FormatConfig);
            Formatter = new AsmFormatter(FormatConfig);
            CaptureService = Capture.alt(Wf, Asm);
        }

        public ReadOnlySpan<AsmRoutineCode> Decode(ReadOnlySpan<MethodInfo> src, FS.FilePath target)
            => Decode(CaptureAlt.capture(src), target);

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