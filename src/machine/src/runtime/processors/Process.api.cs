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

    [ApiHost]
    public class Process : IApiHost<Process>
    {
        /// <summary>
        /// Creates a nonparametric process state
        /// </summary>
        [MethodImpl(Inline)]
        public static ProcessState state(object initial)
            => new ProcessState(initial);

        /// <summary>
        /// Creates a nongeneric processor
        /// </summary>
        [MethodImpl(Inline)]
        public static Processor create()
            => default;

        /// <summary>
        /// Creates a command-parametric generic process stated
        /// </summary>
        /// <param name="initial">The initial state</param>
        /// <param name="cmd">A command represenative, used for type inference</param>
        /// <typeparam name="C">The command type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static ProcessState<C,S> state<C,S>(S initial, C cmd = default)
            where C : unmanaged, ICommand<C>
                => new ProcessState<C,S>(initial);

        /// <summary>
        /// Creates a processor parametric in both command and state
        /// </summary>
        /// <param name="cmd">A command represenative, used for type inference</param>
        /// <param name="state">A state representative, used for type inference</param>
        /// <typeparam name="C">The command type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static Processor<C,S> create<C,S>(C cmd = default, S state = default)
            where C : unmanaged, ICommand<C>
            where S : IProcessState<C,S>
                => default;

        [MethodImpl(Inline)]
        public static Processor<P,C,S> create<P,C,S>(P p = default, C cmd = default, S state = default)
            where P : unmanaged, IProcessor
            where C : unmanaged, ICommand<C>
            where S : IProcessState<C,S>
                    => default;

        

    }
}