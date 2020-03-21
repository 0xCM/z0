//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Reflection;
    
    using static Root;

    public readonly struct Context
    {                
        /// <summary>
        /// Defines a stateful context
        /// </summary>
        /// <param name="state">The state with which the context will be imbued</param>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static Context<S> Define<S>(S state)
            => new Context<S>(NextId(), state);

        /// <summary>
        /// Defines a stateless composed context
        /// </summary>
        /// <param name="state">The state with which the context will be imbued</param>
        /// <param name="composition">The composition to which the context has access</param>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static ComposedApiContext Compose(IApiComposition composition)
            => new ComposedApiContext(NextId(), composition);

        /// <summary>
        /// Defines a stateful composed context
        /// </summary>
        /// <param name="state">The state with which the context will be imbued</param>
        /// <param name="composition">The composition to which the context has access</param>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static ComposedContext<S> Compose<S>(S state, IApiComposition composition)
            => new ComposedContext<S>(NextId(), state, composition);

        static int LastId = 0;

        /// <summary>
        /// Dispenses the next context identifier
        /// </summary>
        [MethodImpl(Inline)]
        public static int NextId()        
            => Interlocked.Increment(ref LastId);                    
    }

    /// <summary>
    /// Defines a stateful context
    /// </summary>
    public readonly struct Context<S> : IAppContext<S>
    {
        [MethodImpl(Inline)]
        internal Context(int id, S state)
        {
            this.Identity = id;
            this.State = state;
        }

        /// <summary>
        /// Uniquely identifies the context within an application domain
        /// </summary>
        public readonly int Identity;

        /// <summary>
        /// The context state
        /// </summary>
        public readonly S State;

        S IContext<S>.State 
            => State;
    }
}