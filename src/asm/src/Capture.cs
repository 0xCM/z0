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

    partial class XTend
    {
        public static AsmServices AsmServices(this IWfShell wf)
            => Z0.Asm.AsmServices.create(wf);
    }

    [ApiHost]
    public readonly struct Capture
    {
        [MethodImpl(Inline), Op]
        public static ICaptureServices services(IWfShell wf, IAsmContext asm)
            => new CaptureServices(wf, asm);

        [MethodImpl(Inline), Op]
        public static ICaptureCore core(IWfShell wf, IAsmContext asm)
            => CaptureCore.create(wf);

        [MethodImpl(Inline), Op]
        public static ApiCaptureEmitter emitter(IWfShell wf, IAsmContext asm)
            => new ApiCaptureEmitter(wf, asm);

        [MethodImpl(Inline), Op]
        public static ICaptureAlt alt(IWfShell wf, IAsmContext asm)
            => new CaptureAlt(wf, asm);

        [Op]
        public static CaptureExchange exchange(IAsmContext context)
            => new CaptureExchange(new byte[context.DefaultBufferLength]);

        [Op]
        public static ApiCaptureRunner runner(IWfShell wf, IAsmContext asm)
            => new ApiCaptureRunner(wf, asm);

        [Op]
        public static void run(string[] args)
        {
            using var wf = configure(WfShell.create(args));
            var app = Apps.context(wf, Rng.@default());
            using var control = Capture.runner(wf, new AsmContext(app, wf));
            control.Run();
        }

        internal static ApiHostCaptureSet set(IAsmContext asm, in ApiHostCatalog catalog, ApiCaptureBlocks blocks)
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

        static IWfShell describe(IWfShell wf)
        {
            root.iter(wf.Settings, s => wf.Status(string.Format("{0}:{1}", s.Name, s.Value )));
            return wf;
        }

        static IWfShell configure(IWfShell wf)
            => describe(wf.WithRandom(Rng.@default())
                 .WithHost(WfShell.host(typeof(ApiCaptureRunner)))
                 .WithVerbosity(LogLevel.Babble));
    }
}