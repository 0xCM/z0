//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Z0.Asm;

    [ApiHost]
    public class Processors 
    {
        /// <summary>
        /// Creates a nonparametric process state
        /// </summary>
        [MethodImpl(Inline), Op]
        public static WorkState<T> state<T>(T s0)
            => new WorkState<T>(s0);

        /// <summary>
        /// Creates an asm processor
        /// </summary>
        /// <param name="context">The process context</param>
        [MethodImpl(Inline), Op]
        public static IAsmProcessor Asm(IWfContext wf)
        {
            var processor = new ProcessLocatedAsm(wf) as IAsmProcessor;
            processor.Connect();
            return processor;
        }

        [MethodImpl(Inline), Op]
        public static ProcessHostAsm processor(IWfContext wf, HostInstructions src)
            => new ProcessHostAsm(wf, src);

        [MethodImpl(Inline), Op]
        public static PartProcessor processor(IWfContext wf)
            => new PartProcessor(wf);
        
        /// <summary>
        /// Creates a jmp processor
        /// </summary>
        /// <param name="context">The process context</param>
        [MethodImpl(Inline), Op]
        public static IAsmProcessor<LocatedInstruction> jmp(IWfContext context)
            => new ProcessAsmJmp(context);

        /// <summary>
        /// Creates a command-parametric generic process stated
        /// </summary>
        /// <param name="initial">The initial state</param>
        /// <param name="cmd">A command representative, used for type inference</param>
        /// <typeparam name="C">The command type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static WorkState<C,S> state<C,S>(S initial, C cmd = default)
            where C : unmanaged, IOperands<C>
                => new WorkState<C,S>(initial);

        /// <summary>
        /// Creates a processor parametric in both command and state
        /// </summary>
        /// <param name="cmd">A command represenative, used for type inference</param>
        /// <param name="state">A state representative, used for type inference</param>
        /// <typeparam name="C">The command type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static Worker<C,S> processor<C,S>(C cmd = default, S state = default)
            where C : unmanaged, IOperands<C>
            where S : IWorkState<C,S>
                => default;

        [MethodImpl(Inline)]
        public static Worker<P,C,S> processor<P,C,S>(P p = default, C cmd = default, S state = default)
            where P : unmanaged, IWorker
            where C : unmanaged, IOperands<C>
            where S : IWorkState<C,S>
                => default;
    }
}