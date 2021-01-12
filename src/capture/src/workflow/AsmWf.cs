//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    readonly struct AsmWf : IAsmWf
    {
        public IWfShell Wf {get;}

        public AsmFormatConfig FormatConfig {get;}

        public IAsmDecoder Decoder {get;}

        public IAsmFormatter Formatter {get;}

        [MethodImpl(Inline), Op]
        public AsmWf(IWfShell wf)
        {
            Wf = wf;
            FormatConfig = AsmFormatConfig.DefaultStreamFormat;
            Decoder = asm.decoder(FormatConfig);
            Formatter = new AsmFormatter(FormatConfig);
        }

        public ReadOnlySpan<IdentifiedMethod> Identify(ReadOnlySpan<MethodInfo> src)
            => CaptureAlt.identify(src);

        public Span<LocatedMethod> Locate(ReadOnlySpan<IdentifiedMethod> src)
            => CaptureAlt.locate(src);

        public ReadOnlySpan<ApiCaptureBlock> Capture(ReadOnlySpan<MethodInfo> src)
            => CaptureAlt.capture(src.Map(m =>  new IdentifiedMethod(m.Identify(),m)));

        public ReadOnlySpan<ApiCaptureBlock> Capture(Type src)
            => CaptureAlt.capture(src);

        public ReadOnlySpan<ApiCaptureBlock> Capture(ReadOnlySpan<IdentifiedMethod> src)
            => CaptureAlt.capture(src);

        public ApiCaptureBlock Capture(MethodInfo src, OpIdentity id, Span<byte> buffer)
            => CaptureAlt.capture(src,id,buffer);

        public ApiCaptureBlock Capture(MethodInfo src)
            => CaptureAlt.capture(src);

        public ApiCaptureBlock Capture(IdentifiedMethod src)
            => CaptureAlt.capture(src);

        public ReadOnlySpan<ApiCaptureBlock> Capture(ReadOnlySpan<IdentifiedMethod> src, Span<byte> buffer)
            => CaptureAlt.capture(src, buffer);

        public ApiMemberCapture Capture(in ApiMember src, Span<byte> buffer)
            => CaptureAlt.capture(src, buffer);

        public ApiCaptureBlock Capture(LocatedMethod src, Span<byte> buffer)
            => CaptureAlt.capture(src, buffer);

        public ApiCaptureBlock Capture(IdentifiedMethod src, Span<byte> buffer)
            => CaptureAlt.capture(src,buffer);

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

        public Span<LocatedMethod> Locate(ReadOnlySpan<MethodInfo> src)
            => CaptureAlt.locate(CaptureAlt.identify(src));
    }
}