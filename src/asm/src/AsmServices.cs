//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public sealed class AsmServices
    {
        public static ApiHostCaptureSet decode(IAsmContext asm, in ApiHostCatalog catalog, ApiCaptureBlocks blocks)
        {
            var count = blocks.Length;
            var set = new ApiHostCaptureSet(catalog, blocks, memory.alloc<AsmRoutine>(count));
            var blockview = set.Blocks.View;
            var routines = set.Routines.Edit;
            var decoder = asm.RoutineDecoder;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref memory.skip(blockview,i);
                if(decoder.Decode(block, out var routine))
                    memory.seek(routines, i) = routine;
            }

            return set;
        }

        public static AsmServices create(IWfShell wf, IAsmContext asm)
            => new AsmServices(wf, asm);

        [Op]
        public static IAsmContext context(IWfShell wf)
            => new AsmContext(Apps.context(wf), wf);

        [Op]
        public static AsmServices create(IWfShell wf)
            => new AsmServices(wf, context(wf));

        [Op]
        public static IAsmWf workflow(IWfShell wf)
            => new AsmWf(wf, context(wf));

        public static IImmSpecializer ImmSpecializer(IWfShell wf, IAsmContext asm)
            => new ImmSpecializer(wf, asm);

        [Op]
        public static IAsmDecoder decoder(in AsmFormatConfig config)
            => new AsmRoutineDecoder(config);

        [Op]
        public static ApiCaptureService apicapture(IWfShell wf, IAsmContext asm)
            => ApiCaptureService.create(wf);

        [Op]
        public static ApiResCapture ResCapture(IWfShell wf)
            => ApiResCapture.create(wf);

        [Op]
        public static IApiHostCapture HostCapture(IWfShell wf)
            => ApiHostCapture.create(wf);

        [Op]
        public static ApiHostDecoder HostDecoder(IWfShell wf, IAsmDecoder decoder)
            => new ApiHostDecoder(wf, decoder);

        [Op]
        public static ApiHostAsmEmitter HostEmitter(IWfShell wf, IAsmContext asm)
            => new ApiHostAsmEmitter(wf, asm);

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

        [MethodImpl(Inline)]
        AsmServices(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
        }

        public IAsmDecoder RoutineDecoder(in AsmFormatConfig config)
            => new AsmRoutineDecoder(config);

        public IApiIndexDecoder IndexDecoder()
            => ApiIndexDecoder.create(Wf);

        [MethodImpl(Inline), Op]
        public IAsmFormatter Formatter(in AsmFormatConfig config)
            => new AsmFormatter(config);

        [MethodImpl(Inline), Op]
        public IAsmWriter AsmWriter(FS.FilePath dst, in AsmFormatConfig config)
            => new AsmWriter(dst, formatter(config));
    }
}