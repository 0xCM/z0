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
        public static WorkState state(object initial)
            => new WorkState(initial);

        /// <summary>
        /// Creates a nongeneric processor
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Worker processor()
            => default;

        /// <summary>
        /// Creates an asm processor
        /// </summary>
        /// <param name="context">The process context</param>
        [MethodImpl(Inline), Op]
        public static IAsmProcessor Asm(IMachineContext context)
        {
            var processor = new AsmProcessor(context) as IAsmProcessor;
            processor.Connect();
            return processor;
        }

        [MethodImpl(Inline), Op]
        public static IHostProcessor Host(IMachineContext context)
            => new HostProcessor(context);

        [MethodImpl(Inline), Op]
        public static IPartProcessor part(IMachineContext context)
            => new PartProcessor(context);

        [MethodImpl(Inline), Op]
        public static PartFileProcessor PartFiles(IMachineContext context)
            => new PartFileProcessor(context);
        
        /// <summary>
        /// Creates a jmp processor
        /// </summary>
        /// <param name="context">The process context</param>
        [MethodImpl(Inline), Op]
        public static IDataProcessor<LocatedInstruction> jmp(IMachineContext context)
            => new JmpProcessor(context);

        /// <summary>
        /// Creates a command-parametric generic process stated
        /// </summary>
        /// <param name="initial">The initial state</param>
        /// <param name="cmd">A command represenative, used for type inference</param>
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