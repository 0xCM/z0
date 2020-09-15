//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    using Z0.Asm;

    public delegate void CpuidProcessStep(Vector128<byte> src);

    [ApiHost]
    public readonly struct AsmProcessors
    {
        public static asci16 process(ReadOnlySpan<CpuidFeature> src, CpuidProcessStep step)
            => CpuidProcessor.Service.Process(src,step ?? OnStep);

        /// <summary>
        /// Creates a nonparametric process state
        /// </summary>
        [MethodImpl(Inline), Op]
        public static AsmWorkerState<T> state<T>(T s0)
            => new AsmWorkerState<T>(s0);

        /// <summary>
        /// Creates an asm processor
        /// </summary>
        /// <param name="context">The process context</param>
        [MethodImpl(Inline), Op]
        public static IApiAsmProcessor create(IWfShell wf)
        {
            var processor = new ApiAsmProcessor(wf) as IApiAsmProcessor;
            processor.Connect();
            return processor;
        }

        [MethodImpl(Inline), Op]
        public static HostAsmProcessor hosts(IWfShell wf, ApiHostRoutines src)
            => new HostAsmProcessor(wf, src);

        [MethodImpl(Inline), Op]
        public static PartAsmProcessor parts(IWfShell wf)
            => new PartAsmProcessor(wf);

        static void OnStep(Vector128<byte> src)
        {

        }
    }
}