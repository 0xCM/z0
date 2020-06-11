//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    using Z0.Asm;

    [ApiHost]
    public class Processors : IApiHost<Processors>
    {
        /// <summary>
        /// Creates a nonparametric process state
        /// </summary>
        [MethodImpl(Inline), Op]
        public static ProcessState state(object initial)
            => new ProcessState(initial);

        /// <summary>
        /// Creates a nongeneric processor
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Processor processor()
            => default;

        /// <summary>
        /// Creates an asm processor
        /// </summary>
        /// <param name="context">The process context</param>
        [MethodImpl(Inline), Op]
        public static IAsmProcessor asm(IMachineContext context)
        {
            var processor = new AsmProcessor(context) as IAsmProcessor;
            processor.Connect();
            return processor;
        }

        [MethodImpl(Inline), Op]
        public static IHostProcessor host(IMachineContext context)
            => new HostProcessor(context);

        [MethodImpl(Inline), Op]
        public static IPartProcessor part(IMachineContext context)
            => new PartProcessor(context);

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
        public static ProcessState<C,S> state<C,S>(S initial, C cmd = default)
            where C : unmanaged, ICmd<C>
                => new ProcessState<C,S>(initial);

        /// <summary>
        /// Creates a processor parametric in both command and state
        /// </summary>
        /// <param name="cmd">A command represenative, used for type inference</param>
        /// <param name="state">A state representative, used for type inference</param>
        /// <typeparam name="C">The command type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static Processor<C,S> processor<C,S>(C cmd = default, S state = default)
            where C : unmanaged, ICmd<C>
            where S : IProcessState<C,S>
                => default;

        [MethodImpl(Inline)]
        public static Processor<P,C,S> processor<P,C,S>(P p = default, C cmd = default, S state = default)
            where P : unmanaged, IProcessor
            where C : unmanaged, ICmd<C>
            where S : IProcessState<C,S>
                => default;
    }
}