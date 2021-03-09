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

    [ApiHost]
    public sealed class AsmServices
    {
        public static AsmServices create(IWfShell wf, IAsmContext asm)
            => new AsmServices(wf, asm);

        [Op]
        public static IAsmContext context(IWfShell wf)
            => new AsmContext(Apps.context(wf), wf);

        [Op]
        public static AsmServices create(IWfShell wf)
            => new AsmServices(wf, context(wf));

        [Op]
        public static IApiHostCapture HostCapture(IWfShell wf)
            => ApiHostCapture.create(wf);

        /// <summary>
        /// Creates an asm processor
        /// </summary>
        /// <param name="context">The process context</param>
        [MethodImpl(Inline), Op]
        public static IApiAsmProcessor ApiProcessor(IWfShell wf)
        {
            var processor = new ApiAsmProcessor(wf) as IApiAsmProcessor;
            processor.Connect();
            return processor;
        }

        [MethodImpl(Inline), Op]
        public static IAsmFormatter formatter(in AsmFormatConfig config)
            => new AsmFormatter(config);

        [MethodImpl(Inline), Op]
        public static ICaptureExchange exchange(BufferToken capture)
            => new CaptureExchangeProxy(capture);

        public static IAsmImmWriter immwriter(IWfShell wf, IAsmContext context, ApiHostUri host)
            => new AsmImmWriter(wf, host, context.Formatter);

        IWfShell Wf {get;}

        IAsmContext Asm {get;}

        AsmFormatConfig FormatConfig;
        [MethodImpl(Inline)]
        AsmServices(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
            FormatConfig = AsmFormatConfig.DefaultStreamFormat;
        }

        [MethodImpl(Inline), Op]
        public IAsmFormatter Formatter(in AsmFormatConfig config)
            => new AsmFormatter(config);

        public void Decode(ReadOnlySpan<ApiCaptureBlock> src, Span<AsmRoutineCode> dst)
        {
            var count = src.Length;
            var decoder = Wf.AsmDecoder(FormatConfig);
            var _formatter = formatter(FormatConfig);
            for(var i=0u; i<count; i++)
            {
                ref readonly var captured = ref skip(src,i);
                if(decoder.Decode(captured, out var routine))
                {
                    var asm = _formatter.Format(routine);
                    seek(dst,i) = new AsmRoutineCode(routine, captured);
                }
            }
        }

        public ReadOnlySpan<AsmRoutineCode> Capture(ReadOnlySpan<MethodInfo> src, FS.FilePath target)
        {
            using var quick = Wf.CaptureQuick(Asm);
            return Decode(quick.Capture(src), target);
        }

        public ReadOnlySpan<AsmRoutineCode> Decode(ReadOnlySpan<ApiCaptureBlock> src, FS.FilePath target)
        {
            var count = src.Length;
            var dst = span<AsmRoutineCode>(count);
            var decoder = Wf.AsmDecoder(FormatConfig);
            var _formatter = formatter(FormatConfig);
            using var writer = target.Writer();
            for(var i=0u; i<count; i++)
            {
                ref readonly var captured = ref skip(src,i);
                if(decoder.Decode(captured, out var fx))
                {
                    seek(dst,i) = new AsmRoutineCode(fx,captured);
                    var asm = _formatter.Format(fx);
                    writer.Write(asm);
                }
            }
            return dst;
        }
    }
}