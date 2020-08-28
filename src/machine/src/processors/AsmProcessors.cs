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
        public static IAsmProcessor create(IWfContext wf)
        {
            var processor = new ProcessLocatedAsm(wf) as IAsmProcessor;
            processor.Connect();
            return processor;
        }

        [MethodImpl(Inline), Op]
        public static HostAsmProcessor hosts(IWfContext wf, HostAsmFx src)
            => new HostAsmProcessor(wf, src);

        [MethodImpl(Inline), Op]
        public static PartAsmProcessor parts(IWfContext wf)
            => new PartAsmProcessor(wf);

        /// <summary>
        /// Creates a command-parametric generic process stated
        /// </summary>
        /// <param name="initial">The initial state</param>
        /// <param name="cmd">A command representative, used for type inference</param>
        /// <typeparam name="C">The command type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static AsmWorkerState<C,S> state<C,S>(S initial, C cmd = default)
            where C : unmanaged, IAsmOperands<C>
                => new AsmWorkerState<C,S>(initial);

        /// <summary>
        /// Creates a processor parametric in both command and state
        /// </summary>
        /// <param name="cmd">A command representative, used for type inference</param>
        /// <param name="state">A state representative, used for type inference</param>
        /// <typeparam name="C">The command type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static AsmWorker<C,S> worker<C,S>(C cmd = default, S state = default)
            where C : unmanaged, IAsmOperands<C>
            where S : IAsmWorkerState<C,S>
                => default;

        [MethodImpl(Inline)]
        public static AsmWorker<P,C,S> worker<P,C,S>(P p = default, C cmd = default, S state = default)
            where P : unmanaged, IAsmWorker
            where C : unmanaged, IAsmOperands<C>
            where S : IAsmWorkerState<C,S>
                => default;
        static void OnStep(Vector128<byte> src)
        {

        }
    }
}